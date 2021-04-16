using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Stock
    {

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
   

    public static Stock ReadStock(SqlDataReader reader)
    {
        var StockRead = new Stock()
        {
            ProductID = Convert.ToString(reader.GetValue(0)),
            ProductName = Convert.ToString(reader.GetValue(1)),
            ProductPrice = Convert.ToString(reader.GetValue(2)),

        };
        return StockRead;
    }
    
}
}
