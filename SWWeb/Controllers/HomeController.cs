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

        public HomeController(IItemBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }

        #endregion

        [HttpGet]
        public ActionResult Index()
        {
            var model = new HomeModel();

            model.Items = _itemBusiness.GetAll().OrderBy(i => i.Name);

            return View(model);
        }

        public ActionResult Checkout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}