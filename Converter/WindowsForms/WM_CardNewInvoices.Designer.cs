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
            this.SuspendLayout();
            // 
            // comboBoxContractor
            // 
            this.comboBoxContractor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "UserCombobox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxContractor.FormattingEnabled = true;
            this.comboBoxContractor.Location = new System.Drawing.Point(37, 58);
            this.comboBoxContractor.Name = "comboBoxContractor";
            this.comboBoxContractor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxContractor.TabIndex = 21;
            this.comboBoxContractor.Text = global::Converter.Properties.Settings.Default.UserCombobox;
            // 
            // WM_CardNewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 399);
            this.Controls.Add(this.comboBoxContractor);
            this.Name = "WM_CardNewInvoices";
            this.Text = "WM_CardNewInvoices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxContractor;
    }
}