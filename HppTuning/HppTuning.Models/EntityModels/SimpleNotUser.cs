using System.ComponentModel.DataAnnotations;

namespace HppTuning.Models.EntityModels
{
    public class SimpleNotUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public Car Car { get; set; }
    }
}
