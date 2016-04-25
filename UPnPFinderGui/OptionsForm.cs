using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Finder.net
{
	public partial class OptionsForm : Form
	{
		[DllImport("shell32.dll")]
		static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

		public OptionsForm()
		{
			InitializeComponent();

			lnkHelp.Links[0].LinkData = "http://msdn2.microsoft.com/en-us/library/aa381091(VS.85).aspx";
		}

		private void btnDefault_Click(object sender, EventArgs e)
		{
			numDownloadScope.Value = 1;
			numFileSizeLimit.Value = 102400;
			numMaxCache.Value = 1000;
			numTTL.Value = 1;
			numReceiveScope.Value = 1;
		}

		public decimal DownloadScope { get { return numDownloadScope.Value; } set { numDownloadScope.Value = value; } }
		public decimal FileSizeLimit { get { return numFileSizeLimit.Value; } set { numFileSizeLimit.Value = value; } }
		public decimal MaxCache { get { return numMaxCache.Value; } set { numMaxCache.Value = value; } }
		public decimal TTL { get { return numTTL.Value; } set { numTTL.Value = value; } }
		public decimal ReceiveScope { get { return numReceiveScope.Value; } set { numReceiveScope.Value = value; } }

		private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ShellExecute(IntPtr.Zero, "open", (string)e.Link.LinkData, string.Empty, string.Empty, 1);
		}
	}
}
