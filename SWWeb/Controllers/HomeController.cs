using SWDomain.DataTransferObjects;
using SWDomain.Interfaces.Business;
using SWWeb.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWWeb.Controllers
{
    public class HomeController : Controller
    {
        #region Properties and Constructors

        private readonly IItemBusiness _itemBusiness;
        private readonly IShoppingBusiness _shoppingBusiness;

        public HomeController(IItemBusiness itemBusiness,
                              IShoppingBusiness shoppingBusiness)
        {
            _itemBusiness = itemBusiness;
            _shoppingBusiness = shoppingBusiness;
        }

        #endregion

        [HttpGet]
        public ActionResult Index()
        {
            var model = new HomeModel();

            Session["Cart"] = Session["Cart"] ?? new List<DTOCartItem>();

            model.Items = _itemBusiness.GetAll().OrderBy(i => i.Name);

            return View(model);
        }

        [HttpGet]
        public JsonResult LoadCart()
        {
            var currentCart = Session["Cart"] as List<DTOCartItem>;

            var result = GetCart(currentCart);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult AddItemToCart(int id, int count)
        {
            var item = _itemBusiness.GetById(id);

            var currentCart = Session["Cart"] as List<DTOCartItem>;

            if (currentCart.Any(i => i.Item.Id == item.Id))
            {
                currentCart.FirstOrDefault(i => i.Item.Id == item.Id).Count += count;
            }
            else
            {
                var newCartItem = new DTOCartItem() { Item = item, Count = count };
                currentCart.Add(newCartItem);
            }

            Session["Cart"] = currentCart;

            var result = GetCart(currentCart);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Checkout()
        {
            var currentCart = new List<DTOCartItem>();

            Session["Cart"] = currentCart;

            var result = GetCart(currentCart);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        #region Private Methods

        private object GetCart(List<DTOCartItem> currentCart)
        {
            return new { CartHtml = _shoppingBusiness.BuildCartHtml(currentCart), Count = _shoppingBusiness.CountItems(currentCart) };
        }

        #endregion
    }
}