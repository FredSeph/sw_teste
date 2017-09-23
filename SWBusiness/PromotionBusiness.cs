using SWDomain.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWDomain.Enum;
using SWDomain.DataTransferObjects;

namespace SWBusiness
{
    public class PromotionBusiness : IPromotionBusiness
    {
        public Dictionary<Promotion, string> GetPromotionSelectList()
        {
            var promotions = new Dictionary<Promotion, string>();

            promotions.Add(Promotion.None, "");
            promotions.Add(Promotion.BuyOneGetOneFree, "Pague 1 e Leve 2");
            promotions.Add(Promotion.ThreeFor10, "3 por R$ 10,00");

            return promotions;
        }

        public decimal ApplyPromotion(DTOCartItem cartItem)
        {
            switch((Promotion)cartItem.Item.Promotion)
            {
                case Promotion.BuyOneGetOneFree:
                    return ApplyPromotionBuyOneGetOneFree(cartItem.Item.Price, cartItem.Count);
                case Promotion.ThreeFor10:
                    return ApplyPromotionThreeFor10(cartItem.Item.Price, cartItem.Count);
                default:
                    return cartItem.Item.Price;
            }
        }

        #region Private Methods

        private decimal ApplyPromotionBuyOneGetOneFree(decimal price, int count)
        {
            return count % 2 == 0
                ? (price * count) / 2
                : ((price * count) / 2) + price;
        }

        private decimal ApplyPromotionThreeFor10(decimal price, int count)
        {
            return ((count / 3) * 10) + ((count % 3) * price); 
        }

        #endregion
    }
}
