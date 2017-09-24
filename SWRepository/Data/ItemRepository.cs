using SWDomain.Entities;
using SWDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRepository.Data
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        #region Properties and Constructors

        public ItemRepository(SWEntities context)
            : base(context)
        {
        }

        #endregion
    }
}
