namespace Converter
{
    partial class WM_NewUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.checkBoxAccessContractors = new System.Windows.Forms.CheckBox();
            this.checkBoxEditContractors = new System.Windows.Forms.CheckBox();
            this.checkBoxAcessInvoices = new System.Windows.Forms.CheckBox();
            this.button_AddNewContractorConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "User ";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(151, 60);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 27;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.AcceptsReturn = true;
            this.textBox_UserName.Location = new System.Drawing.Point(34, 60);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserName.TabIndex = 26;
            // 
            // checkBoxAccessContractors
            // 
            this.checkBoxAccessContractors.AutoSize = true;
            this.checkBoxAccessContractors.Location = new System.Drawing.Point(293, 62);
            this.checkBoxAccessContractors.Name = "checkBoxAccessContractors";
            this.checkBoxAccessContractors.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAccessContractors.TabIndex = 34;
            this.checkBoxAccessContractors.Text = "Access to Contractors";
            this.checkBoxAccessContractors.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditContractors
            // 
            this.checkBoxEditContractors.AutoSize = true;
            this.checkBoxEditContractors.Location = new System.Drawing.Point(293, 85);
            this.checkBoxEditContractors.Name = "checkBoxEditContractors";
            this.checkBoxEditContractors.Size = new System.Drawing.Size(101, 17);
            this.checkBoxEditContractors.TabIndex = 35;
            this.checkBoxEditContractors.Text = "Edit Contractors";
            this.checkBoxEditContractors.UseVisualStyleBackColor = true;
            // 
            // checkBoxAcessInvoices
            // 
            this.checkBoxAcessInvoices.AutoSize = true;
            this.checkBoxAcessInvoices.Checked = true;
            this.checkBoxAcessInvoices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAcessInvoices.Location = new System.Drawing.Point(293, 108);
            this.checkBoxAcessInvoices.Name = "checkBoxAcessInvoices";
            this.checkBoxAcessInvoices.Size = new System.Drawing.Size(114, 17);
            this.checkBoxAcessInvoices.TabIndex = 36;
            this.checkBoxAcessInvoices.Text = "Access to Invoces";
            this.checkBoxAcessInvoices.UseVisualStyleBackColor = true;
            // 
            // button_AddNewContractorConfirm
            // 
            this.button_AddNewContractorConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_AddNewContractorConfirm.Location = new System.Drawing.Point(510, 166);
            this.button_AddNewContractorConfirm.Name = "button_AddNewContractorConfirm";
            this.button_AddNewContractorConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewContractorConfirm.TabIndex = 38;
            this.button_AddNewContractorConfirm.Text = "Confirm";
            this.button_AddNewContractorConfirm.UseVisualStyleBackColor = true;
            this.button_AddNewContractorConfirm.Click += new System.EventHandler(this.button_AddNewContractorConfirm_Click);
            // 
            // WM_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 211);
            this.Controls.Add(this.button_AddNewContractorConfirm);
            this.Controls.Add(this.checkBoxAcessInvoices);
            this.Controls.Add(this.checkBoxEditContractors);
            this.Controls.Add(this.checkBoxAccessContractors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Name = "WM_NewUser";
            this.Text = "WM_NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.CheckBox checkBoxAccessContractors;
        private System.Windows.Forms.CheckBox checkBoxEditContractors;
        private System.Windows.Forms.CheckBox checkBoxAcessInvoices;
        private System.Windows.Forms.Button button_AddNewContractorConfirm;
    }
}