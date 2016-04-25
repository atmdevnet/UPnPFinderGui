namespace Finder.net
{
	partial class OptionsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numDownloadScope = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numFileSizeLimit = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numReceiveScope = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.numTTL = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.numMaxCache = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDefault = new System.Windows.Forms.Button();
			this.lnkHelp = new System.Windows.Forms.LinkLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numDownloadScope)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFileSizeLimit)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numReceiveScope)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTTL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxCache)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 2);
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Registry settings:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Download scope:";
			// 
			// numDownloadScope
			// 
			this.numDownloadScope.Location = new System.Drawing.Point(119, 38);
			this.numDownloadScope.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numDownloadScope.Name = "numDownloadScope";
			this.numDownloadScope.Size = new System.Drawing.Size(120, 20);
			this.numDownloadScope.TabIndex = 3;
			this.toolTip1.SetToolTip(this.numDownloadScope, "Clik on the following link to get help");
			this.numDownloadScope.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "File size limit:";
			// 
			// numFileSizeLimit
			// 
			this.numFileSizeLimit.Location = new System.Drawing.Point(119, 64);
			this.numFileSizeLimit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.numFileSizeLimit.Minimum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
			this.numFileSizeLimit.Name = "numFileSizeLimit";
			this.numFileSizeLimit.Size = new System.Drawing.Size(120, 20);
			this.numFileSizeLimit.TabIndex = 5;
			this.toolTip1.SetToolTip(this.numFileSizeLimit, "Clik on the following link to get help");
			this.numFileSizeLimit.Value = new decimal(new int[] {
            102400,
            0,
            0,
            0});
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numReceiveScope);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.numTTL);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.numMaxCache);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(15, 99);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(265, 123);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ssdp service:";
			// 
			// numReceiveScope
			// 
			this.numReceiveScope.Location = new System.Drawing.Point(104, 80);
			this.numReceiveScope.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.numReceiveScope.Name = "numReceiveScope";
			this.numReceiveScope.Size = new System.Drawing.Size(120, 20);
			this.numReceiveScope.TabIndex = 5;
			this.toolTip1.SetToolTip(this.numReceiveScope, "Clik on the following link to get help");
			this.numReceiveScope.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Receive scope:";
			// 
			// numTTL
			// 
			this.numTTL.Location = new System.Drawing.Point(104, 54);
			this.numTTL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numTTL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numTTL.Name = "numTTL";
			this.numTTL.Size = new System.Drawing.Size(120, 20);
			this.numTTL.TabIndex = 3;
			this.toolTip1.SetToolTip(this.numTTL, "Clik on the following link to get help");
			this.numTTL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(68, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "TTL:";
			// 
			// numMaxCache
			// 
			this.numMaxCache.Location = new System.Drawing.Point(104, 28);
			this.numMaxCache.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
			this.numMaxCache.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numMaxCache.Name = "numMaxCache";
			this.numMaxCache.Size = new System.Drawing.Size(120, 20);
			this.numMaxCache.TabIndex = 1;
			this.toolTip1.SetToolTip(this.numMaxCache, "Clik on the following link to get help");
			this.numMaxCache.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Max cache:";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(205, 231);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "&Cancel";
			this.toolTip1.SetToolTip(this.btnCancel, "Closes this window without saving of settings");
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(124, 231);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "&Save";
			this.toolTip1.SetToolTip(this.btnSave, "Writes settings into registry");
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnDefault
			// 
			this.btnDefault.Location = new System.Drawing.Point(12, 231);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(75, 23);
			this.btnDefault.TabIndex = 9;
			this.btnDefault.Text = "&Defaults";
			this.toolTip1.SetToolTip(this.btnDefault, "Resets settings to their default values");
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// lnkHelp
			// 
			this.lnkHelp.AutoSize = true;
			this.lnkHelp.Location = new System.Drawing.Point(12, 258);
			this.lnkHelp.Name = "lnkHelp";
			this.lnkHelp.Size = new System.Drawing.Size(131, 13);
			this.lnkHelp.TabIndex = 10;
			this.lnkHelp.TabStop = true;
			this.lnkHelp.Text = "Configuration settings help";
			this.toolTip1.SetToolTip(this.lnkHelp, "Link to help page related to registry settings");
			this.lnkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelp_LinkClicked);
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(292, 280);
			this.Controls.Add(this.lnkHelp);
			this.Controls.Add(this.btnDefault);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.numFileSizeLimit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numDownloadScope);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			((System.ComponentModel.ISupportInitialize)(this.numDownloadScope)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFileSizeLimit)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numReceiveScope)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTTL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxCache)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numDownloadScope;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numFileSizeLimit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numReceiveScope;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numTTL;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numMaxCache;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.LinkLabel lnkHelp;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}