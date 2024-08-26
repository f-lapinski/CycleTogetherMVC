using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleTogetherMVC.Domain.Model;
using FluentValidation;

namespace CycleTogetherMVC.Application.Validators
{
    public class AddCommentValidator : AbstractValidator<TripComment>
    {
        public AddCommentValidator()
        {
            RuleFor(comment => comment.Content)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);

            RuleFor(comment => comment.CreatedAt)
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Created date cannot be in the future.");
        }
    }
}
