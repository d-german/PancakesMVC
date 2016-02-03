﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PancakesMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Home
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

        public ActionResult Pancakes()
        {
            ViewBag.Message = "How many pancakes?";

            return View();
        }


    }
}