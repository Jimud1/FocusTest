using FirstCentral.Business.Policy;
using System;
using System.Data.SqlClient;
using System.Web.Http;

namespace FirstCentral.Focus.Controllers
{
    /// <summary>
    /// Policy controller for accessing anything policy related
    /// </summary>
    public class PolicyController : ApiController
    {
        IPolicyService _policyService;
        /// <summary>
        /// Constructor
        /// </summary>
        public PolicyController(IPolicyService policyService)
        {
            //Lazy for now, IoC in next inception
            _policyService = policyService;
        }

        /// <summary>
        /// Search for Policy by PolicyKey E.g. "FPM4002807170FC"
        /// </summary>
        /// <param name="policyKey"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetByPolicyKey([FromBody]string policyKey)
        {
            try
            {
                var policy = _policyService.GetByPolicyNumber(policyKey);
                return Ok(policy);
            }
            catch(ArgumentNullException)
            {
                return NotFound();
            }
            catch(SqlException)
            {
                return InternalServerError();
            }
        }
    }
}
