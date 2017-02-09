using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Data;
using System.Windows.Input;
using Commanding.Modules.Oder.Desktop.Services;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;

namespace Commanding.Modules.Oder.Desktop.ViewModels
{
    public class OrdersEditorViewModel :INotifyPropertyChanged
    {
        private readonly IOrdersReposity ordersReposity;
        private readonly OdersCommandProxy CommandProxy;
        private ObservableCollection<OrderViewModel> _orders { get; set; }

        public ICollectionView Orders { get; private set; }
        public OrderViewModel SelectedOrder { get; private set; }

        public ICommand ProcessOrderCommand { get; private set; }


        public OrdersEditorViewModel(IOrdersReposity ordersReposity, OdersCommandProxy commandProxy)
        {
            this.ordersReposity = ordersReposity;
            this.CommandProxy = commandProxy;
            
            //create dummy order data
            this.PopulateOrders();

            this.Orders = new ListCollectionView(_orders);
            this.Orders.CurrentChanged += SelectedOrderChaged;
            this.Orders.MoveCurrentTo(null);
            this.ProcessOrderCommand = new DelegateCommand<object>(ProcessOrder);

        }

   

        private void ProcessOrder(object parameter)
        {
            Debug.WriteLine(String.Format("PRocessing oder {0} with parameter{1}.", SelectedOrder.OrderName,parameter));
        }

        private void SelectedOrderChaged(object sender ,EventArgs e)
        {
            SelectedOrder = Orders.CurrentItem as OrderViewModel;
            NotifyPropertyChanged("SelectedOrder");
        }



   


        private void PopulateOrders()
        {
            _orders = new ObservableCollection<OrderViewModel>();

            foreach (Services.Order order  in this.ordersReposity.GetOrdersToEdit())
            {
                var orderPresentationModel = new OrderViewModel(order);
                _orders.Add(orderPresentationModel);
                orderPresentationModel.Saved += this.OrderSaved;
                CommandProxy.SaveAllOrdersCommand.RegisterCommand(orderPresentationModel.SaveOrderCommand);
            }
        }



        private void OrderSaved(object sender, DataEventArgs<OrderViewModel> e)
        {
            if (e != null && e.Value != null)
            {
                OrderViewModel order = e.Value;
                if (this.Orders.Contains(order))
                {
                    order.Saved -= this.OrderSaved;
                    this.CommandProxy.SaveAllOrdersCommand.UnregisterCommand(order.SaveOrderCommand);
                    this._orders.Remove(order);
                }
            }
        }




        #region INotifyPropertyChanged Menber 
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyNAme)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyNAme));
            }
        }


        #endregion



    }
}
