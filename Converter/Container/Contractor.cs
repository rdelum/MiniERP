using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
  public class Contractor
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDBuyer { get; set; }
        public string Phone { get; set; }
    

    public static Contractor ReadContractor(SqlDataReader reader)
    {
        var ContructorRead = new Contractor()
        {
            Name = Convert.ToString(reader.GetValue(0)),
            Surname = Convert.ToString(reader.GetValue(1)),
            IDBuyer = Convert.ToString(reader.GetValue(2)),
            Phone = Convert.ToString(reader.GetValue(3)),
        };
        return ContructorRead;
    }
    }
}
