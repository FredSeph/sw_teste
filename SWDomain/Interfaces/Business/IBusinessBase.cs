using SWDomain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Business
{
    public interface IBusinessBase<T> where T : IEntity
    {
    }
}
