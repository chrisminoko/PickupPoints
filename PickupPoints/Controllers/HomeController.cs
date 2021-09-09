using PickupPointsAPIHelper.ApiHelperLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PickupPoints.Controllers
{
    public class HomeController : Controller
    {
        private  readonly IApiHelperLogic _apiHelperLogic;

        public HomeController(IApiHelperLogic apiHelperLogic)
        {
            _apiHelperLogic = apiHelperLogic;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}