using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.OMS.Orders.Model
{
    public class Order
    {
        public int Id { get; set; }
        public decimal OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
