using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Commanding.Modules.Oder.Desktop.Properties;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;

namespace Commanding.Modules.Oder.Desktop.ViewModels
{
    public class OrderViewModel:INotifyPropertyChanged,IDataErrorInfo
    {

        private readonly  IDictionary<string,string> errors = new Dictionary<string, string>();
        private readonly Services.Order _order;


        #region  Order Propriete    

        public string OrderName
        {
            get { return _order.Name; }
            set
            {
                _order.Name = value;
                NotifyPropertyChanged("OrderName");
            }
        }

        public DateTime DeliveryDate
        {
            get { return _order.DeliveryDate; }
            set
            {
                if (_order.DeliveryDate != value)
                {
                    _order.DeliveryDate = value;
                    this.NotifyPropertyChanged("DeliveryDate");
                }
            }
        }

        public int? Quantity
        {
            get { return _order.Quantity; }
            set
            {
                if (_order.Quantity != value)
                {
                    _order.Quantity = value;
                    this.NotifyPropertyChanged("Quantity");
                }
            }
        }

        public decimal? Price
        {
            get { return _order.Price; }
            set
            {
                if (_order.Price != value)
                {
                    _order.Price = value;
                    this.NotifyPropertyChanged("Price");
                }
            }
        }

        public decimal? Shipping
        {
            get { return _order.Shipping; }
            set
            {
                if (_order.Shipping != value)
                {
                    _order.Shipping = value;
                    this.NotifyPropertyChanged("Shipping");
                }
            }
        }

        public decimal Total
        {
            get
            {
                if (this.Price != null && this.Quantity != null)
                {
                    return (this.Price.Value * this.Quantity.Value) + (this.Shipping ?? 0);
                }
                return 0;
            }
        }

        #endregion


        #region OnPropertyChanged

        private void OnpropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            string propertyName = e.PropertyName;
            if((propertyName =="Price")|| (propertyName == "Quantity") || (propertyName == "Shipping")|| (propertyName == "Price"))
            {
                this.NotifyPropertyChanged("Total");
            }
            this.Validate();
            this.SaveOrderCommand.RaiseCanExecuteChanged();
        }

        #endregion

        #region SaveOder Command

        public event EventHandler<DataEventArgs<OrderViewModel>> Saved;
        public DelegateCommand<object> SaveOrderCommand { get; private set; }

        private bool CanSave(object arg)
        {
            return this.errors.Count == 0 && this.Quantity > 0;
        }

        private void Save(object obj)
        {
            Console.WriteLine(String.Format(CultureInfo.InvariantCulture,"{0} saved",this.OrderName));
            this.OnSaved(new DataEventArgs<OrderViewModel>(this));
        }

        private void OnSaved(DataEventArgs<OrderViewModel>e )
        {
            EventHandler<DataEventArgs<OrderViewModel>> saveHandler = this.Saved;
            if (saveHandler != null)
            {
                saveHandler(this, e);
            }
        }

        #endregion

        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
        

        #endregion






        public OrderViewModel(Services.Order order)
        {
            _order = order;

        }


        #region Validation

        private void Validate()
        {
            if (this.Price == null || this.Price <= 0)
            {
                this["Price"] = Resources.InvalidPriceRange;
            }
            else
            {
                this.ClearError("Price");
            }
            if (this.Quantity == null || this.Quantity <= 0)
            {
                this["Quantity"] = Resources.InvalidQuantityRange;
            }
            else
            {
                this.ClearError("Quantity");
            }

        }


        private void ClearError(string columnName)
        {
            if (this.errors.ContainsKey(columnName))
            {
                this.errors.Remove(columnName);
            }
        }

        #endregion

        #region IDataError Interface

        public string this[string columnName]
        {
            get
            {
                if (this.errors.ContainsKey(columnName))
                {
                    return this.errors[columnName];
                }
                return null;
            }
            set
            {
                this.errors[columnName] = value;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        #endregion















    }
}
