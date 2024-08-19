using CycleTogetherMVC.Application.Mapping;
using TripCommentModel = CycleTogetherMVC.Domain.Model.TripComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;

namespace CycleTogetherMVC.Application.ViewModels.TripComment
{
    public class NewCommentVm : IMapFrom<TripCommentModel>
    {
        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCommentVm, TripCommentModel>();
        }

        public class NewCommentVmValidation : AbstractValidator<NewCommentVm>
        {
            public NewCommentVmValidation() 
            {
                RuleFor(input => input.Content)
                    .NotEmpty()
                    .MinimumLength(5)
                    .MaximumLength(255);
            }
        }
    }
}
