using DapperStudy.Entity;
using Dommel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data
{
	public class OrderDetailDAO : DAO<OrderDetail>
	{
		/*
		public override IEnumerable<OrderDetail> GetAll()
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				return db.GetAll<OrderDetail, Product, OrderDetail>((orderdetail, product) =>
				{
					orderdetail.Product = product;
					return orderdetail;
				});
			}
		}
		*/
	}
}
