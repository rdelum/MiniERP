using Converter.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class MethodsProducts
    {
        public static List<Stock> GetStock(string connectionString)
        {
            string SelectAllProduct = @"Select ProductID, ProductName, ProductPrice from dbo.Stock";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(SelectAllProduct, conn))
                {
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return SqlHelper.ReadAll(reader, Stock.ReadStock);
                        }
                        else
                            return new List<Stock>();
                    }

                }
            }
        }

        public static int EditProduct(string connectionString, string parametr3, string parametr1, decimal parametr2)
        {
            var queryString = @"update dbo.Stock set ProductName =@ProductName, ProductPrice = @ProductPrice where ProductID = @ProductID";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@ProductName", parametr1);
                    comm.Parameters.AddWithValue("@ProductPrice", parametr2);
                    comm.Parameters.AddWithValue("@ProductID", parametr3);
                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }
        //public static int AddElementToInvoice(string connectionString, string parametr1, string parametr2, string parametr3, string parametr4, string parametr5, string parametr6)
        public static int AddElementToInvoice(string connectionString, string parametr1, decimal parametr2, decimal parametr3, decimal parametr4, string parametr5, string parametr6)
        {
            var queryString = @"INSERT INTO dbo.InvoiceElements (InvoiceID, InvoiceValueNet, InvoiceElementTax, InvoiceValueGross, StockId, InvElemQTY) VALUES(@IvoiceID, @InvoiceValueNet, @InvoiceElementTax , @InvoiceValueGross, @StockId, @QTY)";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@IvoiceID", parametr1);
                    comm.Parameters.AddWithValue("@InvoiceValueNet", parametr2);
                    comm.Parameters.AddWithValue("@InvoiceElementTax", parametr3);
                    comm.Parameters.AddWithValue("@InvoiceValueGross", parametr4);
                    comm.Parameters.AddWithValue("@StockId", parametr5);
                    comm.Parameters.AddWithValue("@QTY", parametr6);

                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }




        public static int RemoveProduct(string connectionString, string parametr1)
        {
            var queryString = @"Delete from dbo.Stock  where ProductID = @ProductID";
            using (var conn = SqlHelper.OpenConnection(connectionString))
            {
                using (var comm = new SqlCommand(queryString, conn))
                {
                    comm.Parameters.AddWithValue("@ProductID", parametr1);

                    var result = comm.ExecuteNonQuery();

                    return result;
                }
            }
        }
    }
}
