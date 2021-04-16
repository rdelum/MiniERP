namespace Converter
{
    partial class WM_ConfigureSqlLogin
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
            this.textBox_PASStoConfigureSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_loginToConfigureSQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_PASStoConfigureSQL
            // 
            this.textBox_PASStoConfigureSQL.Location = new System.Drawing.Point(107, 51);
            this.textBox_PASStoConfigureSQL.Name = "textBox_PASStoConfigureSQL";
            this.textBox_PASStoConfigureSQL.PasswordChar = '*';
            this.textBox_PASStoConfigureSQL.Size = new System.Drawing.Size(116, 20);
            this.textBox_PASStoConfigureSQL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "enter password to log in";
            // 
            // button_loginToConfigureSQL
            // 
            this.button_loginToConfigureSQL.Location = new System.Drawing.Point(229, 50);
            this.button_loginToConfigureSQL.Name = "button_loginToConfigureSQL";
            this.button_loginToConfigureSQL.Size = new System.Drawing.Size(48, 21);
            this.button_loginToConfigureSQL.TabIndex = 2;
            this.button_loginToConfigureSQL.Text = "Log in";
            this.button_loginToConfigureSQL.UseVisualStyleBackColor = true;
            this.button_loginToConfigureSQL.Click += new System.EventHandler(this.button_loginToConfigureSQL_Click);
            // 
            // WM_ConfigureSqlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 83);
            this.Controls.Add(this.button_loginToConfigureSQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PASStoConfigureSQL);
            this.Name = "WM_ConfigureSqlLogin";
            this.Text = "WM_ConfigureSqlLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PASStoConfigureSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_loginToConfigureSQL;
    }
}