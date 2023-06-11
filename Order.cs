using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATS2GOV2
{
    public class Order
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfTransaction { get; set; }
    }
}
