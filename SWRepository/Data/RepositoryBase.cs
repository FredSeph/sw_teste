using SWDomain.Interfaces.Repository;
using SWDomain.Model;
using SWDomain.Model.Base;
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
        //protected SWModel Db;
        //protected DbSet<T> DbSet;

        //protected RepositoryBase(SWModel context)
        //{
        //    Db = context;
        //    DbSet = Db.Set<T>();
        //}

        public int Add(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByFields(object parameters)
        {
            throw new NotImplementedException();

            //using (var model = new SWModel())
            //{
            //    //var result = model./* preciso do T aqui */.Where(/* parameters em lambda expression */).ToList();
            //    return result;
            //}
        }

        public IEnumerable<T> GetAll(object parameters)
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

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
