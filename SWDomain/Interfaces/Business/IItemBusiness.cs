using SWDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Business
{
    public interface IItemBusiness : IBusinessBase<Item>
    {
        // Todos métodos abaixo temporário até o fluxo do BusinessBase > RepositoryBase funcionar

        new int Add(Item item);
        new IEnumerable<Item> GetAll(bool orderByName = false);
        new void Update(Item item);
        new void Remove(Item item);
        new void RemoveById(object parameters);
    }
}
