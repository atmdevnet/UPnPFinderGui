using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using FindManagerWrapper;
using System.Collections.Specialized;
using System.Windows.Forms.Design;
using Finder.net.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Security.Permissions;


namespace Finder.net
{
	using ArgItem = KeyValuePair<string, string>;
	using ArgInfo = List<KeyValuePair<string, string>>;
	using ArgList = List<List<KeyValuePair<string, string>>>;

	#region CreateProcess structures
	public struct STARTUPINFO
	{
		public uint cb;
		public string lpReserved;
		public string lpDesktop;
		public string lpTitle;
		public uint dwX;
		public uint dwY;
		public uint dwXSize;
		public uint dwYSize;
		public uint dwXCountChars;
		public uint dwYCountChars;
		public uint dwFillAttribute;
		public uint dwFlags;
		public short wShowWindow;
		public short cbReserved2;
		public IntPtr lpReserved2;
		public IntPtr hStdInput;
		public IntPtr hStdOutput;
		public IntPtr hStdError;
	}

	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;
		public IntPtr hThread;
		public uint dwProcessId;
		public uint dwThreadId;
	}
	#endregion
	
	public partial class FinderForm : Form
    {
		private FindManagerNet _finder;

		private LogForm _log = new LogForm();

		private string _appCaption = "Finder.net";
        private string _prefix = "urn:schemas-upnp-org:device:";
		private string _fileName = "devtypes.xml";
		private string _defaultBrowserCmd = "iexplore.exe";
		private string[] _headers;

		internal PropertyGrid PropsGrid { get { return pgdProps; } }

		//[DllImport("shell32.dll")]
		//static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

		[DllImport("kernel32.dll")]
		static extern bool CreateProcess(	string lpApplicationName, string lpCommandLine,
											IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
											bool bInheritHandles, uint dwCreationFlags, 
											IntPtr lpEnvironment, string lpCurrentDirectory, 
											ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

		[DllImport("kernel32.dll")]
		static extern bool CloseHandle(IntPtr hHandle);


		public FinderForm()
        {
            InitializeComponent();

			LoadHelpLinks();

			foreach(Control c in pgdProps.Controls)
				if(c.GetType().Name.Equals("propertygridview", StringComparison.OrdinalIgnoreCase))
					c.MouseDoubleClick += new MouseEventHandler(pgdProps_MouseDoubleClick);

			_headers = new string[lvArgs.Columns.Count];
			for (int i = 0; i < lvArgs.Columns.Count; ++i)
				_headers[i] = lvArgs.Columns[i].Text;

            SetTypes();

			GetDefaultBrowserCmd();

            _finder = new FindManagerNet(SynchronizationContext.Current);
            _finder.OnStartFind += new StartFindEvent(_finder_OnStartFind);
            _finder.OnStopFind += new StopFindEvent(_finder_OnStopFind);
            _finder.OnAddDevice += new AddDeviceEvent(_finder_OnAddDevice);
            _finder.OnRemoveDevice += new RemoveDeviceEvent(_finder_OnRemoveDevice);
			_finder.OnServiceVariableChanged += new ServiceVariableChangedEvent(_finder_OnServiceVariableChanged);
            _finder.OnServiceInstanceDied += new ServiceInstanceDiedEvent(_finder_OnServiceInstanceDied);
        }

        void _finder_OnServiceInstanceDied(object sender, ServiceInstanceDiedArgs e)
        {
			StringBuilder data = new StringBuilder();
			data.Append(">>> Service instance died").AppendLine();
			data.AppendFormat("Service: {0}", e.Service.ServiceID).AppendLine();
			data.AppendFormat("Type: {0}", e.Service.ServiceTypeID).AppendLine();
			data.AppendFormat("In device: {0}", e.Service.ParentDevice.FriendlyName).AppendLine();
			data.Append("__________");
			_log.Add(data.ToString());
        }

		void _finder_OnServiceVariableChanged(object sender, ServiceVariableChangedArgs e)
        {
			StringBuilder data = new StringBuilder();
			data.Append(">>> Service variable changed").AppendLine();
			data.AppendFormat("Variable name: {0}", e.VarName).AppendLine();
			data.AppendFormat("Variable value: {0}", e.VarValue).AppendLine();
			data.AppendFormat("In service: {0}", e.Service.ServiceID).AppendLine();
			data.AppendFormat("Last status: {0}", e.Service.LastTransportStatus).AppendLine();
			data.AppendFormat("Parent device: {0}", e.Service.ParentDevice.FriendlyName).AppendLine();
			data.AppendFormat("Parent device UDN: {0}", e.Service.ParentDevice.UniqueName).AppendLine();
			data.Append("__________");
			_log.Add(data.ToString());
		}

        void _finder_OnRemoveDevice(object sender, RemoveDeviceArgs e)
        {
			StringBuilder data = new StringBuilder();
			data.Append(">>> Device removed").AppendLine();
			data.AppendFormat("Name: {0}", e.FriendlyName).AppendLine();
			data.AppendFormat("UDN: {0}", e.UDN).AppendLine();
			data.AppendFormat("Index: {0}", e.RemovedIndex).AppendLine();
			data.Append("__________");
			_log.Add(data.ToString());

            if (cboDevices.FindStringExact(e.FriendlyName) != e.RemovedIndex)
            {
                _finder.Stop();

                stsLog.Text = "Removing of device failed";
                MessageBox.Show("Searching for devices has been stopped \nbecause of inconsistency between collections.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool removedVisible = cboDevices.SelectedIndex == e.RemovedIndex;

                cboDevices.Items.RemoveAt(e.RemovedIndex);

                if (removedVisible)
                {
					if (e.RemovedIndex < cboDevices.Items.Count)
						cboDevices.SelectedIndex = e.RemovedIndex; // select next
					else
					{
						cboDevices.SelectedIndex = e.RemovedIndex - 1; // select previous
						if (cboDevices.SelectedIndex < 0)
							ClearControls(false);
					}
                }

                stsCount.Text = "Devices: " + cboDevices.Items.Count.ToString();
            }
        }

        void _finder_OnAddDevice(object sender, AddDeviceArgs e)
        {
			StringBuilder data = new StringBuilder();
			data.Append(">>> Device added").AppendLine();
			data.AppendFormat("Name: {0}", e.Device.FriendlyName).AppendLine();
			data.AppendFormat("UDN: {0}", e.Device.UniqueName).AppendLine();
			data.AppendFormat("Index: {0}", e.Index).AppendLine();
			data.Append("__________");

			_log.Add(data.ToString());

			if (cboDevices.Items.Add(e.Device.FriendlyName) != e.Index)
			{
				_finder.Stop();

				stsLog.Text = "Adding of new device failed";
				MessageBox.Show("Searching for devices has been stopped \nbecause of inconsistency between collections.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				stsCount.Text = "Devices: " + cboDevices.Items.Count.ToString();
				if (cboDevices.Items.Count == 1)
					cboDevices.SelectedIndex = 0;
			}
        }

		void _finder_OnStopFind(object sender, StopFindArgs e)
        {
			StringBuilder data = new StringBuilder();
			data.AppendFormat(">>> Searching stopped because of {0}", e.IsCancelled ? "cancel" : "search complete").AppendLine();
			data.Append("__________");
			_log.Add(data.ToString());

			if (e.IsCancelled)
				stsLog.Text = "Searching has been cancelled";
			else
			{
				btnFind.Enabled = true;
				stsLog.Text = "Ready";
			}
        }

        void _finder_OnStartFind(object sender, EventArgs e)
        {
			StringBuilder data = new StringBuilder();
			data.Append(">>> Searching started").AppendLine();
			data.Append("__________");
			_log.Add(data.ToString());

            stsLog.Text = "Searching for devices...";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            btnFind.Enabled = false;

            ClearControls(true);
            stsCount.Text = "Devices: " + cboDevices.Items.Count.ToString();

            if (!_finder.Init(GetFilterValue()) || !_finder.Start())
            {
                btnFind.Enabled = true;
                stsLog.Text = "Start searching failed";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _finder.Stop();
            if (!btnFind.Enabled)
                btnFind.Enabled = true;
        }

        void ClearControls(bool withDevices)
        {
            if(withDevices)
                cboDevices.Items.Clear();
            tvDevices.Nodes.Clear();
            pgdProps.SelectedObject = null;
            lvArgs.Items.Clear();
            tbxOutput.Clear();
        }

		void LoadLinks(DeviceNet devn)
		{
			StringDictionary info = devn.Info;
			if (info != null)
			{
				mnuFilePresentation.Tag = info["presentation url"];
				mnuFileManufacturer.Tag = info["manufacturer url"];
				mnuFileModel.Tag = info["model url"];
				mnuFileDeviceOpen.Tag = info["document url"];
			}
		}

		void LoadHelpLinks()
		{
			mnuLinksCPRef.Tag = "http://msdn2.microsoft.com/en-us/library/aa381109%28VS.85%29.aspx";
			mnuLinksDescr.Tag = "http://support.microsoft.com/kb/323713";
			mnuLinksXP.Tag = "http://technet.microsoft.com/en-us/library/bb457049.aspx";
			mnuLinksConfig.Tag = "http://msdn2.microsoft.com/en-us/library/aa381091(VS.85).aspx";
			mnuLinksFirewall.Tag = "http://support.microsoft.com/kb/886257";
			mnuLinksUPnP.Tag = "http://www.upnp.org/";
		}

		void SwitchMenuOpenSave(bool enable)
		{
			mnuOpen.Enabled = mnuSave.Enabled = enable;
		}

        bool GetTypesFromFile(string fileName, ref ArrayList types)
        {
            XmlReaderSettings rsettings = new XmlReaderSettings();
            rsettings.IgnoreWhitespace = true;
            rsettings.IgnoreComments = true;

            using (XmlReader xr = XmlReader.Create(fileName, rsettings))
            {
                while (xr.Read())
                {
                    if (xr.IsStartElement("device"))
                    {
                        xr.ReadStartElement();
                        types.Add(xr.ReadString());
                    }
                }
            }

            return types.Count > 0;
        }

        void SetTypes()
        {
            ArrayList types = new ArrayList();

            if (!File.Exists(_fileName) || !GetTypesFromFile(_fileName, ref types))
                types.AddRange(FindManagerNet.DeviceTypes);

            string tmp;
            for(int i = 0; i < types.Count; ++i)
            {
                tmp = (string)types[i];
                if (tmp.StartsWith(_prefix))
                    types[i] = tmp.Substring(_prefix.Length);
            }

            cboFilter.Items.AddRange(types.ToArray());
            cboFilter.SelectedIndex = 0;
        }

        string GetFilterValue()
        {
			string tmp = cboFilter.Text;// SelectedItem;
			if (tmp == string.Empty)
				tmp = FindManagerNet.RootDeviceType;
            else if (tmp != FindManagerNet.RootDeviceType)
                tmp = tmp.Insert(0, _prefix);
            return tmp;
        }

        private void cboDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearControls(false);
            
            if(cboDevices.SelectedIndex < 0)
                return;

            DeviceNet dev = _finder.get_Device(cboDevices.SelectedIndex);

			LoadLinks(dev);

            tvDevices.BeginUpdate();
            AddNodes(dev, DeviceNode(dev, true, tvDevices.Nodes));
            tvDevices.EndUpdate();
        }

        void AddNodes(DeviceNet dev, TreeNode parent)
        {
            dev.EnumeratorSwitch = EnumSwitch.Devices;
            foreach (DeviceNet devchild in dev)
                AddNodes(devchild, DeviceNode(devchild, false, parent.Nodes));
        }

        TreeNode DeviceNode(DeviceNet dev, bool isRoot, TreeNodeCollection memberOf)
        {
            TreeNode devnode = new TreeNode(ToFriendlyType(dev.Type, CompType.Device), isRoot ? 0 : 1, isRoot ? 0 : 1);
            devnode.Name = "dev";
            devnode.Tag = dev;

            dev.EnumeratorSwitch = EnumSwitch.Services;
            foreach (ServiceNet srv in dev)
                AddServiceNode(srv, devnode.Nodes);

            memberOf.Add(devnode);

            return devnode;
        }

        void AddServiceNode(ServiceNet srv, TreeNodeCollection memberOf)
        {
            TreeNode srvnode = new TreeNode(ToFriendlyType(srv.ServiceTypeID, CompType.Service), 2, 2);
            srvnode.Name = "srv";
            srvnode.Tag = srv;

            foreach (ActionNet action in srv)
                AddActioneNode(action, srvnode.Nodes);

            memberOf.Add(srvnode);
        }

        void AddActioneNode(ActionNet act, TreeNodeCollection memberOf)
        {
            TreeNode actnode = new TreeNode(act.Name, 3, 3);
            actnode.Name = "act";
            actnode.Tag = act;

            memberOf.Add(actnode);
        }

        string ToFriendlyType(string type, CompType item)
        {
            string prefix = "urn:schemas-upnp-org:";
            prefix += (item == CompType.Device ? "device:" : "service:");
            int prefixlength = prefix.Length;
            if (type.StartsWith(prefix))
                return type.Substring(prefixlength, type.IndexOf(':', prefixlength) - prefixlength);
            return type;
        }

		void FillArgsList(ActionNet act)
		{
			ArgList arglist = act.Info;
			if (arglist != null)
			{
				foreach (ArgInfo arg in arglist)
				{
					string[] subitems = new string[lvArgs.Columns.Count];

					foreach (ArgItem argitem in arg)
					{
						int argIndex = Array.FindIndex<string>(_headers, delegate(string s) {return s == argitem.Key;});
						if (argIndex > -1)
							subitems[argIndex] = argitem.Value;
					}
					
					ListViewItem item = new ListViewItem(subitems);
					lvArgs.Items.Add(item);
				}
			}
		}

        private void tvDevices_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pgdProps.SelectedObject = null;
			lvArgs.Items.Clear();

            if (e.Node.Name == "dev")
            {
                Props props = new Props((DeviceNet)e.Node.Tag);
                pgdProps.SelectedObject = props;
            }
			else if (e.Node.Name == "srv")
			{
				ServiceNet srvn = (ServiceNet)e.Node.Tag;

				mnuFileServiceOpen.Tag = srvn.ScpdURL;

				Props props = new Props(srvn, this);
				pgdProps.SelectedObject = props;
			}
			else if (e.Node.Name == "act")
			{
				ActionNet actn = (ActionNet)e.Node.Tag;

				mnuFileServiceOpen.Tag = ((ServiceNet)e.Node.Parent.Tag).ScpdURL;

				Props props = new Props(actn);
				pgdProps.SelectedObject = props;
				FillArgsList(actn);
			}
        }

        private void toolStrip1_Paint(object sender, PaintEventArgs e)
        {
            cboDevices.Width = btnFind.Bounds.Left - cboDevices.Bounds.Left - 5;
        }

		private void pgdProps_PropertySortChanged(object sender, EventArgs e)
		{
			if (pgdProps.PropertySort == PropertySort.CategorizedAlphabetical)
				pgdProps.PropertySort = PropertySort.Categorized;
		}

		private void pgdProps_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			GridItem item = pgdProps.SelectedGridItem;

			if (item != null && item.PropertyDescriptor.Category == "Links")
				//ShellExecute(IntPtr.Zero, "open", (string)item.Value, string.Empty, string.Empty, 1);
				OpenLink((string)item.Value);
		}

		private void btnAction_Click(object sender, EventArgs e)
		{
			if (tvDevices.SelectedNode != null && tvDevices.SelectedNode.Name == "act")
			{
				ActionNet act = (ActionNet)tvDevices.SelectedNode.Tag;

				if (act.ArgumentInCount > 0)
				{
					bool prompt = false;

					foreach (ArgItem arg in act.Arguments)
						if (prompt = arg.Value.Length == 0)
							break;

					if (prompt && MessageBox.Show("Invoke action?", _appCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						return;
				}
				
				ArgInfo outargs = new ArgInfo();
				int actionResult = act.Invoke(ref outargs);

				// write output arguments values to property grid
				if (actionResult > 0)
				{
					Props props = (Props)pgdProps.SelectedObject;
					ArgInfo.Enumerator oae = outargs.GetEnumerator();
					foreach (PropertyDescriptor descr in props.ComponentProperties)
					{
						if (descr.Category.Equals("output arguments", StringComparison.OrdinalIgnoreCase) && oae.MoveNext())
							descr.SetValue(props, ((ArgItem)oae.Current).Value);
					}
					pgdProps.SelectedObject = props;
				}

				// write result to "Action's result" window
				StringBuilder result = new StringBuilder();
				foreach (ArgItem item in outargs)
					result.Append(item.Value).AppendLine();

				tbxOutput.Text = result.ToString();
			}
		}

		private void FinderForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnAction_Click(btnAction, new EventArgs());
		}

		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mnuOpen_DropDownOpening(object sender, EventArgs e)
		{
			mnuFileServiceOpen.Enabled = (tvDevices.SelectedNode != null && tvDevices.SelectedNode.Name != "dev");
		}

		private void mnuFile_DropDownOpening(object sender, EventArgs e)
		{
			SwitchMenuOpenSave(cboDevices.SelectedIndex > -1);
		}

		private void mnuSave_DropDownOpening(object sender, EventArgs e)
		{
			mnuFileServiceSave.Enabled = (tvDevices.SelectedNode != null && tvDevices.SelectedNode.Name != "dev");
		}

		private void mnuOpen_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			//ShellExecute(IntPtr.Zero, "open", (string)e.ClickedItem.Tag, string.Empty, string.Empty, 1);
			OpenLink((string)e.ClickedItem.Tag);
		}

		private void mnuSave_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			SaveFileDialog fileDlg = new SaveFileDialog();
			fileDlg.AddExtension = true;
			fileDlg.Filter = "XML file (*.xml)|*.xml|Text file (*.txt)|*.txt";
			fileDlg.DefaultExt = "xml";

			if (fileDlg.ShowDialog() != DialogResult.OK)
				return;

			string doc = string.Empty;

			if (e.ClickedItem == mnuFileDeviceSave)
			{
				DeviceNet devn = (DeviceNet)tvDevices.Nodes[0].Tag;
				doc = devn.GetDocumentContent();
			}
			else
			{
				ServiceNet srvn = null;
				object srvobj = tvDevices.SelectedNode.Tag;
				srvn = tvDevices.SelectedNode.Name == "srv" ? (ServiceNet)srvobj : ((ActionNet)srvobj).ParentService;
				doc = srvn.GetScpdContent();
			}

			try
			{
				File.WriteAllText(fileDlg.FileName, doc, Encoding.UTF8);
				MessageBox.Show("Save file succeeded.", _appCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, _appCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnuViewLog_Click(object sender, EventArgs e)
		{
			if (_log.Visible)
				_log.Select();
			else
			{
				_log.Show();
				_log.ScrollText();
			}
		}

		private void mnuToolsSsdp_DropDownOpening(object sender, EventArgs e)
		{
			string statestr = "Error checking";

			SrvState state = SrvState.Stopped;
			if (FindManagerNet.CheckSystemServiceState("ssdpsrv", ref state))
			{
				statestr = state.ToString();

				mnuToolsSsdpStart.Enabled = state == SrvState.Paused ||
											state == SrvState.PausePending ||
											state == SrvState.Stopped ||
											state == SrvState.StopPending;

				mnuToolsSsdpStop.Enabled = state == SrvState.Running ||
											state == SrvState.StartPending ||
											state == SrvState.ContinuePending;
			}

			mnuToolsSsdpState.Text = statestr;
		}

		private void mnuToolsSsdp_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			bool start = e.ClickedItem == mnuToolsSsdpStart;
			string msg = string.Empty;

			if (FindManagerNet.ControlSSDPService(start))
				msg = "Ssdp service has been " + (start ? "started." : "stopped.");
			else
				msg = (start ? "start " : "stop ") + "failled.";

			MessageBox.Show(msg, _appCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void mnuToolsPorts_DropDownOpening(object sender, EventArgs e)
		{
			string statestr = "1900 UDP";
			int result1900 = FindManagerNet.CheckFirewallPortState(1900, Protocol.UDP);

			if (result1900 < 0)
				statestr += " disabled";
			else if (result1900 > 0)
				statestr += " enabled";
			else
				statestr += " error checking";

			mnuToolsPorts1900.Text = statestr;

			statestr = "2869 TCP";
			int result2869 = FindManagerNet.CheckFirewallPortState(2869, Protocol.TCP);

			if (result2869 < 0)
				statestr += " disabled";
			else if (result2869 > 0)
				statestr += " enabled";
			else
				statestr += " error checking";

			mnuToolsPorts2869.Text = statestr;

			mnuToolsPortsOpen.Enabled = (result1900 <= 0 || result2869 <= 0);
			mnuToolsPortsClose.Enabled = (result1900 >= 0 || result2869 >= 0);
		}

		private void mnuToolsPorts_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			bool open = e.ClickedItem == mnuToolsPortsOpen;
			string msg = string.Empty;

			if (FindManagerNet.ControlUPnPPorts(open))
				msg = "UPnP ports were " + (open ? "opened." : "closed.");
			else
				msg = (open ? "open " : "close ") + "failled.";

			MessageBox.Show(msg, _appCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OptionsForm opt = new OptionsForm();

			RegistryKey key = Registry.LocalMachine;
			using (RegistryKey keyDownload = key.OpenSubKey(@"software\microsoft\UPnP Control Point"))
			{
				if(keyDownload != null)
					opt.DownloadScope = (int)keyDownload.GetValue("DownloadScope");
			}
			using (RegistryKey keyFile = key.OpenSubKey(@"software\microsoft\windows\currentversion\upnp"))
			{
				if(keyFile != null)
					opt.FileSizeLimit = (int)keyFile.GetValue("FileSizeLimit");
			}
			using (RegistryKey keyParam = key.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ssdpsrv\parameters"))
			{
				if (keyParam != null)
				{
					opt.MaxCache = (int)keyParam.GetValue("MaxCache");
					opt.TTL = (int)keyParam.GetValue("TTL");
					opt.ReceiveScope = (int)keyParam.GetValue("ReceiveScope");
				}
			}
			key.Close();

			if (opt.ShowDialog(this) == DialogResult.OK)
			{
				if (DialogResult.No == MessageBox.Show("Write data to registry?", _appCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
					return;

				RegistryKey rkey = Registry.LocalMachine;
				using (RegistryKey keyDownload = rkey.OpenSubKey(@"software\microsoft\UPnP Control Point", true))
				{
					if(keyDownload != null)
						keyDownload.SetValue("DownloadScope", opt.DownloadScope, RegistryValueKind.DWord);
				}
				using (RegistryKey keyFile = rkey.OpenSubKey(@"software\microsoft\windows\currentversion\upnp", true))
				{
					if(keyFile != null)
						keyFile.SetValue("FileSizeLimit", opt.FileSizeLimit, RegistryValueKind.DWord);
				}
				using (RegistryKey keyParam = rkey.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ssdpsrv\parameters", true))
				{
					if (keyParam != null)
					{
						keyParam.SetValue("MaxCache", opt.MaxCache, RegistryValueKind.DWord);
						keyParam.SetValue("TTL", opt.TTL, RegistryValueKind.DWord);
						keyParam.SetValue("ReceiveScope", opt.ReceiveScope, RegistryValueKind.DWord);
					}
				}
				rkey.Close();
			}
		}

		private void mnuAboutAbout_Click(object sender, EventArgs e)
		{
			AboutForm about = new AboutForm();
			about.ShowDialog(this);
		}

		private void mnuHelpLinks_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			//ShellExecute(IntPtr.Zero, "open", (string)e.ClickedItem.Tag, string.Empty, string.Empty, 1);
			OpenLink((string)e.ClickedItem.Tag);
		}

		private void OpenLink(string link)
		{
			string cmd = _defaultBrowserCmd + " " + link;

			STARTUPINFO si = new STARTUPINFO();
			PROCESS_INFORMATION pi = new PROCESS_INFORMATION();

			if (CreateProcess(null, cmd, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi))
			{
				CloseHandle(pi.hProcess);
				CloseHandle(pi.hThread);
			}
		}

		private void GetDefaultBrowserCmd()
		{
			RegistryKey key = Registry.ClassesRoot;
			using (RegistryKey keyDefault = key.OpenSubKey(@"http\shell\open\command\"))
			{
				string val;
				if (keyDefault != null && (val = (string)keyDefault.GetValue(null)) != null)
				{
					int lastpos = 0;
					if (val.StartsWith("\"") && (lastpos = val.IndexOf('\"', 1)) > 1)
					{
						val = val.Substring(0, lastpos + 1);
						if (val.EndsWith(".exe\""))
							_defaultBrowserCmd = val;
					}
				}
			}
			key.Close();
		}

	}


	/*******************************************************/
	/*  PropDescr                                          */
	/*******************************************************/


	enum CompType { Device, Service, Action }

    class PropDescr<T> : PropertyDescriptor
    {
        private T _value;
		private bool _readOnly;

        public PropDescr(string name, Attribute[] attribs, T value, bool isReadOnly)
            : base(name, attribs)
        {
            _value = value;
			_readOnly = isReadOnly;
        }
        
        public override object GetValue(object component)
        {
			Props source = (Props)component;

			if (source.ComponentType == CompType.Action)
			{
				if (_value as string == string.Empty)
				{
					int currArgIndex = GetCurrentArgumentIndex(source);
					if (currArgIndex > -1 && currArgIndex < source.ActionComponent.ArgumentInCount)
					{
						object currArg = source.ActionComponent.Arguments[currArgIndex].Value;
						if (currArg != null)
							_value = (T)currArg;
					}
				}
			}

			return _value;
        }

        public override void SetValue(object component, object value) 
        {
			Props source = (Props)component;

			if (source.ComponentType == CompType.Action)
			{
				_value = (T)value;

				int currArgIndex = GetCurrentArgumentIndex(source);
				if (currArgIndex > -1 && currArgIndex < source.ActionComponent.ArgumentInCount)
					source.ActionComponent.set_Argument(currArgIndex, _value as string);
			}
        }

		private int GetCurrentArgumentIndex(Props component)
		{
			PropDescr<T>[] props = new PropDescr<T>[component.ComponentProperties.Count];
			component.ComponentProperties.CopyTo(props, 0);

			PropDescr<T>[] propsIn = Array.FindAll<PropDescr<T>>(props, delegate(PropDescr<T> descr) { return descr.Category.Equals("input arguments", StringComparison.OrdinalIgnoreCase); });
			
			return Array.FindIndex<PropDescr<T>>(propsIn, delegate(PropDescr<T> descr) { return descr.Name == this.Name; });
		}

        public override bool CanResetValue(object component) { return false; }
		public override Type ComponentType { get { return typeof(PropDescr<T>); } }
        public override bool IsReadOnly { get { return _readOnly; } }
        public override Type PropertyType {get { return typeof(T); }}
        public override void ResetValue(object component) {}
        public override bool ShouldSerializeValue(object component) {return false;}
    }


	/*******************************************************/
	/*  Props                                              */
	/*******************************************************/


	class Props : ICustomTypeDescriptor
    {
        private CompType _type = CompType.Device;
        private DeviceNet _dev = null;
        private ServiceNet _srv = null;
        private ActionNet _act = null;
		private StringDictionary _devDescr;
		private StringDictionary _srvDescr;
		private FinderForm _form = null;
		private PropertyDescriptorCollection _props = null;

        public Props(DeviceNet devn)
        {
            _dev = devn;

			_devDescr = new StringDictionary();
			for (int i = 0; i < Props.devDescr.Length; ++i)
				_devDescr.Add(Props.devDescr[i].Key, Props.devDescr[i].Value);

			_props = DeviceProperties();
        }

        public Props(ServiceNet srvn, FinderForm form)
        {
            _srv = srvn;
            _type = CompType.Service;

			_srvDescr = new StringDictionary();
			for (int i = 0; i < Props.srvDescr.Length; ++i)
				_srvDescr.Add(Props.srvDescr[i].Key, Props.srvDescr[i].Value);
			
			_form = form;

			_props = ServiceProperties();
        }

        public Props(ActionNet actn)
        {
            _act = actn;
            _type = CompType.Action;

			_props = ActionProperties();
		}

		static KeyValuePair<string, string>[] devCat = 
		{
			new KeyValuePair<string, string>("Description", "Model info"),
			new KeyValuePair<string, string>("Friendly name", "Model info"),
			new KeyValuePair<string, string>("Model", "Model info"),
			new KeyValuePair<string, string>("Manufacturer", "Model info"),
			new KeyValuePair<string, string>("Manufacturer URL", "Links"),
			new KeyValuePair<string, string>("Model URL", "Links"),
			new KeyValuePair<string, string>("Model number", "Model info"),
			new KeyValuePair<string, string>("Serial number", "Model info"),
			new KeyValuePair<string, string>("Type", "Identification"),
			new KeyValuePair<string, string>("UDN", "Identification"),
			new KeyValuePair<string, string>("UPC", "Model info"),
			new KeyValuePair<string, string>("Presentation URL", "Links"),
			new KeyValuePair<string, string>("Document URL", "Links")
		};

		static KeyValuePair<string, string>[] devDescr = 
		{
			new KeyValuePair<string, string>("Description", "Summary of the device's functionality"),
			new KeyValuePair<string, string>("Friendly name", "Device display name"),
			new KeyValuePair<string, string>("Model", "Model name"),
			new KeyValuePair<string, string>("Manufacturer", "Manufacturer name"),
			new KeyValuePair<string, string>("Manufacturer URL", "Link to manufacturer's web site. Double click on label to navigate to"),
			new KeyValuePair<string, string>("Model URL", "Link to web page that contains model-specific information. Double click on label to navigate to"),
			new KeyValuePair<string, string>("Model number", "Model number"),
			new KeyValuePair<string, string>("Serial number", "Serial number"),
			new KeyValuePair<string, string>("Type", "Device type uniform resource identifier (URI)"),
			new KeyValuePair<string, string>("UDN", "Unique device name"),
			new KeyValuePair<string, string>("UPC", "Device's product code"),
			new KeyValuePair<string, string>("Presentation URL", "Link to web page that controls the device. Double click on label to navigate to"),
			new KeyValuePair<string, string>("Document URL", "Link to device's description document. Double click on label to navigate to")
		};

		static KeyValuePair<string, string>[] srvCat = 
		{
			new KeyValuePair<string, string>("Service ID", "Identification"),
			new KeyValuePair<string, string>("Service type", "Identification"),
			new KeyValuePair<string, string>("Last status", "Activity"),
			new KeyValuePair<string, string>("SCPD URL", "Links")
		};

		static KeyValuePair<string, string>[] srvDescr = 
		{
			new KeyValuePair<string, string>("Service ID", "Service identifier"),
			new KeyValuePair<string, string>("Service type", "Service type identifier"),
			new KeyValuePair<string, string>("Last status", "HTTP status of the last invoke of action"),
			new KeyValuePair<string, string>("SCPD URL", "Link to service's description document. Double click on label to navigate to")
		};

		internal PropertyGrid PropsGrid { get { return _form.PropsGrid; } }
		internal ServiceNet ServiceComponent { get { return _srv; } }
		internal DeviceNet DeviceComponent { get { return _dev; } }
		internal ActionNet ActionComponent { get { return _act; } }
		internal CompType ComponentType { get { return _type; } }
		internal PropertyDescriptorCollection ComponentProperties { get { return _props; } }

		PropertyDescriptorCollection DeviceProperties()
        {
			StringDictionary info = _dev.Info;
			if (info == null)
				return null;

			PropertyDescriptor[] p = new PropertyDescriptor[Props.devCat.Length];

			for(int i = 0; i < p.Length; ++i)
				p[i] = new PropDescr<string>
					(
						Props.devCat[i].Key,
						new Attribute[] 
						{ 
							new CategoryAttribute(Props.devCat[i].Value),
							new DescriptionAttribute(_devDescr[Props.devCat[i].Key]) 
						},
						info[Props.devCat[i].Key],
						false
					);
            
			return new PropertyDescriptorCollection(p);
        }

        PropertyDescriptorCollection ServiceProperties()
        {
			StringDictionary info = _srv.Info;
			if (info == null)
				return null;

			PropertyDescriptor[] p = new PropertyDescriptor[Props.srvCat.Length];

			for (int i = 0; i < p.Length; ++i)
				p[i] = new PropDescr<string>
					(
						Props.srvCat[i].Key,
						new Attribute[] 
						{ 
							new CategoryAttribute(Props.srvCat[i].Value),
							new DescriptionAttribute(_srvDescr[Props.srvCat[i].Key]) 
						},
						info[Props.srvCat[i].Key],
						false
					);

            return new PropertyDescriptorCollection(p);
        }

		PropertyDescriptorCollection ActionProperties()
		{
			ArgList infolist = _act.Info;
			if (infolist == null)
				return null;

			PropertyDescriptor[] p = new PropertyDescriptor[infolist.Count];

			int k = 0;

			foreach (ArgInfo arg in infolist)
			{
				string argdir = arg.Find(delegate(ArgItem item) { return item.Key.Equals("direction", StringComparison.OrdinalIgnoreCase); }).Value;
				bool isInputArgument = argdir.Equals("in", StringComparison.OrdinalIgnoreCase);
				string argname = arg.Find(delegate(ArgItem item) { return item.Key.Equals("arg name", StringComparison.OrdinalIgnoreCase); }).Value;
				string argtype = arg.Find(delegate(ArgItem item) { return item.Key.Equals("type", StringComparison.OrdinalIgnoreCase); }).Value;

				p[k] = new PropDescr<string>
					(
						argname,
						new Attribute[]
						{
							new CategoryAttribute(isInputArgument ? "Input arguments" : "Output arguments"),
							new DescriptionAttribute("Type: " + argtype)
						},
						string.Empty,
						!isInputArgument
					);

				++k;
			}

			return new PropertyDescriptorCollection(p);
		}

        #region ICustomTypeDescriptor Members

        AttributeCollection ICustomTypeDescriptor.GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        string ICustomTypeDescriptor.GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        string ICustomTypeDescriptor.GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        TypeConverter ICustomTypeDescriptor.GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty() {return null;}

        object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
			if(_type == CompType.Service)
				_form.PropsGrid.PropertyTabs.AddTabType(typeof(VarsTab), PropertyTabScope.Component);
			
			return _props;
        }

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
			return ((ICustomTypeDescriptor)this).GetProperties(null);
        }

        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) {return this;}

        #endregion
    }

	
	/*******************************************************/
	/*  VarsTab                                            */
	/*******************************************************/


	class VarsTab : PropertyTab
	{
		public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
		{
			List<KeyValuePair<string, bool>> info = ((Props)component).ServiceComponent.StateVariables;
			if (info == null)
				return null;

			PropertyDescriptor[] p = new PropertyDescriptor[info.Count];

			int i = 0;
			foreach (KeyValuePair<string, bool> kv in info)
			{
				p[i] = new PropDescr<bool>
					(
						kv.Key,
						new Attribute[]
						{
							new CategoryAttribute(kv.Value ? "Evented" : "Non-Evented"),
							new DescriptionAttribute("State variable")
						},
						kv.Value,
						false
					);
				++i;
			}

			return new PropertyDescriptorCollection(p);
		}

		public override string TabName { get { return "State Variables"; } }

		public override Bitmap Bitmap { get { return Resources.Lightning; } }
	}


}
