using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Missions()
        {
            ViewBag.Message = "Mission Page";

            return View();
        }

        public ActionResult MissionFAQ(string sName, string sPresName, string sAddress, string sLanguage, string sClimate, string sChurch)
        {
            ViewBag.Message = "FAQ Page";
            ViewBag.MissionName = sName;
            ViewBag.President = sPresName;
            ViewBag.Address = sAddress;
            ViewBag.Language = sLanguage;
            ViewBag.Climate = sClimate;
            ViewBag.Church = sChurch;
           
            return View();
        }

        public ActionResult Directions(string sAddress)
        {
            ViewBag.Address = sAddress;
            return View();
        }


    
    }
}