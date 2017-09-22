using SWDomain.Entities;
using SWDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRepository.Data
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        // Add temporário até ter o do RepositoryBase funcionando
        public new int Add(Item item)
        {
            using (var db = new SWEntities())
            {
                db.Item.Add(item);
                db.SaveChanges();

                return item.Id;
            }
        }

        // GetAll temporário até ter o do RepositoryBase funcionando
        public new IEnumerable<Item> GetAll(bool orderByName = false)
        {
            using (var db = new SWEntities())
            {
                return orderByName
                    ? db.Item.OrderBy(i => i.Name).ToList()
                    : db.Item.ToList();
            }
        }

        // Update temporário até ter o do RepositoryBase funcionando
        public new void Update(Item item)
        {
            using (var db = new SWEntities())
            {
                var original = db.Item.Find(item.Id);
                original = item;
                db.SaveChanges();
            }
        }

        // Remove temporário até ter o do RepositoryBase funcionando
        public new void Remove(Item item)
        {
            using (var db = new SWEntities())
            {
                db.Item.Remove(item);
                db.SaveChanges();
            }
        }

        // RemoveById temporário até ter o do RepositoryBase funcionando
        public new void RemoveById(object parameters)
        {
            
        }
    }
}
