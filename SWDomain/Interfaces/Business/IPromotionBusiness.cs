using SWDomain.DataTransferObjects;
using SWDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Business
{
    public interface IPromotionBusiness
    {
        string GetPromotionName(Promotion promotion);
        Dictionary<short, string> GetPromotionSelectList();
        decimal ApplyPromotion(DTOCartItem cartItem);
    }
}
