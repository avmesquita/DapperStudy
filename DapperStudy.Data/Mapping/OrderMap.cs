using Dapper.FluentMap.Dommel.Mapping;
using DapperStudy.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data.Mapping
{
	public class OrderMap : DommelEntityMap<Order>
	{
		public OrderMap()
		{
			ToTable("TB_ORDER");
			Map(x => x.Id).ToColumn("COD_ORDER").IsIdentity().IsKey();
			Map(x => x.Date).ToColumn("DAT_ORDER");
			Map(x => x.Details).Ignore();
			Map(x => x.Total).Ignore();
		}
	}
}
