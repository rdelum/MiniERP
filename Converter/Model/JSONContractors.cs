using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Model
{
  public class JSONContractors
    {
           public List<Contractor> contractors { get; set; }
       

    }
    public class Contractor
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string id { get; set; }
            public string phone { get; set; }
        }


 

}
