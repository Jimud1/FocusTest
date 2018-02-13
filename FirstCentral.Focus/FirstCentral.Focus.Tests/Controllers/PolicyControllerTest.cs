using FirstCentral.Models.FocusModels;
using FirstCentral.Focus.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCentral.Data.FocusData;
using System.Web.Http.Results;
using FirstCentral.Business.Policy;
using System;

namespace FirstCentral.Focus.Tests.Controllers
{
    [TestClass] 
    public class PolicyControllerTest
    {

        //Arrange
        PolicyController _policyController;
        const string StringToTest = "FPM4002807170FC";
        public PolicyControllerTest()
        {
            _policyController = new PolicyController(new PolicyService());
        }

        [TestMethod]
        public void GetByPolicyKeyTest()
        {
            var modelExpected = new PolicyModel //FPM4002807170FC
            {
                PolicyId = 6298831,
                ProductName = "Private Motor Car",
                PolicyStatus = "Live",
                PolicyStartDate = Convert.ToDateTime("2016-08-22 00:01:00.000"),
                PolicyEndDate = Convert.ToDateTime("2017-08-21 23:59:00.000"),
                PolicyRowStatus = false
            };

            //Act
            var policyTest = _policyController.GetByPolicyKey(StringToTest);
            var contentResult = policyTest as OkNegotiatedContentResult<PolicyModel>;
            //Assert
            Assert.IsNotNull(policyTest);
            Assert.IsNotNull(contentResult.Content);
            Assert.IsInstanceOfType(policyTest, typeof(OkNegotiatedContentResult<PolicyModel>));
            Assert.AreEqual(modelExpected.PolicyId, contentResult.Content.PolicyId);
            Assert.AreEqual(modelExpected.ProductName, contentResult.Content.ProductName);
            Assert.AreEqual(modelExpected.PolicyStartDate, contentResult.Content.PolicyStartDate);
            Assert.AreEqual(modelExpected.PolicyEndDate, contentResult.Content.PolicyEndDate);
        }

        [TestMethod]
        public void GetByPolicyKeyTestFail()
        {
            //Act
            var policyTest = _policyController.GetByPolicyKey(string.Empty);
            //Assert
            Assert.IsNotNull(policyTest);
            Assert.IsInstanceOfType(policyTest, typeof(NotFoundResult));
        }
    }
}
