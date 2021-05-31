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
