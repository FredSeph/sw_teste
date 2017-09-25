using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWBusiness;
using SWDomain.DataTransferObjects;
using SWDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWUnitTests.Business
{
    [TestClass]
    public class PromotionBusinessTests
    {
        [TestMethod]
        public void TestApplyNoPromotion()
        {
            var cartItem = new DTOCartItem() { Item = new Item() { Id = 0, Name = "", Price = 3.0m, Promotion = 0 }, Count = 2 };
            decimal result = new PromotionBusiness().ApplyPromotion(cartItem);

            object.Equals(result, 3.0m);
        }

        [TestMethod]
        public void TestApplyPromotionBuyOneGetOneFree()
        {
            var cartItem = new DTOCartItem() { Item = new Item() { Id = 0, Name = "", Price = 2.0m, Promotion = 1 }, Count = 2 };
            decimal result = new PromotionBusiness().ApplyPromotion(cartItem);

            object.Equals(result, 2.0m);
        }

        [TestMethod]
        public void TestApplyPromotionThreeFor10()
        {
            var cartItem = new DTOCartItem() { Item = new Item() { Id = 0, Name = "", Price = 4.0m, Promotion = 2 }, Count = 3 };
            decimal result = new PromotionBusiness().ApplyPromotion(cartItem);

            object.Equals(result, 10.0m);
        }
    }
}
