namespace Converter
{
    partial class MainPanel
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Button_SQLConfiguration = new System.Windows.Forms.Button();
            this.buttonContractors = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.buttonInvoices = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Button_SQLConfiguration
            // 
            this.Button_SQLConfiguration.Location = new System.Drawing.Point(679, 196);
            this.Button_SQLConfiguration.Name = "Button_SQLConfiguration";
            this.Button_SQLConfiguration.Size = new System.Drawing.Size(109, 32);
            this.Button_SQLConfiguration.TabIndex = 13;
            this.Button_SQLConfiguration.Text = "Configure SQL";
            this.Button_SQLConfiguration.UseVisualStyleBackColor = true;
            this.Button_SQLConfiguration.Click += new System.EventHandler(this.Button_SQLConfiguration_Click);
            // 
            // buttonContractors
            // 
            this.buttonContractors.Location = new System.Drawing.Point(12, 12);
            this.buttonContractors.Name = "buttonContractors";
            this.buttonContractors.Size = new System.Drawing.Size(109, 44);
            this.buttonContractors.TabIndex = 17;
            this.buttonContractors.Text = "Contractors";
            this.buttonContractors.UseVisualStyleBackColor = true;
            this.buttonContractors.Click += new System.EventHandler(this.buttonContractors_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(12, 201);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 18;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // buttonInvoices
            // 
            this.buttonInvoices.Location = new System.Drawing.Point(127, 12);
            this.buttonInvoices.Name = "buttonInvoices";
            this.buttonInvoices.Size = new System.Drawing.Size(109, 44);
            this.buttonInvoices.TabIndex = 19;
            this.buttonInvoices.Text = "Invoices";
            this.buttonInvoices.UseVisualStyleBackColor = true;
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(242, 12);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(109, 44);
            this.buttonStock.TabIndex = 20;
            this.buttonStock.Text = "Stock";
            this.buttonStock.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 236);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonInvoices);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.buttonContractors);
            this.Controls.Add(this.Button_SQLConfiguration);
            this.Name = "MainPanel";
            this.Text = "Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Button_SQLConfiguration;
        private System.Windows.Forms.Button buttonContractors;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button buttonInvoices;
        private System.Windows.Forms.Button buttonStock;
    }
}

