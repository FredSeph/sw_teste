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

        public ItemsController(IItemBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }

        #endregion

        [HttpGet]
        public ActionResult Index()
        {
            var model = new IndexModel();

            model.Items = _itemBusiness.GetAll(true);

            return View(model);
        }
    }
}