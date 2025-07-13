using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE5013_20281906.BusinessLogicLayer
{
     class OrderBLL
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int order_by { get; set; }
        public int supplier_id{ get; set; }
        public DateTime added_date { get; set; }
        public string status { get; set; }
        public decimal qty { get; set; }
        public decimal total { get; set; }
    }
}
