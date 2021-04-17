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
using Converter.SQL;
using LumenWorks.Framework.IO.Csv;

namespace Converter
{
    public partial class MainPanel : Form
    {


        public MainPanel()
        {
            InitializeComponent();
        }

        private void Button_SQLConfiguration_Click(object sender, EventArgs e)
        {
           



            ConfigureDataBase configureDataBase = new ConfigureDataBase();
            configureDataBase.Show();
        }

        private void buttonContractors_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select UserSeeContractors from dbo.Users where UserName ='" + Properties.Settings.Default.UserCombobox + "' and UserP ='" + Properties.Settings.Default.UserPass + "'", connectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                WM_Contractors wM_Contractors = new WM_Contractors();
                wM_Contractors.Show(this);

                var allContractors = Methods.GetContractors(SqlHelper.getConnection());
                wM_Contractors.RefreshContractors(allContractors);

                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("You are not authorized to this module");
            }

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            WM_Login wM_Login = new WM_Login();
            wM_Login.Show();
            Close();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            WM_Stock wM_Stock = new WM_Stock();
            wM_Stock.Show();
        }

        private void buttonInvoices_Click(object sender, EventArgs e)
        {
            WM_Invoices wM_Invoices = new WM_Invoices();
            wM_Invoices.Show();
        }
    }
}
