using System;

namespace HppTuning.Models.ViewModels.Race
{
    public class RacingViewModel
    {
        public double FrontTiresPressure { get; set; }
        public double RearTiresPressure { get; set; }
        public int FrontCoiloverClicks { get; set; }
        public int RearCoiloverClicks { get; set; }
        public string Description { get; set; }
    }
}
