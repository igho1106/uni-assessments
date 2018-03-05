using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ViewResult Index()
        {
            ViewBag.Title = "The shop";
            ViewBag.WelcomeMessage = "Welcome to the shop. Kindly spend all your money!";
            ViewData["CurrentTime"] = DateTime.Now;

            return View();

        }

        public string Product(string Type, string Colour)
        {
            return string.Format ("Product Type = {0}, Colour = {1}", Type, Colour);
        }





    }
}