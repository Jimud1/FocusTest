using System;
using System.Collections.Generic;
using FirstCentral.Models.FocusModels;
using FirstCentral.Data.FocusData;
using FirstCentral.Data.Entities.Focus;
using System.Data.SqlClient;

namespace FirstCentral.Business.Policy
{
    /// <summary>
    /// Main entry point for any use of Policy
    /// </summary>
    public class PolicyService : IPolicyService
    {
        private readonly IRepository _repository;
        public PolicyService()
        {
            _repository = new Repository();
        }

        public PolicyModel Add(PolicyModel obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PolicyModel> Get()
        {
            throw new NotImplementedException();
        }

        public PolicyModel GetById(int id)
        {
            throw new NotImplementedException();
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

        public PolicyModel Update(PolicyModel obj)
        {
            throw new NotImplementedException();
        }

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
    }
}
