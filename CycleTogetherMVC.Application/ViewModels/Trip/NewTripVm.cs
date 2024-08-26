using AutoMapper;
using CycleTogetherMVC.Application.Mapping;
using TripModel = CycleTogetherMVC.Domain.Model.Trip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CycleTogetherMVC.Application.ViewModels.Trip
{
    public class NewTripVm : IMapFrom<TripModel>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now.Date;

        public DateTime EndDate { get; set; } = DateTime.Now.Date;

        public int Distance { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewTripVm, TripModel>().ReverseMap();
        }
    }
}
