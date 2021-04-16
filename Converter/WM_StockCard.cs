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
    public partial class WM_StockCard : Form
    {
        public WM_StockCard()
        {
            InitializeComponent();
        }

        private void button_AddNewContractorConfirm_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
   

            Methods.AddNewProduct(connectionString, textBox_Name.Text, Convert.ToDecimal(Methods.DotToComma(textBox_Price.Text)));

            MessageBox.Show($"Product named {textBox_Name.Text} has been added to the product list");
            this.Close();
            
        }


    
    }
}
