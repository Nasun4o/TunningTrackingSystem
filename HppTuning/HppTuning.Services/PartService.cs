using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Part;
using System.Collections.Generic;
using System.Linq;

namespace HppTuning.Services
{
    public class PartService : Service
    {

        public SimplePartViewModel SetPartFormGetModel(int id)
        {
            SimplePartViewModel simplePartViewModel = new SimplePartViewModel
            {
                CarId = id
            };
            return simplePartViewModel;
        }

        public AllPartsViewModel ShowAllPartsForCarById(int id)
        {
            var data = this.Context.Parts.Where(x => x.CarId == id).ToArray();
            AllPartsViewModel allPartsViewModel = new AllPartsViewModel();
            List<SimplePartViewModel> listOfPartViewModels = new List<SimplePartViewModel>();

            foreach (var item in data)
            {
                SimplePartViewModel simplePartViewModel = new SimplePartViewModel()
                {
                    DateOfPurchase = item.DateOfPurchase,
                    ExpectedDateOfDelivery = item.ExpectedDateOfDelivery,
                    IsPartInstalled = item.IsPartInstalled,
                    Manufacturer = item.Manufacturer,
                    Name = item.Name,
                    PartBuyedFrom = item.PartBuyedFrom,
                    Price = item.Price
                };
                listOfPartViewModels.Add(simplePartViewModel);
            }
            allPartsViewModel.AllParts = listOfPartViewModels;
        
            return allPartsViewModel;
        }

        public void AddNewPart(SimplePartViewModel simplePartViewModel)
        {
            var data = this.Context.Parts.ToArray();
            Part part = new Part()
            {
                DateOfPurchase = simplePartViewModel.DateOfPurchase,
                ExpectedDateOfDelivery = simplePartViewModel.ExpectedDateOfDelivery,
                IsPartInstalled = simplePartViewModel.IsPartInstalled,
                Manufacturer = simplePartViewModel.Manufacturer,
                Name = simplePartViewModel.Name,
                PartBuyedFrom = simplePartViewModel.PartBuyedFrom,
                Price = simplePartViewModel.Price,
                CarId = simplePartViewModel.CarId
            };

            this.Context.Parts.Add(part);
            this.Context.SaveChanges();

        }
    }
}
