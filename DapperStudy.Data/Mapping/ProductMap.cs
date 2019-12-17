using Dapper.FluentMap.Dommel.Mapping;
using DapperStudy.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data.Mapping
{
	public class ProductMap : DommelEntityMap<Product>
	{
		public ProductMap()
		{
			ToTable("TB_PRODUCT");
			Map(x => x.Id).ToColumn("COD_PRODUCT").IsIdentity().IsKey();
			Map(x => x.Description).ToColumn("TXT_DESCRIPTION");
			Map(x => x.Price).ToColumn("VAL_PRICE");
		}
	}
}
