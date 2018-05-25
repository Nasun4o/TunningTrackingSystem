using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Description = raceModel.Description,
                HistoryDate = DateTime.Now
            };

            this.Context.RaceingHistorieses.Add(raceHistory);
            this.Context.SaveChanges();
        }
    }
}
