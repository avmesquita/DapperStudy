using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using DapperStudy.Data.Mapping;
using DapperStudy.Entity;
using Dommel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudy.Data
{
	public abstract class DAO<TEntity> : IDAO<TEntity> where TEntity : DTO
	{

		protected readonly string ConnectionString;

		protected DAO()
		{
			ConnectionString = "server=localhost;database=DapperStudy;user=sa;password=syncmaster";
		}

		public virtual IEnumerable<TEntity> GetAll()
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				return db.GetAll<TEntity>();
			}
		}

		public virtual TEntity GetById(int id)
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				return db.Get<TEntity>(id);
			}
		}

		public virtual void Insert(ref TEntity entity)
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				var id = db.Insert(entity);

				entity = GetById((int)id);
			}
		}

		public virtual bool Update(TEntity entity)
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				return db.Update(entity);
			}
		}

		public virtual bool Delete(Int32 id)
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				var entity = GetById(id);

				if (entity == null) throw new Exception("Registro não encontrado");

				return db.Delete(entity);
			}
		}

		public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
		{
			using (var db = new SqlConnection(ConnectionString))
			{
				return db.Select(predicate);
			}
		}
	}
}
