namespace Converter
{
    partial class WM_CardNewInvoices
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
            this.comboBoxContractor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxContractor
            // 
            this.comboBoxContractor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "UserCombobox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxContractor.FormattingEnabled = true;
            this.comboBoxContractor.Items.AddRange(new object[] {
            "FV",
            "FV",
            "FVKOR"});
            this.comboBoxContractor.Location = new System.Drawing.Point(25, 62);
            this.comboBoxContractor.Name = "comboBoxContractor";
            this.comboBoxContractor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxContractor.TabIndex = 21;
            this.comboBoxContractor.Text = global::Converter.Properties.Settings.Default.UserCombobox;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Number";
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(159, 62);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(100, 20);
            this.textBox_Number.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Definition Document";
            // 
            // WM_CardNewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 399);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.comboBoxContractor);
            this.Name = "WM_CardNewInvoices";
            this.Text = "WM_CardNewInvoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxContractor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label5;
    }
}