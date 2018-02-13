using System;

namespace FirstCentral.Data.Entities.Focus
{
    public class PolicyEntity
    {
        public decimal PolicyId { get; set; }
        public string ProductName { get; set; }
        public string PolicyStatus { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public byte PolicyRowStatus { get; set; }
    }
}
