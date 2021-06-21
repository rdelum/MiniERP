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
    public partial class WM_NewContractors : Form
    {
        public WM_NewContractors()
        {
            InitializeComponent();
        }

        private void WM_NewContractors_Load(object sender, EventArgs e)
        {

        }

        private void button_AddNewContractorConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = SqlHelper.getConnection();
                MethodsContractors.AddNewContractor(connectionString, textBox_Name.Text, textBox_Surname.Text, textBox_IDBuyer.Text, textBox_Phone.Text);
                MessageBox.Show($"The contractor {textBox_Name.Text} {textBox_Surname.Text} has been added");
    
                this.Hide();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }

           
        }
    }
}
