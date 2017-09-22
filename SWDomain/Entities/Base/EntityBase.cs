using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Entities.Base
{
    public class EntityBase : IEntity
    {
        private string _entityName;

        public EntityBase(string entityName)
        {
            _entityName = entityName;
        }

        // //////
        public string EntityName
        {
            get
            {
                return _entityName;
            }
        }
    }
}
