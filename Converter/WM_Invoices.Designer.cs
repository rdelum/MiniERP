﻿namespace Converter
{
    partial class WM_Invoices
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
            this.button_OpenCardInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OpenCardInvoice
            // 
            this.button_OpenCardInvoice.Location = new System.Drawing.Point(661, 382);
            this.button_OpenCardInvoice.Name = "button_OpenCardInvoice";
            this.button_OpenCardInvoice.Size = new System.Drawing.Size(75, 23);
            this.button_OpenCardInvoice.TabIndex = 0;
            this.button_OpenCardInvoice.Text = "Add new Invoice";
            this.button_OpenCardInvoice.UseVisualStyleBackColor = true;
            this.button_OpenCardInvoice.Click += new System.EventHandler(this.button_OpenCardInvoice_Click);
            // 
            // WM_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_OpenCardInvoice);
            this.Name = "WM_Invoices";
            this.Text = "WM_Invoices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenCardInvoice;
    }
}