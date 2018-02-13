using FirstCentral.Business.Policy;
using FirstCentral.Models.FocusModels;
using System;
using System.Web.Http;

namespace FirstCentral.Focus.Controllers
{
    public class PolicyController : ApiController
    {
        IPolicyService _policyService;

        public PolicyController()
        {
            //Lazy for now, look into IoC
            _policyService = new PolicyService();
        }

        [HttpPost]
        public PolicyModel GetByPolicyKey([FromBody]string policyKey)
        {
            try
            {
                var policy = _policyService.GetByPolicyNumber(policyKey);
                return policy;
            }
            catch(ArgumentNullException ane)
            {
                throw ane;
            }
        }
    }
}
