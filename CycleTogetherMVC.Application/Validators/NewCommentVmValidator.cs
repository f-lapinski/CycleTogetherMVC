using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleTogetherMVC.Application.ViewModels.Trip;
using CycleTogetherMVC.Application.ViewModels.TripComment;
using CycleTogetherMVC.Domain.Model;
using FluentValidation;

namespace CycleTogetherMVC.Application.Validators
{
    public class NewCommentVmValidator : AbstractValidator<NewCommentVm>
    {
        public NewCommentVmValidator()
        {
            RuleFor(comment => comment.Content)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
        }
    }
}
