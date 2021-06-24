using Converter.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Converter
{
    public partial class WM_CardNewInvoices : Form
    {
        public string NumberCurrentInvoice { get; set; }

        public string DefDocument { get; set; }
        public string DocumentDate { get; set; }
        public string ValueGross { get; set; }
        public string ValueNet { get; set; }
        public string ContractorId { get; set; }
        public string UserID{ get; set; }
        public string FullNumberInvoice{ get; set; }

        

        

        public WM_CardNewInvoices()
        {

            InitializeComponent();

            var connectionString = SqlHelper.getConnection();
            Methods.FillComboContractors(comboBoxContractor);
            string numberInvoice = Methods.NumberLastInvoice(connectionString);
            var result = numberInvoice.Split('/').Skip(3).ToList();

            foreach (var item in result)
            {
                NumberCurrentInvoice = (Convert.ToInt32(item) + 1).ToString();
            }
            textBox_IssuedDocument.Text = Properties.Settings.Default.UserCombobox;
            
            textBoxInvoiceNumber.Text =  NumberCurrentInvoice;


        }
        private void button_Confirm_Click(object sender, EventArgs e)
        {


            try
            {
                if (!String.IsNullOrEmpty(ValueGross) || !String.IsNullOrEmpty(comboBoxContractor.Text) )
                {
                    

                    var connectionString = SqlHelper.getConnection();
                    textBox_ValueGross.Text = Methods.GetSumInvoiceElementGross(connectionString, NumberCurrentInvoice);
                    DateTime date = DateTime.Today;
                    var NewInvoiceMonth = date.Month.ToString();
                    var NewInvoiceYear = date.Year.ToString();
                    DocumentDate = dateTimePickerSaleDate.Value.ToString("yyyy-MM-dd");
                    UserID = (Methods.NumberIdUser(connectionString, Properties.Settings.Default.UserCombobox)).ToString();
                    //textBoxtest.Text = comboBoxContractor.Text;
                    FullNumberInvoice = Properties.Settings.Default.InvoiceDefinition + "/" + NewInvoiceMonth + "/" + NewInvoiceYear + "/" + NumberCurrentInvoice;
                    ValueNet = Methods.GetSumInvoiceElementNet(connectionString, NumberCurrentInvoice);
                    ValueGross = Methods.GetSumInvoiceElementGross(connectionString, NumberCurrentInvoice);
                    var allInvoiceElements = Methods.GetInvoiceElements(SqlHelper.getConnection(), NumberCurrentInvoice);
                    string email = Methods.ContractorMail(connectionString, ContractorId);
                    RefreshElements(allInvoiceElements);
                    Methods.AddNewInvoice(connectionString, NumberCurrentInvoice, (DocumentDate).ToString(), Convert.ToDecimal(ValueGross), Convert.ToDecimal(ValueNet), ContractorId, UserID, FullNumberInvoice);

                    MailMessage mm = new MailMessage("justtesttk@gmail.com", email);
                    mm.Subject = "New invoice from MiniERP";
                    mm.Body = $"You have new Invoice: \n\r {FullNumberInvoice} in the amount of {ValueGross} EUR";
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    System.Net.NetworkCredential nc = new NetworkCredential("justtesttk@gmail.com", Properties.Settings.Default.PassForMail);
                    smtp.EnableSsl = true;
                    smtp.Credentials = nc;
                    smtp.Send(mm);
                    MessageBox.Show(" An invoice has been added to database\n\r Confirmation of the placed order has been sent to the customer");
                    Close();
                }

                else
                {
                    MessageBox.Show("please complete the contractor field ");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }
            
           

        }



        private void button_OpenCardInvoice_Click(object sender, EventArgs e)
        {
            WM_CardNewInvoices wM_CardNewInvoices = new WM_CardNewInvoices();
            wM_CardNewInvoices.Show();

        }

        public void RefreshElements(List<InvoiceElements> allInvoices)
        {
            dataGridViewInvoiceProducts.AutoGenerateColumns = true;
            dataGridViewInvoiceProducts.DataSource = allInvoices;
            var connectionString = SqlHelper.getConnection();
            textBox_ValueGross.Text = Methods.GetSumInvoiceElementGross(connectionString, NumberCurrentInvoice);
        }

        

        private void button_AddElementsToInvoice_Click(object sender, EventArgs e)
        {


            using (WM_AddElementsToInvoice wM_AddElementsToInvoice = new WM_AddElementsToInvoice())
            {
                if (wM_AddElementsToInvoice.ShowDialog() == DialogResult.OK)
                {
                    wM_AddElementsToInvoice.Show(this);
                }
                else
                {
                    var allInvoiceElements = Methods.GetInvoiceElements(SqlHelper.getConnection(), NumberCurrentInvoice);

                    RefreshElements(allInvoiceElements);
                }
            }
        }

       

     

        private void comboBoxContractor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.getConnection();
            ContractorId = (Methods.ContractorID(connectionString, comboBoxContractor.Text)).ToString();
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {

           

        }
    }
}
