using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStores.Models
{
    public class OrderItems
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity{ get; set; }
        public int ListPrice{ get; set; }
        public decimal Discount{ get; set; }
    }
}
