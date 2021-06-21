using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class InvoiceElements
    {
        public string InvoiceElementID { get; set; }
        public string IvoiceID { get; set; }
        public string InvoiceValueNet { get; set; }
        public string InvoiceElementTax { get; set; }
        public string InvoiceValueGross { get; set; }
        public string StockId { get; set; }



        public static InvoiceElements ReadInvoiceElements(SqlDataReader reader)
        {
            var ReadInvoiceElements = new InvoiceElements()
            {
                InvoiceElementID = Convert.ToString(reader.GetValue(0)),
                IvoiceID = Convert.ToString(reader.GetValue(1)),
                InvoiceValueNet = Convert.ToString(reader.GetValue(2)),
                InvoiceElementTax = Convert.ToString(reader.GetValue(3)),
                InvoiceValueGross = Convert.ToString(reader.GetValue(4)),
                StockId = Convert.ToString(reader.GetValue(5)),

            };
            return ReadInvoiceElements;
        }





    }
}




