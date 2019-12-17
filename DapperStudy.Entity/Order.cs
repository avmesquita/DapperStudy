using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Entity
{
	public class Order : DTO
	{
		public DateTime Date { get; set; }
		public IList<OrderDetail> Details { get; set; }
		public virtual Decimal Total
		{
			get
			{
				if (Details != null && Details.Count() > 0)
				{
					decimal x = decimal.Zero;
					foreach (var item in this.Details)
					{
						x += item.Quantity * item.Product.Price;
					}
					return x;
				}
				else
					return decimal.Zero;
			}
		}
		public Order()
		{
			Details = new List<OrderDetail>();
		}

	}
}
