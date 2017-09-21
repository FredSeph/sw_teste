using SWDomain.Interfaces.Business;
using SWDomain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWBusiness
{
    public class BusinessBase<T> : IBusinessBase<T> where T : IEntity
    {
    }
}
