using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStores.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int OrderStatus { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }
    }
}
