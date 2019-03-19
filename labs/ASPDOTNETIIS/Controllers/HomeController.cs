using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPDOTNETIIS.Models;

namespace ASPDOTNETIIS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View("CreateFormEmpty");
        }
        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            return View("Create");
        }
        [HttpPost]
        //public ActionResult Create(int id)
        //{
        //    return View("Create");
        //}
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