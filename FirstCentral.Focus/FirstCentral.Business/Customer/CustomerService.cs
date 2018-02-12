using System;
using FirstCentral.Models.FocusModels;
using FirstCentral.Data.FocusData;
using FirstCentral.Data.Entities.Focus;
using System.Collections.Generic;

namespace FirstCentral.Business.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository _repository;
        public CustomerService()
        {
            _repository = new Repository();
        }
        public CustomerModel Add(CustomerModel model)
        {
            var entity = ModelToEntity(model);
            var toReturn = EntityToModel(_repository.ApplicationDbContext.Customers.Add(entity));
            return toReturn;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerModel> Get()
        {
            throw new NotImplementedException();
        }

        public CustomerModel GetById(int id)
        {
            var customer = _repository.ApplicationDbContext.Customers.Find(id);
            return EntityToModel(customer);
        }

        public CustomerModel GetByPolicyNumber(string policyNo)
        {
            throw new NotImplementedException();
        }

        public CustomerModel Update(CustomerModel obj)
        {
            throw new NotImplementedException();
        }

        private CustomerModel EntityToModel(CustomerEntity entity)
        {
            var model = new CustomerModel
            {
                CustomerId = entity.CustomerId,
                Forename = entity.FirstName
            };
            return model;
        }

        private CustomerEntity ModelToEntity(CustomerModel model)
        {
            var entity = new CustomerEntity
            {
                //Never try to set Entity Id from a model
                FirstName = model.Forename
            };
            return entity;
        }
    }
}
