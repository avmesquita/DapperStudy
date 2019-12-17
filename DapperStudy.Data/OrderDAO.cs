using Dapper;
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
	public class OrderDAO : DAO<Order>
	{
		public OrderDAO()
		{

		}

		public IEnumerable<Order> GetFullOrder()
		{
			StringBuilder sql = new StringBuilder();
			sql.AppendLine("SELECT * ");
			sql.AppendLine("FROM TB_ORDER o");
			sql.AppendLine("       INNER JOIN TB_ORDER_DETAIL od");
			sql.AppendLine("         ON o.COD_ORDER = od.COD_ORDER");
			sql.AppendLine("       INNER JOIN TB_PRODUCT p");
			sql.AppendLine("         ON p.COD_PRODUCT = od.COD_PRODUCT");

			using (var db = new SqlConnection(ConnectionString))
			{
				var result = db.Query(sql.ToString());

				return result.Select(order => new Order
				{
					Id = order.ID,
					Date = order.DAT_ORDER,
				});
			}
		}

	}
}
