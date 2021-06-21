
namespace Converter
{
    partial class WM_AddElementsToInvoice
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
            this.button_AddNewContractorConfirm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_QTY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStock = new System.Windows.Forms.ComboBox();
            this.textBoxValueNET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NumberInvoice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddNewContractorConfirm
            // 
            this.button_AddNewContractorConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_AddNewContractorConfirm.Location = new System.Drawing.Point(504, 158);
            this.button_AddNewContractorConfirm.Name = "button_AddNewContractorConfirm";
            this.button_AddNewContractorConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewContractorConfirm.TabIndex = 47;
            this.button_AddNewContractorConfirm.Text = "Confirm";
            this.button_AddNewContractorConfirm.UseVisualStyleBackColor = true;
            this.button_AddNewContractorConfirm.Click += new System.EventHandler(this.button_AddNewContractorConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(191, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Add new product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Code";
            // 
            // textBox_QTY
            // 
            this.textBox_QTY.Location = new System.Drawing.Point(142, 111);
            this.textBox_QTY.Name = "textBox_QTY";
            this.textBox_QTY.Size = new System.Drawing.Size(100, 20);
            this.textBox_QTY.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "QTY";
            // 
            // comboBoxStock
            // 
            this.comboBoxStock.FormattingEnabled = true;
            this.comboBoxStock.Location = new System.Drawing.Point(26, 111);
            this.comboBoxStock.Name = "comboBoxStock";
            this.comboBoxStock.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStock.TabIndex = 51;
            this.comboBoxStock.SelectedIndexChanged += new System.EventHandler(this.comboBoxStock_SelectedIndexChanged);
            // 
            // textBoxValueNET
            // 
            this.textBoxValueNET.Location = new System.Drawing.Point(263, 111);
            this.textBoxValueNET.Name = "textBoxValueNET";
            this.textBoxValueNET.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueNET.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Value NET";
            // 
            // textBox_NumberInvoice
            // 
            this.textBox_NumberInvoice.Location = new System.Drawing.Point(26, 21);
            this.textBox_NumberInvoice.Name = "textBox_NumberInvoice";
            this.textBox_NumberInvoice.ReadOnly = true;
            this.textBox_NumberInvoice.Size = new System.Drawing.Size(86, 20);
            this.textBox_NumberInvoice.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Number Invoice";
            // 
            // WM_AddElementsToInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_NumberInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValueNET);
            this.Controls.Add(this.comboBoxStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_QTY);
            this.Controls.Add(this.button_AddNewContractorConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "WM_AddElementsToInvoice";
            this.Text = "WM_AddElementsToInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddNewContractorConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_QTY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStock;
        private System.Windows.Forms.TextBox textBoxValueNET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NumberInvoice;
        private System.Windows.Forms.Label label4;
    }
}