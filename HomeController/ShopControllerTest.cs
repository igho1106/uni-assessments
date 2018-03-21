using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MVCProject.Controllers;
using MVCProject.Models;

namespace MVCProjectTest
{
    /// <summary>
    /// Summary description for ShopControllerTest
    /// </summary>
    [TestClass]
    public class ShopControllerTest
    {
  


        [TestMethod]
        public void IndexWelcomeMessage()
        {
            //Arrange
            ShopController controller = new ShopController();

            //Act
            ViewResult result = controller.Index();

            //Assert
            Assert.AreEqual("Welcome to the shop. Kindly spend all your money!", controller.ViewBag.WelcomeMessage);

        }

        [TestMethod]

        public void ProductName()
        {
            //Arrange
            ShopController controller = new ShopController();

            //Act
            ViewResult viewResult = controller.Product();
            ProductModel result = viewResult.Model as ProductModel;

            //Assert
            Assert.AreEqual("IPhone 6", result.Name);

        }

        [TestMethod]
        
        public void ProductIsBling()
        {
            //Arrange
            ShopController controller = new ShopController();

            //Act
            ViewResult result = controller.Product();

            //Assert
            Assert.AreEqual("Bling!", result.ViewBag.Subtitle);
        }
        
        [TestMethod]

        public void ProductIsCheapAndNasty()
        {
            //Arrange
            ProductModel _model = new ProductModel();
            _model.Name = "Test Profuct 1";
            _model.Description = "Description of Test Product 1";
            _model.Price = 150M;

            //Inject the controller's dependency on the model so we can test it

            ShopController controller = new ShopController();

            //Act
            ViewResult result = controller.Product();
            Assert.AreNotEqual("Cheap and nasty product!", result.ViewBag.Subtitle);
        }
    }
}
