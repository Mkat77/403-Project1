using Project1.DAL;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project1.Controllers
{
    //Mark Simpson Is 403 Project 1
    //This is a website that describes missions for future missionaries

    public class HomeController : Controller
    {

        private MissionarySiteContext db = new MissionarySiteContext();

        //This is the method that will run when the page is initial loaded and returns the index view for the home page
        public ActionResult Index()
        {
            return View();
        }

        //This is an action method that will return the view for the about page that is in the about view. Pretty simple overall
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //Action method that returns the view for the contact page. Again for this project its pretty simple and doesnt use 
        //much functionality yet
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //This is a method i wrote that will pull up the missions view where the user can then navigate to the mission of thier choice
        public ActionResult Missions()
        {
            ViewBag.Message = "Mission Page";

            return View();
        }
        
        //This method runs when the user goes a level deeper from the missions page. This method has a stongly typed view
        //that will pass each parameter for every attribute needed to describe the mission depending on the users
        //the viewbag allows it to be dynamic so it can change and then display differently on the faq view
       
       
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

        //this is just an action result method written for the extra credit google maps api that will pass address
        //as a parameter from there, the google map will begin on the address of whatever the user passes
        public ActionResult Directions(string sAddress)
        {
            ViewBag.Address = sAddress;
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }


        //Action Method that will allow a client to authenticate themselves and access their northwest lab account
        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String email = form["Email"].ToString();
            String password = form["Password"].ToString();

            var currentUser = db.Database.SqlQuery<Users>(
                "Select * " +
                "FROM Users " +
                "WHERE UserEmail = '" + email + "' AND " +
                 "Password = '" + password + "'");
           
            if (currentUser.Count() > 0)
            {
                FormsAuthentication.SetAuthCookie(email, rememberMe);
                return RedirectToAction("Index", "MissionQuestions", new { userlogin = email });
            }
            else
            {
                return View();
            }
        }
    
    }
}