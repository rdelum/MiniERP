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
    public partial class WM_AddElementsToInvoice : Form
    {
        public WM_AddElementsToInvoice()
        {
            var connectionString = SqlHelper.getConnection();
           
            InitializeComponent();
            Methods.FillComboStock(comboBoxStock);

            string numberInvoice = Methods.NumberLastInvoice(connectionString);

            var result = numberInvoice.Split('/').Skip(3).ToList();

            foreach (var item in result)
            {
                textBox_NumberInvoice.Text = (Convert.ToInt32(item) + 1).ToString();
            }


        }

        public string productIDFromName { get; set; }

        private void comboBoxStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            string productID = comboBoxStock.Text;
            productIDFromName = (Methods.ProduktId(connectionString, productID)).ToString();

        }

        private void button_AddNewContractorConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = SqlHelper.getConnection();

                string IvoiceID = textBox_NumberInvoice.Text;
                string ElementsNet = textBoxValueNET.Text;
                string ValueTax = (Convert.ToInt32(textBoxValueNET.Text) * 0.23).ToString();
                string Gross = ((Convert.ToInt32(textBoxValueNET.Text) * 1.23) * Convert.ToInt32(textBox_QTY.Text)).ToString();
                string ProductIDfromName = productIDFromName;
                string QTY = textBox_QTY.Text;
                MethodsProducts.AddElementToInvoice(connectionString, IvoiceID, Convert.ToDecimal(ElementsNet), Convert.ToDecimal(ValueTax), Convert.ToDecimal(Gross), ProductIDfromName, QTY);
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }
        }

       
    }
}
