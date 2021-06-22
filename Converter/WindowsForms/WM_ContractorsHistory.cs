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
using Converter;

namespace Converter
{
    public partial class WM_ContractorsHistory : Form
    {
        public WM_ContractorsHistory()
        {
            InitializeComponent();
            var allInvoices = Methods.ContractorHistory(SqlHelper.getConnection(), Properties.Settings.Default.ContractorID);
            RefreshContractorHistory(allInvoices);
        }

        public void RefreshContractorHistory(List<Invoice> allContrators)
        {
            dataGridView_ContractorHistory.AutoGenerateColumns = true;
            dataGridView_ContractorHistory.DataSource = allContrators;
            textBox_ContractorID.Text = Properties.Settings.Default.ContractorID;
        }

        
        
    }
}
