namespace Converter
{
    partial class WM_Login
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
            this.Button_SQLConfiguration = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_SQLConfiguration
            // 
            this.Button_SQLConfiguration.Location = new System.Drawing.Point(268, 12);
            this.Button_SQLConfiguration.Name = "Button_SQLConfiguration";
            this.Button_SQLConfiguration.Size = new System.Drawing.Size(109, 32);
            this.Button_SQLConfiguration.TabIndex = 14;
            this.Button_SQLConfiguration.Text = "Configure SQL";
            this.Button_SQLConfiguration.UseVisualStyleBackColor = true;
            this.Button_SQLConfiguration.Click += new System.EventHandler(this.Button_SQLConfiguration_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(168, 166);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 15;
            this.button_login.Text = "LOG IN";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "PASSWORD";
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "UserCombobox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(133, 78);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(100, 21);
            this.comboBoxUserName.TabIndex = 20;
            this.comboBoxUserName.Text = global::Converter.Properties.Settings.Default.UserCombobox;
            // 
            // textBox_password
            // 
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "UserPass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.Location = new System.Drawing.Point(133, 129);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 17;
            this.textBox_password.Text = global::Converter.Properties.Settings.Default.UserPass;
            // 
            // WM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 244);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.Button_SQLConfiguration);
            this.Name = "WM_Login";
            this.Text = "WM_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SQLConfiguration;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}