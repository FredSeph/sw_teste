using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Model.Base
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
