using SWDomain.Interfaces.Repository;
using SWDomain.Entities;
using SWDomain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRepository.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        #region Properties and Constructors

        protected SWEntities Db;
        protected DbSet<T> DbSet;

        protected RepositoryBase(SWEntities context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        #endregion

        public int Add(T obj)
        {
            DbSet.Add(obj);
            return Db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T GetById(object id)
        {
            return DbSet.Find(id);
        }

        public void Update(T obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(T obj)
        {
            DbSet.Remove(obj);
            Db.SaveChanges();
        }

        public void RemoveById(object parameters)
        {
            DbSet.Remove(DbSet.Find(parameters));
            Db.SaveChanges();
        }
    }
}
