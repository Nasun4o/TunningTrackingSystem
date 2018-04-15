using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HppTuning.Models.ViewModels.Part
{
    public class SimplePartViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string PartBuyedFrom { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public DateTime? ExpectedDateOfDelivery { get; set; }
        public bool IsPartInstalled { get; set; }
    }
}
