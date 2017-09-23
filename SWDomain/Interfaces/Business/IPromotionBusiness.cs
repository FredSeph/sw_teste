using SWDomain.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Business
{
    public interface IPromotionBusiness
    {
        decimal ApplyPromotion(DTOCartItem cartItem);
    }
}
