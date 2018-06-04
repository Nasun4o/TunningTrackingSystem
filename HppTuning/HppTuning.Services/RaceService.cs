using System;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Race;

namespace HppTuning.Services
{
    public class RaceService : Service
    {
        public void AddNewRaceHistory(RacingViewModel raceModel)
        {

            var raceHistory = new RacingHistories()
            {
                FrontTiresPressure = raceModel.FrontTiresPressure,
                RearTiresPressure = raceModel.RearTiresPressure,
                FrontCoiloverClicks = raceModel.RearCoiloverClicks,
                RearCoiloverClicks = raceModel.RearCoiloverClicks,
                Notes = raceModel.Notes,
                TimeOfHistoryCreated = DateTime.Now,
                BestTimeOfTheDay = raceModel.BestTimeOfTheDay,
                Tracks = raceModel.Tracks,
                Tyres = raceModel.Tyres
            };

            this.Context.RaceingHistorieses.Add(raceHistory);
            this.Context.SaveChanges();
        }
    }
}
