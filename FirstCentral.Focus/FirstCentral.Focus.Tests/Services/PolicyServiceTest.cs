using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCentral.Business.Policy;
using FirstCentral.Models.FocusModels;

namespace FirstCentral.Focus.Tests.Services
{
    [TestClass]
    public class PolicyServiceTest
    {
        IPolicyService _policyService;
        public PolicyServiceTest()
        {
            _policyService = new PolicyService();
        }

        [TestMethod]
        public void GetPolicyByKeyTest()
        {
            const string policyKey = "FPM4004059226FC";
            // Act
            PolicyModel result = _policyService.GetByPolicyNumber(policyKey);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.PolicyId, 7976703);
        }
    }
}
