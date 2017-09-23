using SWDomain.Interfaces.Business;
using SWWeb.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWWeb.Controllers
{
    public class ItemsController : Controller
    {
        #region Properties and Constructors

        private readonly IItemBusiness _itemBusiness;
        private readonly IPromotionBusiness _promotionBusiness;

        public ItemsController(IItemBusiness itemBusiness,
                               IPromotionBusiness promotionBusiness)
        {
            _itemBusiness = itemBusiness;
            _promotionBusiness = promotionBusiness;
        }

        #endregion

        [HttpGet]
        public ActionResult Index()
        {
            var model = new ItemsModel();

            model.Items = _itemBusiness.GetAll(true);
            model.Promotions = _promotionBusiness.GetPromotionSelectList();

            return View(model);
        }
    }
}