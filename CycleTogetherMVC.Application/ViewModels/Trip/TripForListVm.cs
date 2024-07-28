using AutoMapper;
using CycleTogetherMVC.Application.Mapping;
using TripModel = CycleTogetherMVC.Domain.Model.Trip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.Trip
{
    public class TripForListVm : IMapFrom<TripModel>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Distance { get; set; }

        public string Duration { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TripModel, TripForListVm>()
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.StartDate + " - " + src.EndDate));
        }
    }
}
