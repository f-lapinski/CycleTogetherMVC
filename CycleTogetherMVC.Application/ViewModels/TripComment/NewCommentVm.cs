using AutoMapper;
using CycleTogetherMVC.Application.Mapping;
using TripCommentModel = CycleTogetherMVC.Domain.Model.TripComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.TripComment
{
    public class NewCommentVm : IMapFrom<TripCommentModel>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int TripId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCommentVm, TripCommentModel>().ReverseMap();
        }
    }
}



