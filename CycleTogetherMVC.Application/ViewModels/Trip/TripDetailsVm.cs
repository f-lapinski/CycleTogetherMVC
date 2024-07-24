using AutoMapper;
using CycleTogetherMVC.Application.ViewModels.TripComment;
using TripModel = CycleTogetherMVC.Domain.Model.Trip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleTogetherMVC.Application.Mapping;

namespace CycleTogetherMVC.Application.ViewModels.Trip
{
    public class TripDetailsVm : IMapFrom<TripModel>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Distance { get; set; }

        public List<CommentForListVm> Comments {  get; set; }

        public string Author { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TripModel, TripDetailsVm>()
                .ForMember(s => s.Comments, opt => opt.MapFrom(s => s.TripComments));
        }
    }
}
