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
    public class ShoppingBusiness : IShoppingBusiness
    {
        #region Properties and Constructors

        private readonly IPromotionBusiness _promotionBusiness;

        public ShoppingBusiness(IPromotionBusiness promotionBusiness)
        {
            _promotionBusiness = promotionBusiness;
        }

        #endregion

        public int CountItems(IEnumerable<DTOCartItem> cartItems)
        {
            return cartItems.Count();
        }

        public decimal CalculateTotalPrice(IEnumerable<DTOCartItem> cartItems)
        {
            var totalPrice = 0m;

            foreach (var cartItem in cartItems)
            {
                var hasPromotion = cartItem.Item.Promotion != null || cartItem.Item.Promotion != (short)Promotion.None;

                totalPrice += hasPromotion
                    ? _promotionBusiness.ApplyPromotion(cartItem)
                    : cartItem.Item.Price * cartItem.Count;
            }

            return totalPrice;
        }

        public string BuildCartHtml(IEnumerable<DTOCartItem> cartItems)
        {
            return BuildHtmlTable(cartItems);
        }



        #region Private Methods

        private string BuildHtmlTable(IEnumerable<DTOCartItem> cartItems)
        {
            var table = new StringBuilder();

            table.Append("<table class=\"table\">");
            table.Append("<tr>");
            table.Append(@"<th>Item</th>
                           <th>Quantidade</th>
                           <th>Preço</th>
                           <th>Promoção</th>");
            table.Append("</tr>");

            foreach(var cartItem in cartItems)
            {
                table.Append($@"<tr>
                                <td>{cartItem.Item.Name}</td>
                                <td>{cartItem.Count}</td>
                                <td>R$ {_promotionBusiness.ApplyPromotion(cartItem).ToString("0.00")}</td>
                                <td>{GetPromotionName((Promotion)cartItem.Item.Promotion)}</td>
                                </tr>");
            }

            table.Append("<tr>");
            table.Append($"<td></td><td>Total</td><td>R$ {CalculateTotalPrice(cartItems)}</td><td></td>");
            table.Append("</table>");

            return table.ToString();
        }

        private string GetPromotionName(Promotion? promotion)
        {
            return promotion.HasValue
                ? _promotionBusiness.GetPromotionName((Promotion)promotion.Value)
                : "-";
        }

        #endregion
    }
}
