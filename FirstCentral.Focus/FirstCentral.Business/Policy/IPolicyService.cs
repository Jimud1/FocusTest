using FirstCentral.Models.FocusModels;
using FirstCentral.Settings.Enums.Focus;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="payment"></param>
        /// <param name="workflowId"></param>
        /// <param name="noPaymentReason"></param>
        void PolicyCancellation(bool payment, string workflowId, NoPaymentReason noPaymentReason);
    }
}
