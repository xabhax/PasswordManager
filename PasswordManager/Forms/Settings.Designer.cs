namespace PasswordManager.Forms
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsPassword = new System.Windows.Forms.TextBox();
            this.settingsUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Datafile = new System.Windows.Forms.TextBox();
            this.ApplySettingsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsPassword);
            this.groupBox1.Controls.Add(this.settingsUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Login Info";
            // 
            // settingsPassword
            // 
            this.settingsPassword.Location = new System.Drawing.Point(110, 69);
            this.settingsPassword.Name = "settingsPassword";
            this.settingsPassword.Size = new System.Drawing.Size(152, 22);
            this.settingsPassword.TabIndex = 3;
            // 
            // settingsUsername
            // 
            this.settingsUsername.Location = new System.Drawing.Point(110, 38);
            this.settingsUsername.Name = "settingsUsername";
            this.settingsUsername.Size = new System.Drawing.Size(152, 22);
            this.settingsUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Datafile);
            this.groupBox2.Location = new System.Drawing.Point(13, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Database";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = " . . .";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveDataFile);
            // 
            // Datafile
            // 
            this.Datafile.Location = new System.Drawing.Point(22, 49);
            this.Datafile.Name = "Datafile";
            this.Datafile.Size = new System.Drawing.Size(188, 22);
            this.Datafile.TabIndex = 0;
            // 
            // ApplySettingsButton
            // 
            this.ApplySettingsButton.Location = new System.Drawing.Point(409, 550);
            this.ApplySettingsButton.Name = "ApplySettingsButton";
            this.ApplySettingsButton.Size = new System.Drawing.Size(133, 32);
            this.ApplySettingsButton.TabIndex = 2;
            this.ApplySettingsButton.Text = "Apply Settings";
            this.ApplySettingsButton.UseVisualStyleBackColor = true;
            this.ApplySettingsButton.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 612);
            this.Controls.Add(this.ApplySettingsButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox settingsPassword;
        private System.Windows.Forms.TextBox settingsUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Datafile;
        private System.Windows.Forms.Button ApplySettingsButton;
    }
}