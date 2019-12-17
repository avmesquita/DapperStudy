using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Entity
{
	public class OrderDetail : DTO
	{
		public int OrderId { get; set; }
		public Order Order { get; set; }
		
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int Quantity { get; set; }

		// declarar as colunas de chave estrangeira da tabela
		
	}
}
