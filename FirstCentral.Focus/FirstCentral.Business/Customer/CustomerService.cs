using System;
using FirstCentral.Models.FocusModels;
using FirstCentral.Data.FocusData;

namespace FirstCentral.Business.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository _repository;
        public CustomerService()
        {
            _repository = new Repository();
        }
        public CustomerModel Add(CustomerModel obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerModel Get()
        {
            throw new NotImplementedException();
        }

        public CustomerModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerModel GetByPolicyNumber(string policyNo)
        {
            throw new NotImplementedException();
        }

        public CustomerModel Update(CustomerModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
