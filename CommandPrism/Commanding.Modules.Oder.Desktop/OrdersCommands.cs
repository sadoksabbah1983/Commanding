using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Commands;

namespace Commanding.Modules.Oder.Desktop
{
    public static class OrdersCommands
    {
        public static CompositeCommand SaveAllOrdersCommand = new CompositeCommand();
    }


    public class OdersCommandProxy
    {
        public virtual CompositeCommand SaveAllOrdersCommand
        {
            get { return OrdersCommands.SaveAllOrdersCommand; }
        }
    }
    
    
}
