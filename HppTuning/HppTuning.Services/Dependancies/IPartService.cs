using HppTuning.Models.ViewModels.Part;

namespace HppTuning.Services.Dependancies
{
    public interface IPartService
    {
        SimplePartViewModel SetPartFormGetModel(int id);
        AllPartsViewModel ShowAllPartsForCarById(int id);
        void AddNewPart(SimplePartViewModel simplePartViewModel);
    }
}
