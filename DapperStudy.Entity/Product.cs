using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Entity
{
	public class Product : DTO
	{
		public string Description { get; set; }
		public decimal Price { get; set; }
	}
}
