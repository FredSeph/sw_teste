using SWDomain.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWDomain.DataTransferObjects;
using SWDomain.Enum;

namespace SWBusiness
{
    public class CheckoutBusiness : ICheckoutBusiness
    {
        #region Properties and Constructors

        private readonly IPromotionBusiness _promotionBusiness;

        public CheckoutBusiness(IPromotionBusiness promotionBusiness)
        {
            _promotionBusiness = promotionBusiness;
        }

        #endregion

        public decimal CalculateTotal(IEnumerable<DTOCartItem> cartItems)
        {
            var total = 0m;

            foreach (var cartItem in cartItems)
            {
                var hasPromotion = cartItem.Item.Promotion != null || cartItem.Item.Promotion != (short)Promotion.None;

                total += hasPromotion
                    ? _promotionBusiness.ApplyPromotion(cartItem)
                    : cartItem.Item.Price * cartItem.Count;
            }

            return total;
        }
    }
}
