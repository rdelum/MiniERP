namespace Converter
{
    partial class WM_StockCard
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
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_AddNewContractorConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Name";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(184, 48);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox_Price.TabIndex = 37;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(47, 48);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 36;
            // 
            // button_AddNewContractorConfirm
            // 
            this.button_AddNewContractorConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_AddNewContractorConfirm.Location = new System.Drawing.Point(353, 97);
            this.button_AddNewContractorConfirm.Name = "button_AddNewContractorConfirm";
            this.button_AddNewContractorConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewContractorConfirm.TabIndex = 42;
            this.button_AddNewContractorConfirm.Text = "Add to stock";
            this.button_AddNewContractorConfirm.UseVisualStyleBackColor = true;
            this.button_AddNewContractorConfirm.Click += new System.EventHandler(this.button_AddNewContractorConfirm_Click);
            // 
            // WM_StockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 177);
            this.Controls.Add(this.button_AddNewContractorConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Name);
            this.Name = "WM_StockCard";
            this.Text = "WM_StockCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_AddNewContractorConfirm;
    }
}