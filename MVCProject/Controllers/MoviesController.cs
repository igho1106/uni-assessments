using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject.Models;


namespace MVCProject.Controllers

{
    
    public class MoviesController : Controller
    {
        private ProductModel _model;
        public MoviesController() { }
        public MoviesController(ProductModel model)
        {
            _model = model;
        }
        // GET: Shop
        public ViewResult Index()
        {
            ViewBag.Title = "The shop";
            ViewBag.WelcomeMessage = "Welcome to the shop. Kindly spend all your money!";
            ViewData["CurrentTime"] = DateTime.Now;

            return View();

        }

        public ViewResult Product()
        {
       
            if (_model == null)
            {
                _model = new ProductModel();
                _model.Name = "IPhone 6";
                _model.Description = "Better than the IPhone 5 etc";
                _model.Price = 399.99M;
                
            }
            if (_model.Price > 200M)
            {
                ViewBag.Subtitle = "Bling!";
            }
            else 
            {
                ViewBag.Subtitle = "Cheap and nasty product!";

            }
            return View(_model);
        }

        public string Product(string Type, string Colour)
        {
            return string.Format ("Product Type = Trouser {0}, Colour = Blue {1}", Type, Colour);
        }

        public RedirectResult DVD()
        {
            return RedirectPermanent("~/Shop/Product");
        }
    }




}
