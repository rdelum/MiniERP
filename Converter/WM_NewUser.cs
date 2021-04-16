using Converter.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class WM_NewUser : Form
    {
        public WM_NewUser()
        {
            InitializeComponent();

        }

        private void button_AddNewContractorConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                var connectionString = SqlHelper.getConnection();
                Methods.AddNewUser(connectionString, textBox_UserName.Text, textBox_Password.Text, Methods.CheckedBox(checkBoxAccessContractors), Methods.CheckedBox(checkBoxEditContractors), Methods.CheckedBox(checkBoxAcessInvoices));

                this.Hide();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }
        }
    }
}
