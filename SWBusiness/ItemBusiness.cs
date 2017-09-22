using SWDomain.Entities;
using SWDomain.Interfaces.Business;
using SWDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWBusiness
{
    public class ItemBusiness : BusinessBase<Item>, IItemBusiness
    {
        #region Properties and Constructors

        private readonly IItemRepository _itemRepository;

        public ItemBusiness(IItemRepository itemRepository)
            : base(itemRepository)
        {
            _itemRepository = itemRepository;
        }

        #endregion

        // Add temporário até o fluxo do BusinessBase > RepositoryBase funcionar
        public new int Add(Item item)
        {
            return _itemRepository.Add(item);
        }

        // GetAll temporário até o fluxo do BusinessBase > RepositoryBase funcionar
        public new IEnumerable<Item> GetAll(bool orderByName = false)
        {
            return _itemRepository.GetAll(orderByName);
        }

        // Update temporário até o fluxo do BusinessBase > RepositoryBase funcionar
        public new void Update(Item item)
        {
            _itemRepository.Update(item);
        }

        // Remove temporário até o fluxo do BusinessBase > RepositoryBase funcionar
        public new void Remove(Item item)
        {
            _itemRepository.Remove(item);
        }

        // RemoveById temporário até o fluxo do BusinessBase > RepositoryBase funcionar
        public new void RemoveById(object parameters)
        {
            _itemRepository.RemoveById(parameters);
        }
    }
}
