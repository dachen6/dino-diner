using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
	public class Order
	{
        public ObservableCollection<IOrderItem> item { get; set; } = new ObservableCollection<IOrderItem>();

        private  double subtotalCost;
        public double SubtotalCost { get

            {
               
                foreach (IOrderItem i in item)
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
         public double SalesTaxRate { get; protected set; }
         public double SalesTaxCost { get
            {
                return (SalesTaxRate* SubtotalCost);
            } }
        public double TotalCost { get {

                return SalesTaxCost + SubtotalCost;

            } }

       

        
	}
}
