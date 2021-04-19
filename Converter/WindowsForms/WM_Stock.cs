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
    public partial class WM_Stock : Form
    {
        public WM_Stock()
        {
            InitializeComponent();
            var allStock = Methods.GetStock(SqlHelper.getConnection());
            RefreshStock(allStock);
        }


        public void RefreshStock(List<Stock> allStock)
        {
            dataGridViewStock.AutoGenerateColumns = true;
            dataGridViewStock.DataSource = allStock;
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
     
            using (WM_StockCard WM_StockCard = new WM_StockCard())
            {
                if (WM_StockCard.ShowDialog() == DialogResult.OK)
                {
                WM_StockCard.Show(this);
                }
                else
                {
                    var allStock = Methods.GetStock(SqlHelper.getConnection());
                    RefreshStock(allStock);
                }
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var allStock = Methods.GetStock(SqlHelper.getConnection());
            RefreshStock(allStock);
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            Methods.EditProduct(connectionString,textBox_ProductID.Text ,textBox_Name.Text, Convert.ToDecimal(Methods.DotToComma(textBox_Price.Text)));
            var allStock = Methods.GetStock(SqlHelper.getConnection());
            RefreshStock(allStock);
        }

  

        private void dataGridViewStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ProductID.Text = dataGridViewStock.Rows[e.RowIndex].Cells["ProductID"].FormattedValue.ToString();
            textBox_Name.Text = dataGridViewStock.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
            textBox_Price.Text = dataGridViewStock.Rows[e.RowIndex].Cells["ProductPrice"].FormattedValue.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = SqlHelper.getConnection();
                Methods.RemoveProduct(connectionString, textBox_ProductID.Text);
                string DeletedProduct = (textBox_Name.Text).TrimEnd();
                MessageBox.Show($"Product: {DeletedProduct} has been deleted");
                var allStock = Methods.GetStock(SqlHelper.getConnection());
                RefreshStock(allStock);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }

        }
    }


}
