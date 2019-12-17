using Dapper.FluentMap.Dommel.Mapping;
using DapperStudy.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data.Mapping
{
	public class OrderDetailMap : DommelEntityMap<OrderDetail>
	{
		public OrderDetailMap()
		{
			ToTable("TB_ORDER_DETAIL");
			Map(x => x.Id).ToColumn("COD_ORDER_DETAIL").IsIdentity().IsKey();
			Map(x => x.OrderId).ToColumn("COD_ORDER");
			Map(x => x.ProductId).ToColumn("COD_PRODUCT");
			Map(x => x.Quantity).ToColumn("QTD_PRODUCT");
			Map(x => x.Product).Ignore();
			Map(x => x.Order).Ignore();
		}
	}
}
