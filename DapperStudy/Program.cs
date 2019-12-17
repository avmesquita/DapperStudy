using DapperStudy.Business;
using DapperStudy.Data;
using DapperStudy.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy
{
	class Program
	{
		static void Main(string[] args)
		{
			//EntityTest();
			DapperTest();

			Console.ReadLine();
		}

		public static void DapperTest()
		{
			RegisterMappings.Register();

			var orders = new OrderDAO().GetAll();

			foreach (var order in orders)
			{
				order.Details = new OrderDetailDAO().GetAll().Where(x => x.OrderId == order.Id).ToList();
				foreach (var detail in order.Details)
				{
					detail.Product = new ProductDAO().GetById(detail.ProductId);
				}
				Console.WriteLine(order.Total.ToString());
			}

			var product4 = new Product() { Description = " Product 4", Price = 1.00M };
			new ProductDAO().Insert(ref product4);

			var product5 = new Product() { Description = " Product 5", Price = 1.10M };
			new ProductDAO().Insert(ref product5);

			var product6 = new Product() { Description = " Product 6", Price = 1.20M };
			new ProductDAO().Insert(ref product6);

		}

		/// <summary>
		/// TO TEST MODEL
		/// </summary>
		public static void EntityTest()
		{
			List<Product> products = new List<Product>
			{
				new Product() { Id = 1, Description = " Product 1", Price = 1.00M },
				new Product() { Id = 2, Description = " Product 2", Price = 1.10M },
				new Product() { Id = 3, Description = " Product 3", Price = 1.20M }
			};

			List<OrderDetail> orderDetails = new List<OrderDetail>();
			orderDetails.Add(new OrderDetail()
			{
				Id = 1,
				OrderId = 1,
				Product = products.Where(x => x.Id == 1).FirstOrDefault(),
				Quantity = 1
			});
			orderDetails.Add(new OrderDetail()
			{
				Id = 2,
				OrderId = 1,
				Product = products.Where(x => x.Id == 2).FirstOrDefault(),
				Quantity = 3
			});

			Order order = new Order();
			order.Id = 1;
			order.Details = orderDetails;
			order.Date = DateTime.Now;

			Console.WriteLine(order.Total.ToString());
		}
	}
}
