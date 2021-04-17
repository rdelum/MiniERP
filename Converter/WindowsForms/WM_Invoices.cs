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
    public partial class WM_Invoices : Form
    {
        public WM_Invoices()
        {
            InitializeComponent();
        }

        private void button_OpenCardInvoice_Click(object sender, EventArgs e)
        {
            WM_CardNewInvoices wM_CardNewInvoices = new WM_CardNewInvoices();
            wM_CardNewInvoices.Show();

        }
    }
}
