using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Invoice
    {

        public string InvoiceNumber { get; set; }
        public string InvoiceContractorID { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceElementID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceValueNet { get; set; }
        public decimal InvoiceValueGross { get; set; }
        public string InvoiceUser { get; set; }


        public static Invoice ReadInvoice(SqlDataReader reader)
        {
            var InvoiceRead = new Invoice()
            {
                InvoiceNumber = Convert.ToString(reader.GetValue(0)),
                InvoiceContractorID = Convert.ToString(reader.GetValue(1)),
                InvoiceID = Convert.ToString(reader.GetValue(2)),
                InvoiceElementID = Convert.ToString(reader.GetValue(3)),
                InvoiceDate = Convert.ToDateTime(reader.GetValue(4)),
                InvoiceValueNet = Convert.ToDecimal(reader.GetValue(5)),
                InvoiceValueGross = Convert.ToDecimal(reader.GetValue(7)),
                InvoiceUser = Convert.ToString(reader.GetValue(7)),

                

        };
            return InvoiceRead;
        }
    }

}
