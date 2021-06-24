using Converter.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Converter
{
    public partial class WM_Login : Form
    {
        public WM_Login()
        {
            InitializeComponent();
            Methods.FillCombo(comboBoxUserName);
        }

        private void Button_SQLConfiguration_Click(object sender, EventArgs e)
        {
            WM_ConfigureSqlLogin wM_ConfigureSqlLogin = new WM_ConfigureSqlLogin();
            wM_ConfigureSqlLogin.Show();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from dbo.Users where UserName ='" + comboBoxUserName.Text + "' and UserP ='" + Methods.Hash_SHA1(textBox_password.Text) + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainPanel mainPanel = new MainPanel();
                mainPanel.Show();
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect ");
            }
        }

      
    }
}
