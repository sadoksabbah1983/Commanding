using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commanding.Modules.Oder.Desktop.Services
{
    class OrdersReposity:IOrdersReposity
    {
        private const int InitialOrdersCount = 3;

        public IEnumerable<Order> GetOrdersToEdit()
        {
            var orders = new List<Order>(InitialOrdersCount);
            for (int i = 1; i <= InitialOrdersCount; i++)
            {
                string orderName = String.Format(CultureInfo.CurrentCulture, "Order {0}", i);
                orders.Add(new Order {Name= orderName,DeliveryDate=DateTime.Today.AddDays(i)});
            }
            return orders;
        }

    }
}
