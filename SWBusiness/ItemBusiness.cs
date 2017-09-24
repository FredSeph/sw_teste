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
    }
}
