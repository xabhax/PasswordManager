namespace PasswordManager
{
    partial class MainDialog
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SaveDatabaseButton = new System.Windows.Forms.Button();
            this.LoadDatabaseButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.EditAccountsButton = new System.Windows.Forms.Button();
            this.ViewAccountsButton = new System.Windows.Forms.Button();
            this.ViewAccountsButtonSelected = new System.Windows.Forms.Panel();
            this.EditAccountButtonSelected = new System.Windows.Forms.Panel();
            this.SettingsButtonSelected = new System.Windows.Forms.Panel();
            this.LoadDatabaseButtonSelected = new System.Windows.Forms.Panel();
            this.SaveDatabaseButtonSelected = new System.Windows.Forms.Panel();
            this.QuitButtonSelected = new System.Windows.Forms.Panel();
            this.AddAccountButtonSelected = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AddAcountPanel = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SettingsPanel = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PasswordScore = new System.Windows.Forms.TextBox();
            this.AddAccount = new System.Windows.Forms.Button();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.Password2Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WebsiteInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatabaseLocationButton = new System.Windows.Forms.Button();
            this.DatabaseLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MasterPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.AddAcountPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPanel.BackColor = System.Drawing.Color.Gray;
            this.buttonPanel.Controls.Add(this.AddAccountButton);
            this.buttonPanel.Controls.Add(this.QuitButton);
            this.buttonPanel.Controls.Add(this.SaveDatabaseButton);
            this.buttonPanel.Controls.Add(this.LoadDatabaseButton);
            this.buttonPanel.Controls.Add(this.SettingsButton);
            this.buttonPanel.Controls.Add(this.EditAccountsButton);
            this.buttonPanel.Controls.Add(this.ViewAccountsButton);
            this.buttonPanel.Location = new System.Drawing.Point(-1, 73);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(204, 492);
            this.buttonPanel.TabIndex = 1;
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.AutoEllipsis = true;
            this.AddAccountButton.FlatAppearance.BorderSize = 0;
            this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountButton.Location = new System.Drawing.Point(4, 28);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(195, 52);
            this.AddAccountButton.TabIndex = 6;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.AutoEllipsis = true;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(-1, 376);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(200, 52);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // SaveDatabaseButton
            // 
            this.SaveDatabaseButton.AutoEllipsis = true;
            this.SaveDatabaseButton.FlatAppearance.BorderSize = 0;
            this.SaveDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDatabaseButton.Location = new System.Drawing.Point(0, 318);
            this.SaveDatabaseButton.Name = "SaveDatabaseButton";
            this.SaveDatabaseButton.Size = new System.Drawing.Size(200, 52);
            this.SaveDatabaseButton.TabIndex = 4;
            this.SaveDatabaseButton.Text = "Save Database";
            this.SaveDatabaseButton.UseVisualStyleBackColor = true;
            this.SaveDatabaseButton.Click += new System.EventHandler(this.SaveDatabaseButton_Click);
            // 
            // LoadDatabaseButton
            // 
            this.LoadDatabaseButton.AutoEllipsis = true;
            this.LoadDatabaseButton.FlatAppearance.BorderSize = 0;
            this.LoadDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDatabaseButton.Location = new System.Drawing.Point(-1, 260);
            this.LoadDatabaseButton.Name = "LoadDatabaseButton";
            this.LoadDatabaseButton.Size = new System.Drawing.Size(200, 52);
            this.LoadDatabaseButton.TabIndex = 3;
            this.LoadDatabaseButton.Text = "Load Database";
            this.LoadDatabaseButton.UseVisualStyleBackColor = true;
            this.LoadDatabaseButton.Click += new System.EventHandler(this.LoadDatabaseButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoEllipsis = true;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(-1, 202);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(200, 52);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // EditAccountsButton
            // 
            this.EditAccountsButton.AutoEllipsis = true;
            this.EditAccountsButton.FlatAppearance.BorderSize = 0;
            this.EditAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAccountsButton.Location = new System.Drawing.Point(-1, 144);
            this.EditAccountsButton.Name = "EditAccountsButton";
            this.EditAccountsButton.Size = new System.Drawing.Size(200, 52);
            this.EditAccountsButton.TabIndex = 1;
            this.EditAccountsButton.Text = "Edit Account";
            this.EditAccountsButton.UseVisualStyleBackColor = true;
            this.EditAccountsButton.Click += new System.EventHandler(this.EditAccountsButton_Click);
            // 
            // ViewAccountsButton
            // 
            this.ViewAccountsButton.AutoEllipsis = true;
            this.ViewAccountsButton.FlatAppearance.BorderSize = 0;
            this.ViewAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAccountsButton.Location = new System.Drawing.Point(0, 86);
            this.ViewAccountsButton.Name = "ViewAccountsButton";
            this.ViewAccountsButton.Size = new System.Drawing.Size(200, 52);
            this.ViewAccountsButton.TabIndex = 0;
            this.ViewAccountsButton.Text = "View Accounts";
            this.ViewAccountsButton.UseVisualStyleBackColor = true;
            this.ViewAccountsButton.Click += new System.EventHandler(this.ViewAccountsButton_Click);
            // 
            // ViewAccountsButtonSelected
            // 
            this.ViewAccountsButtonSelected.BackColor = System.Drawing.Color.Red;
            this.ViewAccountsButtonSelected.Location = new System.Drawing.Point(208, 159);
            this.ViewAccountsButtonSelected.Name = "ViewAccountsButtonSelected";
            this.ViewAccountsButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.ViewAccountsButtonSelected.TabIndex = 3;
            this.ViewAccountsButtonSelected.Visible = false;
            // 
            // EditAccountButtonSelected
            // 
            this.EditAccountButtonSelected.BackColor = System.Drawing.Color.Red;
            this.EditAccountButtonSelected.Location = new System.Drawing.Point(208, 217);
            this.EditAccountButtonSelected.Name = "EditAccountButtonSelected";
            this.EditAccountButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.EditAccountButtonSelected.TabIndex = 4;
            this.EditAccountButtonSelected.Visible = false;
            // 
            // SettingsButtonSelected
            // 
            this.SettingsButtonSelected.BackColor = System.Drawing.Color.Red;
            this.SettingsButtonSelected.Location = new System.Drawing.Point(208, 275);
            this.SettingsButtonSelected.Name = "SettingsButtonSelected";
            this.SettingsButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.SettingsButtonSelected.TabIndex = 4;
            this.SettingsButtonSelected.Visible = false;
            // 
            // LoadDatabaseButtonSelected
            // 
            this.LoadDatabaseButtonSelected.BackColor = System.Drawing.Color.Red;
            this.LoadDatabaseButtonSelected.Location = new System.Drawing.Point(208, 333);
            this.LoadDatabaseButtonSelected.Name = "LoadDatabaseButtonSelected";
            this.LoadDatabaseButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.LoadDatabaseButtonSelected.TabIndex = 4;
            this.LoadDatabaseButtonSelected.Visible = false;
            // 
            // SaveDatabaseButtonSelected
            // 
            this.SaveDatabaseButtonSelected.BackColor = System.Drawing.Color.Red;
            this.SaveDatabaseButtonSelected.Location = new System.Drawing.Point(208, 391);
            this.SaveDatabaseButtonSelected.Name = "SaveDatabaseButtonSelected";
            this.SaveDatabaseButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.SaveDatabaseButtonSelected.TabIndex = 4;
            this.SaveDatabaseButtonSelected.Visible = false;
            // 
            // QuitButtonSelected
            // 
            this.QuitButtonSelected.BackColor = System.Drawing.Color.Red;
            this.QuitButtonSelected.Location = new System.Drawing.Point(208, 449);
            this.QuitButtonSelected.Name = "QuitButtonSelected";
            this.QuitButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.QuitButtonSelected.TabIndex = 4;
            this.QuitButtonSelected.Visible = false;
            // 
            // AddAccountButtonSelected
            // 
            this.AddAccountButtonSelected.BackColor = System.Drawing.Color.Red;
            this.AddAccountButtonSelected.Location = new System.Drawing.Point(208, 101);
            this.AddAccountButtonSelected.Name = "AddAccountButtonSelected";
            this.AddAccountButtonSelected.Size = new System.Drawing.Size(14, 52);
            this.AddAccountButtonSelected.TabIndex = 4;
            this.AddAccountButtonSelected.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 94);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.AddAcountPanel);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.SettingsPanel);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(228, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(811, 564);
            this.tabControl.TabIndex = 6;
            // 
            // AddAcountPanel
            // 
            this.AddAcountPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddAcountPanel.Controls.Add(this.PasswordScore);
            this.AddAcountPanel.Controls.Add(this.AddAccount);
            this.AddAcountPanel.Controls.Add(this.GeneratePassword);
            this.AddAcountPanel.Controls.Add(this.Password2Input);
            this.AddAcountPanel.Controls.Add(this.label4);
            this.AddAcountPanel.Controls.Add(this.PasswordInput);
            this.AddAcountPanel.Controls.Add(this.UsernameInput);
            this.AddAcountPanel.Controls.Add(this.label3);
            this.AddAcountPanel.Controls.Add(this.label2);
            this.AddAcountPanel.Controls.Add(this.WebsiteInput);
            this.AddAcountPanel.Controls.Add(this.label1);
            this.AddAcountPanel.Location = new System.Drawing.Point(4, 25);
            this.AddAcountPanel.Name = "AddAcountPanel";
            this.AddAcountPanel.Padding = new System.Windows.Forms.Padding(3);
            this.AddAcountPanel.Size = new System.Drawing.Size(803, 535);
            this.AddAcountPanel.TabIndex = 0;
            this.AddAcountPanel.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.listView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SettingsPanel.Controls.Add(this.button2);
            this.SettingsPanel.Controls.Add(this.DatabaseLocationButton);
            this.SettingsPanel.Controls.Add(this.DatabaseLocation);
            this.SettingsPanel.Controls.Add(this.label8);
            this.SettingsPanel.Controls.Add(this.label7);
            this.SettingsPanel.Controls.Add(this.MasterPassword);
            this.SettingsPanel.Location = new System.Drawing.Point(4, 25);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPanel.Size = new System.Drawing.Size(803, 535);
            this.SettingsPanel.TabIndex = 2;
            this.SettingsPanel.Text = "3";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4";
            // 
            // PasswordScore
            // 
            this.PasswordScore.Enabled = false;
            this.PasswordScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordScore.Location = new System.Drawing.Point(350, 290);
            this.PasswordScore.Name = "PasswordScore";
            this.PasswordScore.ReadOnly = true;
            this.PasswordScore.Size = new System.Drawing.Size(269, 27);
            this.PasswordScore.TabIndex = 22;
            this.PasswordScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddAccount
            // 
            this.AddAccount.Enabled = false;
            this.AddAccount.Location = new System.Drawing.Point(454, 379);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(165, 28);
            this.AddAccount.TabIndex = 21;
            this.AddAccount.Text = "Add Account";
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.Location = new System.Drawing.Point(454, 345);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(165, 28);
            this.GeneratePassword.TabIndex = 20;
            this.GeneratePassword.Text = "Generate Password";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // Password2Input
            // 
            this.Password2Input.Location = new System.Drawing.Point(350, 262);
            this.Password2Input.Name = "Password2Input";
            this.Password2Input.Size = new System.Drawing.Size(269, 22);
            this.Password2Input.TabIndex = 19;
            this.Password2Input.TextChanged += new System.EventHandler(this.Password2Input_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Re-Enter Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(350, 217);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(269, 22);
            this.PasswordInput.TabIndex = 17;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(350, 172);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(269, 22);
            this.UsernameInput.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // WebsiteInput
            // 
            this.WebsiteInput.Location = new System.Drawing.Point(350, 128);
            this.WebsiteInput.Name = "WebsiteInput";
            this.WebsiteInput.Size = new System.Drawing.Size(269, 22);
            this.WebsiteInput.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Website";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.column3});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.HoverSelection = true;
            this.listView.Location = new System.Drawing.Point(21, 17);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(755, 504);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // column1
            // 
            this.column1.Text = "Website";
            this.column1.Width = 214;
            // 
            // column2
            // 
            this.column2.Text = "Username";
            this.column2.Width = 150;
            // 
            // column3
            // 
            this.column3.Text = "Password";
            this.column3.Width = 184;
            // 
            // DatabaseLocationButton
            // 
            this.DatabaseLocationButton.Location = new System.Drawing.Point(507, 234);
            this.DatabaseLocationButton.Name = "DatabaseLocationButton";
            this.DatabaseLocationButton.Size = new System.Drawing.Size(47, 30);
            this.DatabaseLocationButton.TabIndex = 10;
            this.DatabaseLocationButton.Text = ". . .";
            this.DatabaseLocationButton.UseVisualStyleBackColor = true;
            this.DatabaseLocationButton.Click += new System.EventHandler(this.DatabaseLocation_Click);
            // 
            // DatabaseLocation
            // 
            this.DatabaseLocation.Location = new System.Drawing.Point(244, 238);
            this.DatabaseLocation.Name = "DatabaseLocation";
            this.DatabaseLocation.ReadOnly = true;
            this.DatabaseLocation.Size = new System.Drawing.Size(257, 22);
            this.DatabaseLocation.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Database Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Master Password";
            // 
            // MasterPassword
            // 
            this.MasterPassword.Location = new System.Drawing.Point(244, 148);
            this.MasterPassword.Name = "MasterPassword";
            this.MasterPassword.Size = new System.Drawing.Size(257, 22);
            this.MasterPassword.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Apply Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp.ContainerControl = this;
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1029, 559);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddAccountButtonSelected);
            this.Controls.Add(this.QuitButtonSelected);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.SaveDatabaseButtonSelected);
            this.Controls.Add(this.ViewAccountsButtonSelected);
            this.Controls.Add(this.LoadDatabaseButtonSelected);
            this.Controls.Add(this.EditAccountButtonSelected);
            this.Controls.Add(this.SettingsButtonSelected);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDialog";
            this.Text = "Password Manager";
            this.buttonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.AddAcountPanel.ResumeLayout(false);
            this.AddAcountPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button ViewAccountsButton;
        private System.Windows.Forms.Button LoadDatabaseButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button EditAccountsButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button SaveDatabaseButton;
        private System.Windows.Forms.Panel ViewAccountsButtonSelected;
        private System.Windows.Forms.Panel EditAccountButtonSelected;
        private System.Windows.Forms.Panel SettingsButtonSelected;
        private System.Windows.Forms.Panel LoadDatabaseButtonSelected;
        private System.Windows.Forms.Panel SaveDatabaseButtonSelected;
        private System.Windows.Forms.Panel QuitButtonSelected;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Panel AddAccountButtonSelected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage AddAcountPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage SettingsPanel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox PasswordScore;
        public System.Windows.Forms.Button AddAccount;
        public System.Windows.Forms.Button GeneratePassword;
        private System.Windows.Forms.TextBox Password2Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WebsiteInput;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView listView;
        public System.Windows.Forms.ColumnHeader column1;
        public System.Windows.Forms.ColumnHeader column2;
        public System.Windows.Forms.ColumnHeader column3;
        private System.Windows.Forms.Button DatabaseLocationButton;
        private System.Windows.Forms.TextBox DatabaseLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MasterPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider erp;
    }
}