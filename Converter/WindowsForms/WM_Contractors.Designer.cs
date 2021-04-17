namespace Converter
{
    partial class WM_Contractors
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
            this.dataGridView_Contractors = new System.Windows.Forms.DataGridView();
            this.button_loadFile = new System.Windows.Forms.Button();
            this.textBox_ImportFilePath = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_IDBuyer = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_AddNewContractor = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contractors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Contractors
            // 
            this.dataGridView_Contractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Contractors.Location = new System.Drawing.Point(23, 109);
            this.dataGridView_Contractors.Name = "dataGridView_Contractors";
            this.dataGridView_Contractors.Size = new System.Drawing.Size(765, 275);
            this.dataGridView_Contractors.TabIndex = 17;
            this.dataGridView_Contractors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Contractors_CellClick);
            // 
            // button_loadFile
            // 
            this.button_loadFile.Location = new System.Drawing.Point(139, 405);
            this.button_loadFile.Name = "button_loadFile";
            this.button_loadFile.Size = new System.Drawing.Size(121, 23);
            this.button_loadFile.TabIndex = 18;
            this.button_loadFile.Text = "Import Contractors";
            this.button_loadFile.UseVisualStyleBackColor = true;
            this.button_loadFile.Click += new System.EventHandler(this.button_loadFile_Click);
            // 
            // textBox_ImportFilePath
            // 
            this.textBox_ImportFilePath.Location = new System.Drawing.Point(33, 407);
            this.textBox_ImportFilePath.Name = "textBox_ImportFilePath";
            this.textBox_ImportFilePath.Size = new System.Drawing.Size(100, 20);
            this.textBox_ImportFilePath.TabIndex = 19;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(23, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 20;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(160, 77);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 21;
            // 
            // textBox_IDBuyer
            // 
            this.textBox_IDBuyer.Location = new System.Drawing.Point(294, 77);
            this.textBox_IDBuyer.Name = "textBox_IDBuyer";
            this.textBox_IDBuyer.Size = new System.Drawing.Size(100, 20);
            this.textBox_IDBuyer.TabIndex = 22;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(416, 77);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "IDBuyer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phone";
            // 
            // button_AddNewContractor
            // 
            this.button_AddNewContractor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_AddNewContractor.Location = new System.Drawing.Point(713, 405);
            this.button_AddNewContractor.Name = "button_AddNewContractor";
            this.button_AddNewContractor.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewContractor.TabIndex = 28;
            this.button_AddNewContractor.Text = "Add new";
            this.button_AddNewContractor.UseVisualStyleBackColor = true;
            this.button_AddNewContractor.Click += new System.EventHandler(this.button_AddNewContractor_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Edit.Location = new System.Drawing.Point(632, 405);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 29;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.button_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Delete.Location = new System.Drawing.Point(564, 405);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(53, 23);
            this.button_Delete.TabIndex = 30;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Code Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "CONTRACTORS";
            // 
            // WM_Contractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_AddNewContractor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_IDBuyer);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_ImportFilePath);
            this.Controls.Add(this.button_loadFile);
            this.Controls.Add(this.dataGridView_Contractors);
            this.Name = "WM_Contractors";
            this.Text = "WM_Contractors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contractors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Contractors;
        private System.Windows.Forms.Button button_loadFile;
        private System.Windows.Forms.TextBox textBox_ImportFilePath;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_IDBuyer;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_AddNewContractor;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label5;
    }
}