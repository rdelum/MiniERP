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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ValueGross = new System.Windows.Forms.TextBox();
            this.textBox_IssuedDocument = new System.Windows.Forms.TextBox();
            this.dataGridViewInvoiceProducts = new System.Windows.Forms.DataGridView();
            this.textBoxInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxContractor = new System.Windows.Forms.ComboBox();
            this.button_AddElementsToInvoice = new System.Windows.Forms.Button();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.Combobox_DefinitionDocumentInvocie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Definition Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Sale date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Value Gross";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Contractor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Issued document";
            // 
            // textBox_ValueGross
            // 
            this.textBox_ValueGross.Location = new System.Drawing.Point(266, 114);
            this.textBox_ValueGross.Name = "textBox_ValueGross";
            this.textBox_ValueGross.Size = new System.Drawing.Size(100, 20);
            this.textBox_ValueGross.TabIndex = 43;
            // 
            // textBox_IssuedDocument
            // 
            this.textBox_IssuedDocument.Location = new System.Drawing.Point(383, 114);
            this.textBox_IssuedDocument.Name = "textBox_IssuedDocument";
            this.textBox_IssuedDocument.Size = new System.Drawing.Size(100, 20);
            this.textBox_IssuedDocument.TabIndex = 44;
            // 
            // dataGridViewInvoiceProducts
            // 
            this.dataGridViewInvoiceProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceProducts.Location = new System.Drawing.Point(39, 175);
            this.dataGridViewInvoiceProducts.Name = "dataGridViewInvoiceProducts";
            this.dataGridViewInvoiceProducts.Size = new System.Drawing.Size(598, 150);
            this.dataGridViewInvoiceProducts.TabIndex = 45;
            // 
            // textBoxInvoiceNumber
            // 
            this.textBoxInvoiceNumber.Location = new System.Drawing.Point(157, 43);
            this.textBoxInvoiceNumber.Name = "textBoxInvoiceNumber";
            this.textBoxInvoiceNumber.ReadOnly = true;
            this.textBoxInvoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxInvoiceNumber.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Invoice number";
            // 
            // comboBoxContractor
            // 
            this.comboBoxContractor.FormattingEnabled = true;
            this.comboBoxContractor.Location = new System.Drawing.Point(36, 113);
            this.comboBoxContractor.Name = "comboBoxContractor";
            this.comboBoxContractor.Size = new System.Drawing.Size(92, 21);
            this.comboBoxContractor.TabIndex = 48;
            this.comboBoxContractor.SelectedIndexChanged += new System.EventHandler(this.comboBoxContractor_SelectedIndexChanged);
            // 
            // button_AddElementsToInvoice
            // 
            this.button_AddElementsToInvoice.Location = new System.Drawing.Point(562, 146);
            this.button_AddElementsToInvoice.Name = "button_AddElementsToInvoice";
            this.button_AddElementsToInvoice.Size = new System.Drawing.Size(75, 23);
            this.button_AddElementsToInvoice.TabIndex = 49;
            this.button_AddElementsToInvoice.Text = "Add";
            this.button_AddElementsToInvoice.UseVisualStyleBackColor = true;
            this.button_AddElementsToInvoice.Click += new System.EventHandler(this.button_AddElementsToInvoice_Click);
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(134, 114);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerSaleDate.TabIndex = 50;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(816, 364);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 52;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // Combobox_DefinitionDocumentInvocie
            // 
            this.Combobox_DefinitionDocumentInvocie.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Converter.Properties.Settings.Default, "InvoiceDefinition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Combobox_DefinitionDocumentInvocie.FormattingEnabled = true;
            this.Combobox_DefinitionDocumentInvocie.Items.AddRange(new object[] {
            "FV",
            "FV",
            "FVKOR"});
            this.Combobox_DefinitionDocumentInvocie.Location = new System.Drawing.Point(36, 43);
            this.Combobox_DefinitionDocumentInvocie.Name = "Combobox_DefinitionDocumentInvocie";
            this.Combobox_DefinitionDocumentInvocie.Size = new System.Drawing.Size(100, 21);
            this.Combobox_DefinitionDocumentInvocie.TabIndex = 21;
            this.Combobox_DefinitionDocumentInvocie.Text = global::Converter.Properties.Settings.Default.InvoiceDefinition;
            // 
            // WM_CardNewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 399);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.button_AddElementsToInvoice);
            this.Controls.Add(this.comboBoxContractor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxInvoiceNumber);
            this.Controls.Add(this.dataGridViewInvoiceProducts);
            this.Controls.Add(this.textBox_IssuedDocument);
            this.Controls.Add(this.textBox_ValueGross);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Combobox_DefinitionDocumentInvocie);
            this.Name = "WM_CardNewInvoices";
            this.Text = "WM_CardNewInvoices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combobox_DefinitionDocumentInvocie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ValueGross;
        private System.Windows.Forms.TextBox textBox_IssuedDocument;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceProducts;
        private System.Windows.Forms.TextBox textBoxInvoiceNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxContractor;
        private System.Windows.Forms.Button button_AddElementsToInvoice;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.Button button_Confirm;
    }
}