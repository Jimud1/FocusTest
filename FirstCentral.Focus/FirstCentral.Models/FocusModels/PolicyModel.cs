
using System;

namespace FirstCentral.Models.FocusModels
{
    public class PolicyModel : IModel
    {
        public decimal PolicyId { get; set; }
        public string ProductName { get; set; }
        public string PolicyStatus { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public bool PolicyRowStatus { get; set; }
    }
}
