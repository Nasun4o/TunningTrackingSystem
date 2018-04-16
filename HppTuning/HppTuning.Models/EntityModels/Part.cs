using System;

namespace HppTuning.Models.EntityModels
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string PartBuyedFrom { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public DateTime? ExpectedDateOfDelivery { get; set; }
        public bool IsPartInstalled { get; set; }

        public virtual Car Cars { get; set; }
        public int? CarId { get; set; }
    }
}
