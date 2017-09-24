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
        public string GetPromotionName(Promotion promotion)
        {
            switch (promotion)
            {
                case Promotion.BuyOneGetOneFree:
                    return "Pague 1 e Leve 2";
                case Promotion.ThreeFor10:
                    return "3 por R$ 10,00";
                default:
                    return "";
            }
        }

        public Dictionary<short, string> GetPromotionSelectList()
        {
            var promotions = new Dictionary<short, string>();

            promotions.Add((short)Promotion.None, GetPromotionName(Promotion.None));
            promotions.Add((short)Promotion.BuyOneGetOneFree, GetPromotionName(Promotion.BuyOneGetOneFree));
            promotions.Add((short)Promotion.ThreeFor10, GetPromotionName(Promotion.ThreeFor10));

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
