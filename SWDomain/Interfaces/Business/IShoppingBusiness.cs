using SWDomain.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Business
{
    public interface IShoppingBusiness
    {
        int CountItems(IEnumerable<DTOCartItem> cartItems);
        decimal CalculateTotalPrice(IEnumerable<DTOCartItem> cartItems);
        string BuildCartHtml(IEnumerable<DTOCartItem> cartItems);
    }
}
