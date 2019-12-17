using DapperStudy.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data
{
	public interface IDAO<TEntity> where TEntity : DTO
	{
		IEnumerable<TEntity> GetAll();
		TEntity GetById(int id);
		void Insert(ref TEntity entity);
		bool Update(TEntity entity);
		bool Delete(Int32 id);
		IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
	}

}
