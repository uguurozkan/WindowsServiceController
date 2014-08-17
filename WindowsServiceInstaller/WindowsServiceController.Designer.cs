namespace WindowsServiceInstaller
{
    partial class serviceInstallerForm
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
            this.userAccountInformationGB = new System.Windows.Forms.GroupBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.serviceAccountCB = new System.Windows.Forms.CheckBox();
            this.serviceInformationGroup = new System.Windows.Forms.GroupBox();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.serviceNameTB = new System.Windows.Forms.TextBox();
            this.serviceStartTypeLabel = new System.Windows.Forms.Label();
            this.serviceStartTypeCB = new System.Windows.Forms.ComboBox();
            this.serviceDisplayNameLabel = new System.Windows.Forms.Label();
            this.serviceDisplayNameTB = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.installTabPage = new System.Windows.Forms.TabPage();
            this.browseButton = new System.Windows.Forms.Button();
            this.cancelButtonInstall = new System.Windows.Forms.Button();
            this.installButton = new System.Windows.Forms.Button();
            this.uninstallTabPage = new System.Windows.Forms.TabPage();
            this.uninstallLabel = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.servicesListCB = new System.Windows.Forms.ComboBox();
            this.uninstallButton = new System.Windows.Forms.Button();
            this.cancelButtonUninstall = new System.Windows.Forms.Button();
            this.runTabPage = new System.Windows.Forms.TabPage();
            this.runButton = new System.Windows.Forms.Button();
            this.cancelButtonRun = new System.Windows.Forms.Button();
            this.runLabel = new System.Windows.Forms.Label();
            this.servicesLabelrun = new System.Windows.Forms.Label();
            this.runListCB = new System.Windows.Forms.ComboBox();
            this.stopRestartTabPage = new System.Windows.Forms.TabPage();
            this.restartButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.cancelButtonStopRestart = new System.Windows.Forms.Button();
            this.stopRestartLabel = new System.Windows.Forms.Label();
            this.servicesLabelStopRestart = new System.Windows.Forms.Label();
            this.stopRestartListCB = new System.Windows.Forms.ComboBox();
            this.statusTabPage = new System.Windows.Forms.TabPage();
            this.statusLabel = new System.Windows.Forms.Label();
            this.allServicesLabel = new System.Windows.Forms.Label();
            this.cancelButtonStatus = new System.Windows.Forms.Button();
            this.allServicesCB = new System.Windows.Forms.ComboBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userAccountInformationGB.SuspendLayout();
            this.serviceInformationGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.installTabPage.SuspendLayout();
            this.uninstallTabPage.SuspendLayout();
            this.runTabPage.SuspendLayout();
            this.stopRestartTabPage.SuspendLayout();
            this.statusTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // userAccountInformationGB
            // 
            this.userAccountInformationGB.Controls.Add(this.passwordTB);
            this.userAccountInformationGB.Controls.Add(this.passwordLabel);
            this.userAccountInformationGB.Controls.Add(this.usernameLabel);
            this.userAccountInformationGB.Controls.Add(this.usernameTB);
            this.userAccountInformationGB.Location = new System.Drawing.Point(16, 137);
            this.userAccountInformationGB.Name = "userAccountInformationGB";
            this.userAccountInformationGB.Size = new System.Drawing.Size(260, 78);
            this.userAccountInformationGB.TabIndex = 0;
            this.userAccountInformationGB.TabStop = false;
            this.userAccountInformationGB.Text = "User Account";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(99, 46);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(140, 20);
            this.passwordTB.TabIndex = 6;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 49);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(22, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(99, 19);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(140, 20);
            this.usernameTB.TabIndex = 5;
            // 
            // serviceAccountCB
            // 
            this.serviceAccountCB.AutoSize = true;
            this.serviceAccountCB.Location = new System.Drawing.Point(22, 137);
            this.serviceAccountCB.Name = "serviceAccountCB";
            this.serviceAccountCB.Size = new System.Drawing.Size(91, 17);
            this.serviceAccountCB.TabIndex = 4;
            this.serviceAccountCB.Text = "User Account";
            this.serviceAccountCB.UseVisualStyleBackColor = true;
            this.serviceAccountCB.CheckedChanged += new System.EventHandler(this.serviceAccountCB_CheckedChanged);
            // 
            // serviceInformationGroup
            // 
            this.serviceInformationGroup.Controls.Add(this.serviceNameLabel);
            this.serviceInformationGroup.Controls.Add(this.serviceNameTB);
            this.serviceInformationGroup.Controls.Add(this.serviceStartTypeLabel);
            this.serviceInformationGroup.Controls.Add(this.serviceStartTypeCB);
            this.serviceInformationGroup.Controls.Add(this.serviceDisplayNameLabel);
            this.serviceInformationGroup.Controls.Add(this.serviceDisplayNameTB);
            this.serviceInformationGroup.Location = new System.Drawing.Point(17, 16);
            this.serviceInformationGroup.Name = "serviceInformationGroup";
            this.serviceInformationGroup.Size = new System.Drawing.Size(259, 105);
            this.serviceInformationGroup.TabIndex = 1;
            this.serviceInformationGroup.TabStop = false;
            this.serviceInformationGroup.Text = "Service Information";
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Location = new System.Drawing.Point(21, 48);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(74, 13);
            this.serviceNameLabel.TabIndex = 5;
            this.serviceNameLabel.Text = "Service Name";
            // 
            // serviceNameTB
            // 
            this.serviceNameTB.Location = new System.Drawing.Point(98, 45);
            this.serviceNameTB.Name = "serviceNameTB";
            this.serviceNameTB.Size = new System.Drawing.Size(140, 20);
            this.serviceNameTB.TabIndex = 2;
            // 
            // serviceStartTypeLabel
            // 
            this.serviceStartTypeLabel.AutoSize = true;
            this.serviceStartTypeLabel.Location = new System.Drawing.Point(21, 74);
            this.serviceStartTypeLabel.Name = "serviceStartTypeLabel";
            this.serviceStartTypeLabel.Size = new System.Drawing.Size(56, 13);
            this.serviceStartTypeLabel.TabIndex = 3;
            this.serviceStartTypeLabel.Text = "Start Type";
            // 
            // serviceStartTypeCB
            // 
            this.serviceStartTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceStartTypeCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.serviceStartTypeCB.FormattingEnabled = true;
            this.serviceStartTypeCB.Items.AddRange(new object[] {
            "Automatic",
            "Disabled",
            "Manual"});
            this.serviceStartTypeCB.Location = new System.Drawing.Point(98, 71);
            this.serviceStartTypeCB.Name = "serviceStartTypeCB";
            this.serviceStartTypeCB.Size = new System.Drawing.Size(140, 21);
            this.serviceStartTypeCB.TabIndex = 3;
            // 
            // serviceDisplayNameLabel
            // 
            this.serviceDisplayNameLabel.AutoSize = true;
            this.serviceDisplayNameLabel.Location = new System.Drawing.Point(21, 23);
            this.serviceDisplayNameLabel.Name = "serviceDisplayNameLabel";
            this.serviceDisplayNameLabel.Size = new System.Drawing.Size(72, 13);
            this.serviceDisplayNameLabel.TabIndex = 1;
            this.serviceDisplayNameLabel.Text = "Display Name";
            // 
            // serviceDisplayNameTB
            // 
            this.serviceDisplayNameTB.Location = new System.Drawing.Point(98, 20);
            this.serviceDisplayNameTB.Name = "serviceDisplayNameTB";
            this.serviceDisplayNameTB.Size = new System.Drawing.Size(140, 20);
            this.serviceDisplayNameTB.TabIndex = 0;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(19, 236);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // pathTB
            // 
            this.pathTB.Location = new System.Drawing.Point(54, 233);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(161, 20);
            this.pathTB.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.installTabPage);
            this.tabControl1.Controls.Add(this.uninstallTabPage);
            this.tabControl1.Controls.Add(this.runTabPage);
            this.tabControl1.Controls.Add(this.stopRestartTabPage);
            this.tabControl1.Controls.Add(this.statusTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 334);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.refreshServices);
            // 
            // installTabPage
            // 
            this.installTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.installTabPage.Controls.Add(this.browseButton);
            this.installTabPage.Controls.Add(this.cancelButtonInstall);
            this.installTabPage.Controls.Add(this.installButton);
            this.installTabPage.Controls.Add(this.serviceInformationGroup);
            this.installTabPage.Controls.Add(this.serviceAccountCB);
            this.installTabPage.Controls.Add(this.pathLabel);
            this.installTabPage.Controls.Add(this.userAccountInformationGB);
            this.installTabPage.Controls.Add(this.pathTB);
            this.installTabPage.Location = new System.Drawing.Point(4, 22);
            this.installTabPage.Name = "installTabPage";
            this.installTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.installTabPage.Size = new System.Drawing.Size(293, 308);
            this.installTabPage.TabIndex = 0;
            this.installTabPage.Text = "Install";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(221, 230);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(55, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // cancelButtonInstall
            // 
            this.cancelButtonInstall.Location = new System.Drawing.Point(168, 274);
            this.cancelButtonInstall.Name = "cancelButtonInstall";
            this.cancelButtonInstall.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonInstall.TabIndex = 10;
            this.cancelButtonInstall.Text = "Cancel";
            this.cancelButtonInstall.UseVisualStyleBackColor = true;
            this.cancelButtonInstall.Click += new System.EventHandler(this.cancelButtonInstall_Click);
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(41, 274);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(75, 23);
            this.installButton.TabIndex = 9;
            this.installButton.Text = "Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // uninstallTabPage
            // 
            this.uninstallTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.uninstallTabPage.Controls.Add(this.uninstallLabel);
            this.uninstallTabPage.Controls.Add(this.servicesLabel);
            this.uninstallTabPage.Controls.Add(this.servicesListCB);
            this.uninstallTabPage.Controls.Add(this.uninstallButton);
            this.uninstallTabPage.Controls.Add(this.cancelButtonUninstall);
            this.uninstallTabPage.Location = new System.Drawing.Point(4, 22);
            this.uninstallTabPage.Name = "uninstallTabPage";
            this.uninstallTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.uninstallTabPage.Size = new System.Drawing.Size(308, 331);
            this.uninstallTabPage.TabIndex = 1;
            this.uninstallTabPage.Text = "Uninstall";
            // 
            // uninstallLabel
            // 
            this.uninstallLabel.AutoSize = true;
            this.uninstallLabel.Location = new System.Drawing.Point(17, 20);
            this.uninstallLabel.Name = "uninstallLabel";
            this.uninstallLabel.Size = new System.Drawing.Size(142, 13);
            this.uninstallLabel.TabIndex = 11;
            this.uninstallLabel.Text = "Choose a service to remove.";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(17, 59);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(48, 13);
            this.servicesLabel.TabIndex = 10;
            this.servicesLabel.Text = "Services";
            // 
            // servicesListCB
            // 
            this.servicesListCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.servicesListCB.DropDownHeight = 172;
            this.servicesListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesListCB.FormattingEnabled = true;
            this.servicesListCB.IntegralHeight = false;
            this.servicesListCB.Location = new System.Drawing.Point(98, 56);
            this.servicesListCB.MaxDropDownItems = 5;
            this.servicesListCB.Name = "servicesListCB";
            this.servicesListCB.Size = new System.Drawing.Size(172, 21);
            this.servicesListCB.TabIndex = 0;
            // 
            // uninstallButton
            // 
            this.uninstallButton.Location = new System.Drawing.Point(41, 274);
            this.uninstallButton.Name = "uninstallButton";
            this.uninstallButton.Size = new System.Drawing.Size(75, 23);
            this.uninstallButton.TabIndex = 1;
            this.uninstallButton.Text = "Uninstall";
            this.uninstallButton.UseVisualStyleBackColor = true;
            this.uninstallButton.Click += new System.EventHandler(this.uninstallButton_Click);
            // 
            // cancelButtonUninstall
            // 
            this.cancelButtonUninstall.Location = new System.Drawing.Point(168, 274);
            this.cancelButtonUninstall.Name = "cancelButtonUninstall";
            this.cancelButtonUninstall.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonUninstall.TabIndex = 2;
            this.cancelButtonUninstall.Text = "Cancel";
            this.cancelButtonUninstall.UseVisualStyleBackColor = true;
            this.cancelButtonUninstall.Click += new System.EventHandler(this.cancelButtonUninstall_Click);
            // 
            // runTabPage
            // 
            this.runTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.runTabPage.Controls.Add(this.runButton);
            this.runTabPage.Controls.Add(this.cancelButtonRun);
            this.runTabPage.Controls.Add(this.runLabel);
            this.runTabPage.Controls.Add(this.servicesLabelrun);
            this.runTabPage.Controls.Add(this.runListCB);
            this.runTabPage.Location = new System.Drawing.Point(4, 22);
            this.runTabPage.Name = "runTabPage";
            this.runTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.runTabPage.Size = new System.Drawing.Size(308, 331);
            this.runTabPage.TabIndex = 2;
            this.runTabPage.Text = "Run";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(41, 274);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // cancelButtonRun
            // 
            this.cancelButtonRun.Location = new System.Drawing.Point(168, 274);
            this.cancelButtonRun.Name = "cancelButtonRun";
            this.cancelButtonRun.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonRun.TabIndex = 14;
            this.cancelButtonRun.Text = "Cancel";
            this.cancelButtonRun.UseVisualStyleBackColor = true;
            this.cancelButtonRun.Click += new System.EventHandler(this.cancelButtonRun_Click);
            // 
            // runLabel
            // 
            this.runLabel.AutoSize = true;
            this.runLabel.Location = new System.Drawing.Point(17, 20);
            this.runLabel.Name = "runLabel";
            this.runLabel.Size = new System.Drawing.Size(122, 13);
            this.runLabel.TabIndex = 14;
            this.runLabel.Text = "Choose a service to run.";
            // 
            // servicesLabelrun
            // 
            this.servicesLabelrun.AutoSize = true;
            this.servicesLabelrun.Location = new System.Drawing.Point(17, 59);
            this.servicesLabelrun.Name = "servicesLabelrun";
            this.servicesLabelrun.Size = new System.Drawing.Size(48, 13);
            this.servicesLabelrun.TabIndex = 13;
            this.servicesLabelrun.Text = "Services";
            // 
            // runListCB
            // 
            this.runListCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.runListCB.DropDownHeight = 172;
            this.runListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runListCB.FormattingEnabled = true;
            this.runListCB.IntegralHeight = false;
            this.runListCB.Location = new System.Drawing.Point(98, 56);
            this.runListCB.MaxDropDownItems = 5;
            this.runListCB.Name = "runListCB";
            this.runListCB.Size = new System.Drawing.Size(172, 21);
            this.runListCB.TabIndex = 12;
            // 
            // stopRestartTabPage
            // 
            this.stopRestartTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.stopRestartTabPage.Controls.Add(this.restartButton);
            this.stopRestartTabPage.Controls.Add(this.stopButton);
            this.stopRestartTabPage.Controls.Add(this.cancelButtonStopRestart);
            this.stopRestartTabPage.Controls.Add(this.stopRestartLabel);
            this.stopRestartTabPage.Controls.Add(this.servicesLabelStopRestart);
            this.stopRestartTabPage.Controls.Add(this.stopRestartListCB);
            this.stopRestartTabPage.Location = new System.Drawing.Point(4, 22);
            this.stopRestartTabPage.Name = "stopRestartTabPage";
            this.stopRestartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.stopRestartTabPage.Size = new System.Drawing.Size(308, 331);
            this.stopRestartTabPage.TabIndex = 3;
            this.stopRestartTabPage.Text = "Stop/Restart";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(101, 278);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 17;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(20, 278);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // cancelButtonStopRestart
            // 
            this.cancelButtonStopRestart.Location = new System.Drawing.Point(195, 278);
            this.cancelButtonStopRestart.Name = "cancelButtonStopRestart";
            this.cancelButtonStopRestart.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonStopRestart.TabIndex = 18;
            this.cancelButtonStopRestart.Text = "Cancel";
            this.cancelButtonStopRestart.UseVisualStyleBackColor = true;
            this.cancelButtonStopRestart.Click += new System.EventHandler(this.cancelButtonStopRestart_Click);
            // 
            // stopRestartLabel
            // 
            this.stopRestartLabel.AutoSize = true;
            this.stopRestartLabel.Location = new System.Drawing.Point(17, 20);
            this.stopRestartLabel.Name = "stopRestartLabel";
            this.stopRestartLabel.Size = new System.Drawing.Size(161, 13);
            this.stopRestartLabel.TabIndex = 17;
            this.stopRestartLabel.Text = "Choose a service to stop/restart.";
            // 
            // servicesLabelStopRestart
            // 
            this.servicesLabelStopRestart.AutoSize = true;
            this.servicesLabelStopRestart.Location = new System.Drawing.Point(17, 59);
            this.servicesLabelStopRestart.Name = "servicesLabelStopRestart";
            this.servicesLabelStopRestart.Size = new System.Drawing.Size(48, 13);
            this.servicesLabelStopRestart.TabIndex = 16;
            this.servicesLabelStopRestart.Text = "Services";
            // 
            // stopRestartListCB
            // 
            this.stopRestartListCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stopRestartListCB.DropDownHeight = 172;
            this.stopRestartListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopRestartListCB.FormattingEnabled = true;
            this.stopRestartListCB.IntegralHeight = false;
            this.stopRestartListCB.Location = new System.Drawing.Point(98, 56);
            this.stopRestartListCB.MaxDropDownItems = 5;
            this.stopRestartListCB.Name = "stopRestartListCB";
            this.stopRestartListCB.Size = new System.Drawing.Size(172, 21);
            this.stopRestartListCB.TabIndex = 15;
            // 
            // statusTabPage
            // 
            this.statusTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.statusTabPage.Controls.Add(this.statusLabel);
            this.statusTabPage.Controls.Add(this.allServicesLabel);
            this.statusTabPage.Controls.Add(this.cancelButtonStatus);
            this.statusTabPage.Controls.Add(this.allServicesCB);
            this.statusTabPage.Controls.Add(this.statusTB);
            this.statusTabPage.Location = new System.Drawing.Point(4, 22);
            this.statusTabPage.Name = "statusTabPage";
            this.statusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusTabPage.Size = new System.Drawing.Size(308, 331);
            this.statusTabPage.TabIndex = 4;
            this.statusTabPage.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(17, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(209, 13);
            this.statusLabel.TabIndex = 18;
            this.statusLabel.Text = "Choose or type a service to learn its status.";
            // 
            // allServicesLabel
            // 
            this.allServicesLabel.AutoSize = true;
            this.allServicesLabel.Location = new System.Drawing.Point(17, 59);
            this.allServicesLabel.Name = "allServicesLabel";
            this.allServicesLabel.Size = new System.Drawing.Size(48, 13);
            this.allServicesLabel.TabIndex = 17;
            this.allServicesLabel.Text = "Services";
            // 
            // cancelButtonStatus
            // 
            this.cancelButtonStatus.Location = new System.Drawing.Point(168, 274);
            this.cancelButtonStatus.Name = "cancelButtonStatus";
            this.cancelButtonStatus.Size = new System.Drawing.Size(75, 23);
            this.cancelButtonStatus.TabIndex = 16;
            this.cancelButtonStatus.Text = "Cancel";
            this.cancelButtonStatus.UseVisualStyleBackColor = true;
            this.cancelButtonStatus.Click += new System.EventHandler(this.cancelButtonStatus_Click);
            // 
            // allServicesCB
            // 
            this.allServicesCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.allServicesCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.allServicesCB.DropDownHeight = 143;
            this.allServicesCB.FormattingEnabled = true;
            this.allServicesCB.IntegralHeight = false;
            this.allServicesCB.Location = new System.Drawing.Point(95, 56);
            this.allServicesCB.MaxDropDownItems = 11;
            this.allServicesCB.Name = "allServicesCB";
            this.allServicesCB.Size = new System.Drawing.Size(172, 21);
            this.allServicesCB.TabIndex = 1;
            this.allServicesCB.SelectedIndexChanged += new System.EventHandler(this.allServicesCB_SelectedIndexChanged);
            // 
            // statusTB
            // 
            this.statusTB.BackColor = System.Drawing.Color.Black;
            this.statusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTB.ForeColor = System.Drawing.Color.White;
            this.statusTB.Location = new System.Drawing.Point(20, 228);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(247, 26);
            this.statusTB.TabIndex = 0;
            this.statusTB.Text = "Program is starting...";
            this.statusTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.Filter = "Executable files | *.exe";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.refreshServices);
            // 
            // serviceInstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(301, 334);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "serviceInstallerForm";
            this.Text = "Windows Service Controller";
            this.Load += new System.EventHandler(this.serviceInstallerForm_Load);
            this.userAccountInformationGB.ResumeLayout(false);
            this.userAccountInformationGB.PerformLayout();
            this.serviceInformationGroup.ResumeLayout(false);
            this.serviceInformationGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.installTabPage.ResumeLayout(false);
            this.installTabPage.PerformLayout();
            this.uninstallTabPage.ResumeLayout(false);
            this.uninstallTabPage.PerformLayout();
            this.runTabPage.ResumeLayout(false);
            this.runTabPage.PerformLayout();
            this.stopRestartTabPage.ResumeLayout(false);
            this.stopRestartTabPage.PerformLayout();
            this.statusTabPage.ResumeLayout(false);
            this.statusTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userAccountInformationGB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.GroupBox serviceInformationGroup;
        private System.Windows.Forms.TextBox serviceDisplayNameTB;
        private System.Windows.Forms.Label serviceDisplayNameLabel;
        private System.Windows.Forms.ComboBox serviceStartTypeCB;
        private System.Windows.Forms.Label serviceStartTypeLabel;
        private System.Windows.Forms.CheckBox serviceAccountCB;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage installTabPage;
        private System.Windows.Forms.TabPage uninstallTabPage;
        private System.Windows.Forms.Button cancelButtonInstall;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.Button uninstallButton;
        private System.Windows.Forms.Button cancelButtonUninstall;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.ComboBox servicesListCB;
        private System.Windows.Forms.Label uninstallLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.TextBox serviceNameTB;
        private System.Windows.Forms.TabPage runTabPage;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button cancelButtonRun;
        private System.Windows.Forms.Label runLabel;
        private System.Windows.Forms.Label servicesLabelrun;
        private System.Windows.Forms.ComboBox runListCB;
        private System.Windows.Forms.TabPage stopRestartTabPage;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button cancelButtonStopRestart;
        private System.Windows.Forms.Label stopRestartLabel;
        private System.Windows.Forms.Label servicesLabelStopRestart;
        private System.Windows.Forms.ComboBox stopRestartListCB;
        private System.Windows.Forms.TabPage statusTabPage;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.Label allServicesLabel;
        private System.Windows.Forms.Button cancelButtonStatus;
        private System.Windows.Forms.ComboBox allServicesCB;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

