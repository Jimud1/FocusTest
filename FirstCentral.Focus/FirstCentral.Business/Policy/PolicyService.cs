using System;
using System.Collections.Generic;
using FirstCentral.Models.FocusModels;
using FirstCentral.Data.FocusData;
using FirstCentral.Data.Entities.Focus;
using System.Data.SqlClient;
using FirstCentral.Settings.Enums.Focus;

namespace FirstCentral.Business.Policy
{
    /// <summary>
    /// Main entry point for any use of Policy
    /// </summary>
    public class PolicyService : IPolicyService
    {
        private readonly IRepository _repository;
        public PolicyService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Entry point for where all gets by PolicyKey should be
        /// </summary>
        /// <param name="policyKey"></param>
        /// <returns></returns>
        public PolicyModel GetByPolicyNumber(string policyKey)
        {
            if (string.IsNullOrWhiteSpace(policyKey)) throw new ArgumentNullException("PolicyKey is null");

            using (var context = _repository.DatafixContext)
            {
                try
                {
                    var result = context.GetPolicyByPolicyKey(policyKey);
                    var toReturn = EntityToModel(result);
                    return toReturn;
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }
        public void PolicyCancellation(bool payment, string workflowId, NoPaymentReason noPaymentReason)
        {
            throw new NotImplementedException();
        }

        #region Helpers
        /// <summary>
        /// Turns model into entity
        /// </summary>
        /// <param name="model">Policy Model</param>
        /// <returns></returns>
        private PolicyEntity ModelToEntity(PolicyModel model)
        {
            var entity = new PolicyEntity
            {
                ProductName = model.ProductName,
                PolicyStatus = model.PolicyStatus,
                PolicyStartDate = model.PolicyStartDate,
                PolicyEndDate = model.PolicyEndDate,
                PolicyRowStatus = Convert.ToByte(model.PolicyRowStatus)
            };
            return entity;
        }

        /// <summary>
        /// Turns entity into model
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private PolicyModel EntityToModel(PolicyEntity entity)
        {
            var model = new PolicyModel
            {
                PolicyId = entity.PolicyId,
                ProductName = entity.ProductName,
                PolicyStatus = entity.PolicyStatus,
                PolicyStartDate = entity.PolicyStartDate,
                PolicyEndDate = entity.PolicyEndDate,
                PolicyRowStatus = Convert.ToBoolean(entity.PolicyRowStatus)
            };
            return model;
        }
        #endregion

        #region TODO
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public PolicyModel Add(PolicyModel obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<PolicyModel> Get()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PolicyModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public PolicyModel Update(PolicyModel obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
