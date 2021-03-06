﻿using System;
using System.Data.Entity;
using HppTuning.Data;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Race;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HppTuning.Services
{
    public class RaceService : Service
    {
        
        public RaceService()
        {
        }
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
                BestTimeOfTheDay = raceModel.BestLapTimeOfTheDay,
                Tracks = raceModel.Tracks,
                Tyres = raceModel.Tyres
            };

            this.Context.RaceingHistorieses.Add(raceHistory);
            this.Context.SaveChanges();
        }
    }
}
