using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commanding.Modules.Oder.Desktop.Services
{
    public class Order
    {
        public Order()
        {
            DeliveryDate = DateTime.Now;
        }

        public string Name { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Shipping { get; set; }

        //////////////////////////////////
    }
}
