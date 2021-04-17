using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class ConfigureDataBase : Form
    {
        public ConfigureDataBase()
        {
            InitializeComponent();
            chDisable_Checked();
            Methods.FillComboDataBase(comboBoxDataBase);
        }


        public string getConnection()
        {
            return checkBox_NT.Checked
                 ? $"Data Source={textBox_Serwer.Text};Initial Catalog={comboBoxDataBase.Text};Integrated Security=SSPI"
                 : $"Data Source={textBox_Serwer.Text};Initial Catalog={comboBoxDataBase.Text};User ID={textBox_login.Text};Password={textBox_password.Text}";
        }

        private void chDisable_Checked()
        {
            if (checkBox_NT.Checked)
            {
                textBox_login.ReadOnly = true;
                textBox_password.ReadOnly = true;
            }
            else
            {
                textBox_login.ReadOnly = false;
                textBox_password.ReadOnly = false;
            }
        }

        private void checkBox_NT_CheckedChanged(object sender, EventArgs e)
        {
            chDisable_Checked();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var instance = comboBoxDataBase.Text;
            var connectionString = getConnection();

            var queryString = $"SELECT name FROM master.dbo.sysdatabases where name = '{comboBoxDataBase.Text}'";

            using (SqlConnection connection = new SqlConnection(
                connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MessageBox.Show("You are connected to a database named:  " + ($"{reader["Name"].ToString()}"));
                    }
                    command.Connection.Close();
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            WM_NewUser wM_NewUser = new WM_NewUser();
            wM_NewUser.Show();

        }
    }
}
