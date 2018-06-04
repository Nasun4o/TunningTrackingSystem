using System;

namespace HppTuning.Models.ViewModels.Race
{
    public class RacingViewModel
    {
        public double FrontTiresPressure { get; set; }
        public double RearTiresPressure { get; set; }
        public int FrontCoiloverClicks { get; set; }
        public int RearCoiloverClicks { get; set; }
        public string Notes { get; set; }
        public DateTime TimeOfHistoryCreated { get; set; }
        public string BestTimeOfTheDay { get; set; }
        public Tracks Tracks { get; set; }
        public string Tyres { get; set; }
    }
}
