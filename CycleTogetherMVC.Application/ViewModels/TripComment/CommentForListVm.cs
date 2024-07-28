using AutoMapper;
using CycleTogetherMVC.Application.Mapping;
using CycleTogetherMVC.Application.ViewModels.Trip;
using TripCommentModel = CycleTogetherMVC.Domain.Model.TripComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.TripComment
{
    public class CommentForListVm : IMapFrom<TripCommentModel>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime CreatedAt { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TripCommentModel, CommentForListVm>();
        }
    }
}
