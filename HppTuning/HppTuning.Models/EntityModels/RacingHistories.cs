using System;

namespace HppTuning.Models.EntityModels
{
    public class RacingHistories
    {
        public int Id { get; set; }
        ///Pressure in Bars
        public double FrontTiresPressure { get; set; }
        public double RearTiresPressure { get; set; }
        //Click on coilovers.
        public int FrontCoiloverClicks { get; set; }
        public int RearCoiloverClicks { get; set; }
        public string Description { get; set; }
        public DateTime HistoryDate { get; set; }

        public SimpleNotUser SimpleNotUser { get; set; }
    }
}
