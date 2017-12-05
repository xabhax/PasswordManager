namespace PasswordManager
{
    partial class Main
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
        public void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.GeneratePassword = new System.Windows.Forms.Button();
            this.AddAccount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.column3});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(555, 499);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddAccount);
            this.groupBox1.Controls.Add(this.GeneratePassword);
            this.groupBox1.Controls.Add(this.ShowPasswordCheckBox);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(612, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 22);
            this.textBox3.TabIndex = 5;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(301, 109);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(18, 17);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // GeneratePassword
            // 
            this.GeneratePassword.Location = new System.Drawing.Point(154, 171);
            this.GeneratePassword.Name = "GeneratePassword";
            this.GeneratePassword.Size = new System.Drawing.Size(165, 28);
            this.GeneratePassword.TabIndex = 7;
            this.GeneratePassword.Text = "Generate Password";
            this.GeneratePassword.UseVisualStyleBackColor = true;
            this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
            // 
            // AddAccount
            // 
            this.AddAccount.Location = new System.Drawing.Point(154, 205);
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.Size = new System.Drawing.Size(165, 28);
            this.AddAccount.TabIndex = 8;
            this.AddAccount.Text = "Add Account";
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(970, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Name = "Main";
            this.Text = "Password Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView;
        public System.Windows.Forms.ColumnHeader column1;
        public System.Windows.Forms.ColumnHeader column2;
        public System.Windows.Forms.ColumnHeader column3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button AddAccount;
        public System.Windows.Forms.Button GeneratePassword;
    }
}

