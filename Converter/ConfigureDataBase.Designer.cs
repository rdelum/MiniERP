namespace Converter
{
    partial class ConfigureDataBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Serwer = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button_TestConnection = new System.Windows.Forms.Button();
            this.checkBox_NT = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDataBase = new System.Windows.Forms.Label();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.comboBoxDataBase = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Serwer";
            // 
            // textBox_Serwer
            // 
            this.textBox_Serwer.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.textBox_Serwer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "SerwerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Serwer.Location = new System.Drawing.Point(169, 46);
            this.textBox_Serwer.Name = "textBox_Serwer";
            this.textBox_Serwer.Size = new System.Drawing.Size(100, 20);
            this.textBox_Serwer.TabIndex = 18;
            this.textBox_Serwer.Text = global::Converter.Properties.Settings.Default.SerwerName;
            // 
            // textBox_password
            // 
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.Location = new System.Drawing.Point(169, 163);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 17;
            this.textBox_password.Text = global::Converter.Properties.Settings.Default.Password;
            // 
            // textBox_login
            // 
            this.textBox_login.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "Login", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_login.Location = new System.Drawing.Point(169, 130);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 16;
            this.textBox_login.Text = global::Converter.Properties.Settings.Default.Login;
            // 
            // button_TestConnection
            // 
            this.button_TestConnection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_TestConnection.Location = new System.Drawing.Point(76, 189);
            this.button_TestConnection.Name = "button_TestConnection";
            this.button_TestConnection.Size = new System.Drawing.Size(193, 23);
            this.button_TestConnection.TabIndex = 14;
            this.button_TestConnection.Text = "Test connection";
            this.button_TestConnection.UseVisualStyleBackColor = true;
            this.button_TestConnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_NT
            // 
            this.checkBox_NT.AutoSize = true;
            this.checkBox_NT.Checked = true;
            this.checkBox_NT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_NT.Location = new System.Drawing.Point(57, 107);
            this.checkBox_NT.Name = "checkBox_NT";
            this.checkBox_NT.Size = new System.Drawing.Size(112, 17);
            this.checkBox_NT.TabIndex = 13;
            this.checkBox_NT.Text = "NT Authentication";
            this.checkBox_NT.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "login";
            // 
            // LabelDataBase
            // 
            this.LabelDataBase.AutoSize = true;
            this.LabelDataBase.Location = new System.Drawing.Point(72, 75);
            this.LabelDataBase.Name = "LabelDataBase";
            this.LabelDataBase.Size = new System.Drawing.Size(53, 13);
            this.LabelDataBase.TabIndex = 10;
            this.LabelDataBase.Text = "Database";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(606, 39);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(146, 23);
            this.buttonAddNewUser.TabIndex = 20;
            this.buttonAddNewUser.Text = "Add new user to ERP";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // comboBoxDataBase
            // 
            this.comboBoxDataBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "DataBaseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxDataBase.FormattingEnabled = true;
            this.comboBoxDataBase.Location = new System.Drawing.Point(169, 72);
            this.comboBoxDataBase.Name = "comboBoxDataBase";
            this.comboBoxDataBase.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDataBase.TabIndex = 21;
            this.comboBoxDataBase.Text = global::Converter.Properties.Settings.Default.DataBaseName;
            // 
            // ConfigureDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 234);
            this.Controls.Add(this.comboBoxDataBase);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Serwer);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_TestConnection);
            this.Controls.Add(this.checkBox_NT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelDataBase);
            this.Name = "ConfigureDataBase";
            this.Text = "ConfigureDataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Serwer;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_TestConnection;
        private System.Windows.Forms.CheckBox checkBox_NT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelDataBase;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.ComboBox comboBoxDataBase;
    }
}