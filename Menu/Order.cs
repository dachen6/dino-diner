using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
	public class Order
	{
		ObservableCollection<IOrderItem> Item { get; set; }
		double SubtotalCost { get; }
		double SalesTaxRate { get; protected set; }
		double SalesTaxCost { get; }
		double TotalCost { get; }
	}
}
