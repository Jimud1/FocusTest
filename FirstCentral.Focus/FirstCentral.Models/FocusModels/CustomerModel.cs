using System;

namespace FirstCentral.Models.FocusModels
{
    public class CustomerModel : IModel
    {
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string FullName { get { return $"{Forename} {Surname}"; } }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public EmploymentDetailsModel EmploymentDetails { get; set; }
        public ContactDetailsModel ContactDetails { get; set; }
        public AddressModel AddressDetails { get; set; }
    }
}
