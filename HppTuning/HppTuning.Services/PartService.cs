using AutoMapper;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Part;
using HppTuning.Services.Dependancies;
using System.Collections.Generic;
using System.Linq;

namespace HppTuning.Services
{
    public class PartService : Service, IPartService
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
                //AutoMapper map our ViewModel to Entity
                SimplePartViewModel simplePartViewModel = Mapper.Map<Part, SimplePartViewModel>(item);
           
                listOfPartViewModels.Add(simplePartViewModel);
            }
            allPartsViewModel.AllParts = listOfPartViewModels;
        
            return allPartsViewModel;
        }

        public void AddNewPart(SimplePartViewModel simplePartViewModel)
        {
            var data = this.Context.Parts.ToArray();
            //AutoMapper Mapped
            Part part = Mapper.Map<SimplePartViewModel, Part>(simplePartViewModel);
        

            this.Context.Parts.Add(part);
            this.Context.SaveChanges();

        }
    }
}
