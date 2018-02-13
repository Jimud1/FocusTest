using System;
using System.Collections.Generic;
using FirstCentral.Models.FocusModels;
using FirstCentral.Data.FocusData;
using FirstCentral.Data.Entities.Focus;

namespace FirstCentral.Business.Policy
{
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

        public PolicyModel GetByPolicyNumber(string policyKey)
        {
            if (string.IsNullOrWhiteSpace(policyKey)) throw new ArgumentNullException("PolicyKey is null");

            using (var context = _repository.DatafixContext)
            {
                var result = context.Datafix_Policy_GET(policyKey);
                var toReturn = EntityToModel(result);
                return toReturn;
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
