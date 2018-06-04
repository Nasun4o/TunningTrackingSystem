using System;

namespace HppTuning.Models.EntityModels
{
    public class RacingHistories
    {
        public int Id { get; set; }
        ///Pressure in Bars
        public double? FrontTiresPressure { get; set; }
        public double? RearTiresPressure { get; set; }
        //Click on coilovers.
        public int? FrontCoiloverClicks { get; set; }
        public int? RearCoiloverClicks { get; set; }
        public string Notes { get; set; }
        public DateTime TimeOfHistoryCreated { get; set; }
        public string BestTimeOfTheDay { get; set; }
        public Tracks Tracks { get; set; }
        public string  Tyres { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
