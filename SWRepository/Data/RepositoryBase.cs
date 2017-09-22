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
    public class RepositoryBase<T> : IRepositoryBase<T> where T : IEntity
    {
        #region Properties and Constructors

        //protected SWEntities Db;
        //protected DbSet<T> DbSet;

        //protected RepositoryBase(SWEntities context)
        //{
        //    Db = context;
        //    DbSet = Db.Set<T>();
        //}

        #endregion

        public int Add(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(bool orderByName = false)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(T obj)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(object parameters)
        {
            throw new NotImplementedException();
        }
    }
}
