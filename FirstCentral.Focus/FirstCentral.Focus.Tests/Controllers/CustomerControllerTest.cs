using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCentral.Focus.Controllers;
using System.Web.Mvc;

namespace FirstCentral.Focus.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTest
    {

        CustomerController _controller;
        public CustomerControllerTest()
        {
            _controller = new CustomerController();
        }

        [TestMethod]
        public void DisplayCustomerSearchTest()
        {
            // Act
            var result = _controller.DisplayCustomerSearch() as PartialViewResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("_customerSearch", result.ViewName);
        }

        [TestMethod]
        public void DisplayCustomerAddTest()
        {
            // Act
            var result = _controller.DisplayCustomerAdd() as PartialViewResult;
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("_customerAdd", result.ViewName);
        }
    }
}
