using SWDomain.Entities;
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

            model.Items = _itemBusiness.GetAll().OrderBy(i => i.Name);
            model.Promotions = _promotionBusiness.GetPromotionSelectList();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Item item)
        {
            _itemBusiness.Add(item);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Item item)
        {
            _itemBusiness.Update(item);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            _itemBusiness.RemoveById(id);

            return RedirectToAction("Index");
        }
    }
}