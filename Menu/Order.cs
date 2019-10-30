using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace DinoDiner.Menu
{
	public class Order : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private List<IOrderItem> items { get; set; }

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        public double SubtotalCost { get

            {
                double subtotalCost = 0;
                foreach (IOrderItem i in Items)
                {
                    subtotalCost += i.Price;
                }
                if (subtotalCost < 0)
                {
                   subtotalCost = 0;
                }
                return subtotalCost;
            }
        }
         public double SalesTaxRate { get { return SalesTaxRate; } }
         public double SalesTaxCost { get
            {
                return (SalesTaxRate* SubtotalCost);
            } }
        public double TotalCost { get {

                return SalesTaxCost + SubtotalCost;

            } }
        public Order()
        {
            items = new List<IOrderItem>();
        }


        public void Add(IOrderItem item)
        {

            item.PropertyChanged += OnCollectionChange;
            items.Add(item);
            OnCollectionChange(this,new EventArgs());
        }


        public bool Remove(IOrderItem item)
        {
            bool flag = items.Remove(item);
            OnCollectionChange(this, new EventArgs());
            return flag;
        }

        private void OnCollectionChange(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }
       

        
	}
}
