using Converter.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class WM_Contractors : Form
    {
        public WM_Contractors()
        {
            InitializeComponent();
            var allContractors = Methods.GetContractors(SqlHelper.getConnection());
            RefreshContractors(allContractors);
        }
        private void button_loadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\t\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml|JSON files (*.json)|*.json";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var fileContent = reader.ReadToEnd();
                        textBox_ImportFilePath.Text = openFileDialog.FileName;
                    }
                }
            }

            if (textBox_ImportFilePath.Text.Contains("csv"))
            {
                Methods.AddKontrahentFromCSV(textBox_ImportFilePath.Text);
            }

            else if (textBox_ImportFilePath.Text.Contains("xml"))
            {
                Methods.AddKontrahentFromXML(textBox_ImportFilePath.Text);
            }
            else if (textBox_ImportFilePath.Text.Contains("json"))
            {
                Methods.AddKontrahentFromJSON(textBox_ImportFilePath.Text);
            }
            else
            {
                MessageBox.Show("You did not select the file to import");
            }
            var allContractors = Methods.GetContractors(SqlHelper.getConnection());
            RefreshContractors(allContractors);
        }


        public void RefreshContractors(List<Contractor> allContrators)
        {
            dataGridView_Contractors.AutoGenerateColumns = true;
            dataGridView_Contractors.DataSource = allContrators;
        }

        public void Refresh_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            var allContractors = Methods.GetContractors(SqlHelper.getConnection());
            RefreshContractors(allContractors);
        }

        public void dataGridView_Contractors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView_Contractors.CurrentCell.Selected = true;
            textBox_Name.Text = dataGridView_Contractors.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            textBox_Surname.Text = dataGridView_Contractors.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
            textBox_IDBuyer.Text = dataGridView_Contractors.Rows[e.RowIndex].Cells["IDBuyer"].FormattedValue.ToString();
            textBox_Phone.Text = dataGridView_Contractors.Rows[e.RowIndex].Cells["Phone"].FormattedValue.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            try
            {
                var result = Methods.RemoveContractor(SqlHelper.getConnection(), textBox_IDBuyer.Text);
                var allContractors = Methods.GetContractors(SqlHelper.getConnection());
                RefreshContractors(allContractors);
                MessageBox.Show($"Contractor {textBox_Name.Text} {textBox_Surname.Text} has been deleted");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }


        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();

            SqlDataAdapter sda = new SqlDataAdapter("Select UserEditContractor from dbo.Users where UserName ='" + Properties.Settings.Default.UserLogin + "' and UserP ='" + Properties.Settings.Default.UserPass + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Methods.EditContractor(connectionString, textBox_Name.Text, textBox_Surname.Text, textBox_IDBuyer.Text, textBox_Phone.Text);
                MessageBox.Show($"Contractor {textBox_Name.Text} {textBox_Surname.Text} {textBox_Phone.Text} has been updated");
                var allContractors = Methods.GetContractors(SqlHelper.getConnection());
                RefreshContractors(allContractors);
            }
            else
            {
                MessageBox.Show("You are not authorized to this module");
            }


        }

        private void button_AddNewContractor_Click(object sender, EventArgs e)
        {


            try
            {

                using (WM_NewContractors wM_NewContractors = new WM_NewContractors())
                {
                    wM_NewContractors.Show();

                    var allContractors = Methods.GetContractors(SqlHelper.getConnection());
                    RefreshContractors(allContractors);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }


        }



    }
}
