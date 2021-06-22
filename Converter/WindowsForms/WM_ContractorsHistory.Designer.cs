
namespace Converter
{
    partial class WM_ContractorsHistory
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
            this.dataGridView_ContractorHistory = new System.Windows.Forms.DataGridView();
            this.textBox_ContractorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContractorHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ContractorHistory
            // 
            this.dataGridView_ContractorHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ContractorHistory.Location = new System.Drawing.Point(18, 88);
            this.dataGridView_ContractorHistory.Name = "dataGridView_ContractorHistory";
            this.dataGridView_ContractorHistory.Size = new System.Drawing.Size(765, 275);
            this.dataGridView_ContractorHistory.TabIndex = 18;
            // 
            // textBox_ContractorID
            // 
            this.textBox_ContractorID.Location = new System.Drawing.Point(18, 42);
            this.textBox_ContractorID.Name = "textBox_ContractorID";
            this.textBox_ContractorID.ReadOnly = true;
            this.textBox_ContractorID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ContractorID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Contractor ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(246, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Contractor\'s order history";
            // 
            // WM_ContractorsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ContractorID);
            this.Controls.Add(this.dataGridView_ContractorHistory);
            this.Name = "WM_ContractorsHistory";
            this.Text = "WM_ContractorsHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContractorHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ContractorHistory;
        private System.Windows.Forms.TextBox textBox_ContractorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}