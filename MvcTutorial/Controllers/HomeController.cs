using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //log visits
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\15419\Desktop\log.txt", text);

            //perform logic
            //Random rnd = new Random(10);
            //int num = rnd.Next();
            //if (num >20000)
            //{
            //    return View("About");
            //}

            //display list of names
            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Bret"
            //};

            //return View(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}