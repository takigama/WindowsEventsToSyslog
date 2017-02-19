namespace SysLogForwarder
{
    partial class ServiceControlDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceControlDialog));
            this.logBox = new System.Windows.Forms.GroupBox();
            this.logViewBox = new System.Windows.Forms.TextBox();
            this.serviceStatus = new System.Windows.Forms.GroupBox();
            this.runInGuiButton = new System.Windows.Forms.Button();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.startServiceButton = new System.Windows.Forms.Button();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.serviceStatusImage = new System.Windows.Forms.PictureBox();
            this.mappingBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mappingFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mappingPrefix = new System.Windows.Forms.TextBox();
            this.mappingRemoveButton = new System.Windows.Forms.Button();
            this.mappingAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.syslogFacility = new System.Windows.Forms.ComboBox();
            this.mappingTrim = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localLog = new System.Windows.Forms.ComboBox();
            this.mappingListView = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.syslogHostname = new System.Windows.Forms.TextBox();
            this.syslogRoleCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.syslogTestButton = new System.Windows.Forms.Button();
            this.syslogRemoveButton = new System.Windows.Forms.Button();
            this.syslogAddButton = new System.Windows.Forms.Button();
            this.syslogProtocolCB = new System.Windows.Forms.ComboBox();
            this.syslogListBox = new System.Windows.Forms.ListBox();
            this.logBox.SuspendLayout();
            this.serviceStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusImage)).BeginInit();
            this.mappingBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Controls.Add(this.logViewBox);
            this.logBox.Location = new System.Drawing.Point(12, 456);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(702, 190);
            this.logBox.TabIndex = 2;
            this.logBox.TabStop = false;
            this.logBox.Text = "Log View";
            // 
            // logViewBox
            // 
            this.logViewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logViewBox.Location = new System.Drawing.Point(6, 21);
            this.logViewBox.Multiline = true;
            this.logViewBox.Name = "logViewBox";
            this.logViewBox.Size = new System.Drawing.Size(690, 158);
            this.logViewBox.TabIndex = 0;
            // 
            // serviceStatus
            // 
            this.serviceStatus.Controls.Add(this.runInGuiButton);
            this.serviceStatus.Controls.Add(this.stopServiceButton);
            this.serviceStatus.Controls.Add(this.startServiceButton);
            this.serviceStatus.Controls.Add(this.uninstallButton);
            this.serviceStatus.Controls.Add(this.installButton);
            this.serviceStatus.Controls.Add(this.serviceStatusImage);
            this.serviceStatus.Location = new System.Drawing.Point(12, 12);
            this.serviceStatus.Name = "serviceStatus";
            this.serviceStatus.Size = new System.Drawing.Size(468, 68);
            this.serviceStatus.TabIndex = 3;
            this.serviceStatus.TabStop = false;
            this.serviceStatus.Text = "Service Status and Control";
            this.serviceStatus.Enter += new System.EventHandler(this.serviceStatus_Enter);
            // 
            // runInGuiButton
            // 
            this.runInGuiButton.Location = new System.Drawing.Point(379, 27);
            this.runInGuiButton.Name = "runInGuiButton";
            this.runInGuiButton.Size = new System.Drawing.Size(75, 23);
            this.runInGuiButton.TabIndex = 5;
            this.runInGuiButton.Text = "Run";
            this.runInGuiButton.UseVisualStyleBackColor = true;
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.Enabled = false;
            this.stopServiceButton.Location = new System.Drawing.Point(298, 27);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(75, 23);
            this.stopServiceButton.TabIndex = 4;
            this.stopServiceButton.Text = "Stop";
            this.stopServiceButton.UseVisualStyleBackColor = true;
            this.stopServiceButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // startServiceButton
            // 
            this.startServiceButton.Enabled = false;
            this.startServiceButton.Location = new System.Drawing.Point(217, 27);
            this.startServiceButton.Name = "startServiceButton";
            this.startServiceButton.Size = new System.Drawing.Size(75, 23);
            this.startServiceButton.TabIndex = 3;
            this.startServiceButton.Text = "Start";
            this.startServiceButton.UseVisualStyleBackColor = true;
            // 
            // uninstallButton
            // 
            this.uninstallButton.Enabled = false;
            this.uninstallButton.Location = new System.Drawing.Point(136, 27);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(75, 23);
            this.uninstallButton.TabIndex = 2;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // installButton
            // 
            this.installButton.Enabled = false;
            this.installButton.Location = new System.Drawing.Point(55, 27);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // serviceStatusImage
            // 
            this.serviceStatusImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("serviceStatusImage.InitialImage")));
            this.serviceStatusImage.Location = new System.Drawing.Point(13, 27);
            this.serviceStatusImage.Name = "serviceStatusImage";
            this.serviceStatusImage.Size = new System.Drawing.Size(36, 23);
            this.serviceStatusImage.TabIndex = 0;
            this.serviceStatusImage.TabStop = false;
            this.serviceStatusImage.Click += new System.EventHandler(this.serviceStatusImage_Click);
            // 
            // mappingBox
            // 
            this.mappingBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingBox.Controls.Add(this.label4);
            this.mappingBox.Controls.Add(this.mappingFilter);
            this.mappingBox.Controls.Add(this.label3);
            this.mappingBox.Controls.Add(this.mappingPrefix);
            this.mappingBox.Controls.Add(this.mappingRemoveButton);
            this.mappingBox.Controls.Add(this.mappingAddButton);
            this.mappingBox.Controls.Add(this.label2);
            this.mappingBox.Controls.Add(this.syslogFacility);
            this.mappingBox.Controls.Add(this.mappingTrim);
            this.mappingBox.Controls.Add(this.label1);
            this.mappingBox.Controls.Add(this.localLog);
            this.mappingBox.Controls.Add(this.mappingListView);
            this.mappingBox.Location = new System.Drawing.Point(12, 91);
            this.mappingBox.Name = "mappingBox";
            this.mappingBox.Size = new System.Drawing.Size(702, 199);
            this.mappingBox.TabIndex = 4;
            this.mappingBox.TabStop = false;
            this.mappingBox.Text = "Mapping/Filtering";
            this.mappingBox.Enter += new System.EventHandler(this.mappingBox_Enter);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filter";
            // 
            // mappingFilter
            // 
            this.mappingFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingFilter.Location = new System.Drawing.Point(575, 109);
            this.mappingFilter.Name = "mappingFilter";
            this.mappingFilter.Size = new System.Drawing.Size(121, 22);
            this.mappingFilter.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prefix";
            // 
            // mappingPrefix
            // 
            this.mappingPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingPrefix.Location = new System.Drawing.Point(575, 81);
            this.mappingPrefix.Name = "mappingPrefix";
            this.mappingPrefix.Size = new System.Drawing.Size(121, 22);
            this.mappingPrefix.TabIndex = 10;
            // 
            // mappingRemoveButton
            // 
            this.mappingRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingRemoveButton.Enabled = false;
            this.mappingRemoveButton.Location = new System.Drawing.Point(621, 170);
            this.mappingRemoveButton.Name = "mappingRemoveButton";
            this.mappingRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.mappingRemoveButton.TabIndex = 8;
            this.mappingRemoveButton.Text = "Remove";
            this.mappingRemoveButton.UseVisualStyleBackColor = true;
            this.mappingRemoveButton.Click += new System.EventHandler(this.mappingRemoveButton_Click);
            // 
            // mappingAddButton
            // 
            this.mappingAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingAddButton.Location = new System.Drawing.Point(540, 170);
            this.mappingAddButton.Name = "mappingAddButton";
            this.mappingAddButton.Size = new System.Drawing.Size(75, 23);
            this.mappingAddButton.TabIndex = 7;
            this.mappingAddButton.Text = "Add";
            this.mappingAddButton.UseVisualStyleBackColor = true;
            this.mappingAddButton.Click += new System.EventHandler(this.mappingAddButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Syslog Facility";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // syslogFacility
            // 
            this.syslogFacility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogFacility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syslogFacility.FormattingEnabled = true;
            this.syslogFacility.Location = new System.Drawing.Point(575, 51);
            this.syslogFacility.Name = "syslogFacility";
            this.syslogFacility.Size = new System.Drawing.Size(121, 24);
            this.syslogFacility.TabIndex = 5;
            this.syslogFacility.SelectedIndexChanged += new System.EventHandler(this.syslogFacility_SelectedIndexChanged);
            // 
            // mappingTrim
            // 
            this.mappingTrim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingTrim.AutoSize = true;
            this.mappingTrim.Location = new System.Drawing.Point(534, 137);
            this.mappingTrim.Name = "mappingTrim";
            this.mappingTrim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mappingTrim.Size = new System.Drawing.Size(54, 20);
            this.mappingTrim.TabIndex = 6;
            this.mappingTrim.Text = "Trim";
            this.mappingTrim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Log";
            // 
            // localLog
            // 
            this.localLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.localLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.localLog.FormattingEnabled = true;
            this.localLog.Location = new System.Drawing.Point(575, 21);
            this.localLog.Name = "localLog";
            this.localLog.Size = new System.Drawing.Size(121, 24);
            this.localLog.TabIndex = 1;
            this.localLog.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mappingListView
            // 
            this.mappingListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mappingListView.FormattingEnabled = true;
            this.mappingListView.HorizontalScrollbar = true;
            this.mappingListView.ItemHeight = 16;
            this.mappingListView.Location = new System.Drawing.Point(6, 27);
            this.mappingListView.Name = "mappingListView";
            this.mappingListView.Size = new System.Drawing.Size(447, 164);
            this.mappingListView.TabIndex = 0;
            this.mappingListView.SelectedIndexChanged += new System.EventHandler(this.mappingListView_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.syslogHostname);
            this.groupBox1.Controls.Add(this.syslogRoleCB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.syslogTestButton);
            this.groupBox1.Controls.Add(this.syslogRemoveButton);
            this.groupBox1.Controls.Add(this.syslogAddButton);
            this.groupBox1.Controls.Add(this.syslogProtocolCB);
            this.groupBox1.Controls.Add(this.syslogListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 154);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Syslog Servers";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Role";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hostname/IP";
            // 
            // syslogHostname
            // 
            this.syslogHostname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogHostname.Location = new System.Drawing.Point(575, 77);
            this.syslogHostname.Name = "syslogHostname";
            this.syslogHostname.Size = new System.Drawing.Size(121, 22);
            this.syslogHostname.TabIndex = 12;
            // 
            // syslogRoleCB
            // 
            this.syslogRoleCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogRoleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syslogRoleCB.FormattingEnabled = true;
            this.syslogRoleCB.Location = new System.Drawing.Point(575, 47);
            this.syslogRoleCB.Name = "syslogRoleCB";
            this.syslogRoleCB.Size = new System.Drawing.Size(121, 24);
            this.syslogRoleCB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Protocol";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // syslogTestButton
            // 
            this.syslogTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogTestButton.Location = new System.Drawing.Point(540, 120);
            this.syslogTestButton.Name = "syslogTestButton";
            this.syslogTestButton.Size = new System.Drawing.Size(75, 23);
            this.syslogTestButton.TabIndex = 9;
            this.syslogTestButton.Text = "Test";
            this.syslogTestButton.UseVisualStyleBackColor = true;
            // 
            // syslogRemoveButton
            // 
            this.syslogRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogRemoveButton.Location = new System.Drawing.Point(621, 120);
            this.syslogRemoveButton.Name = "syslogRemoveButton";
            this.syslogRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.syslogRemoveButton.TabIndex = 8;
            this.syslogRemoveButton.Text = "Remove";
            this.syslogRemoveButton.UseVisualStyleBackColor = true;
            // 
            // syslogAddButton
            // 
            this.syslogAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogAddButton.Location = new System.Drawing.Point(459, 120);
            this.syslogAddButton.Name = "syslogAddButton";
            this.syslogAddButton.Size = new System.Drawing.Size(75, 23);
            this.syslogAddButton.TabIndex = 7;
            this.syslogAddButton.Text = "Add";
            this.syslogAddButton.UseVisualStyleBackColor = true;
            // 
            // syslogProtocolCB
            // 
            this.syslogProtocolCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogProtocolCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syslogProtocolCB.FormattingEnabled = true;
            this.syslogProtocolCB.Location = new System.Drawing.Point(575, 17);
            this.syslogProtocolCB.Name = "syslogProtocolCB";
            this.syslogProtocolCB.Size = new System.Drawing.Size(121, 24);
            this.syslogProtocolCB.TabIndex = 5;
            // 
            // syslogListBox
            // 
            this.syslogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syslogListBox.FormattingEnabled = true;
            this.syslogListBox.ItemHeight = 16;
            this.syslogListBox.Location = new System.Drawing.Point(6, 27);
            this.syslogListBox.Name = "syslogListBox";
            this.syslogListBox.Size = new System.Drawing.Size(447, 116);
            this.syslogListBox.TabIndex = 0;
            // 
            // ServiceControlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mappingBox);
            this.Controls.Add(this.serviceStatus);
            this.Controls.Add(this.logBox);
            this.Name = "ServiceControlDialog";
            this.Text = "Event Forwarder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logBox.ResumeLayout(false);
            this.logBox.PerformLayout();
            this.serviceStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviceStatusImage)).EndInit();
            this.mappingBox.ResumeLayout(false);
            this.mappingBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox logBox;
        private System.Windows.Forms.GroupBox serviceStatus;
        private System.Windows.Forms.TextBox logViewBox;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.PictureBox serviceStatusImage;
        private System.Windows.Forms.Button startServiceButton;
        private System.Windows.Forms.Button stopServiceButton;
        private System.Windows.Forms.GroupBox mappingBox;
        private System.Windows.Forms.ListBox mappingListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox localLog;
        private System.Windows.Forms.ComboBox syslogFacility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mappingRemoveButton;
        private System.Windows.Forms.Button mappingAddButton;
        private System.Windows.Forms.CheckBox mappingTrim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mappingFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mappingPrefix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox syslogHostname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button syslogRemoveButton;
        private System.Windows.Forms.Button syslogAddButton;
        private System.Windows.Forms.ComboBox syslogProtocolCB;
        private System.Windows.Forms.ListBox syslogListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox syslogRoleCB;
        private System.Windows.Forms.Button syslogTestButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button runInGuiButton;
    }
}

