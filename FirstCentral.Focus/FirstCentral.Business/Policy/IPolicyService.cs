using FirstCentral.Models.FocusModels;
namespace FirstCentral.Business.Policy
{
    public interface IPolicyService : IService<PolicyModel>
    {
        /// <summary>
        /// Gets policy by policy number
        /// </summary>
        /// <param name="policyNo"></param>
        /// <returns></returns>
        PolicyModel GetByPolicyNumber(string policyNo);
    }
}
