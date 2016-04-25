using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Finder.net
{
	public partial class LogForm : Form
	{
		public LogForm()
		{
			InitializeComponent();

			btnClear.Click += new EventHandler(btnClear_Click);
		}

		void btnClear_Click(object sender, EventArgs e)
		{
			tbxLog.Clear();
		}

		public void Add(string data)
		{
			tbxLog.AppendText(data);
			tbxLog.AppendText("\r\n");
			tbxLog.ScrollToCaret();
		}

		public void ScrollText()
		{
			tbxLog.ScrollToCaret();
		}

		private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.Hide();
			}
		}
	}
}
