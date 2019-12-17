using Dapper;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using DapperStudy.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data
{
	public static class RegisterMappings
	{
		public static void Register()
		{
			FluentMapper.Initialize(config =>
			{
				config.AddMap(new OrderMap());
				config.AddMap(new ProductMap());
				config.AddMap(new OrderDetailMap());
				config.ForDommel();
			});
		}
	}
}
