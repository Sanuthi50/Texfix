using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE5013_20281906.BusinessLogicLayer
{
   class ProductBLL
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public decimal available_qty { get; set; }
        public decimal quoted_price { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
