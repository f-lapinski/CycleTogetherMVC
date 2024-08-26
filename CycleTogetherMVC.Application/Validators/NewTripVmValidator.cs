using CycleTogetherMVC.Application.ViewModels.Trip;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.Validators
{
    public class NewTripVmValidator : AbstractValidator<NewTripVm>
    {
        public NewTripVmValidator()
        {
            RuleFor(input => input.Title)
                .NotEmpty()
                .MinimumLength(10)
                .MaximumLength(100);

            RuleFor(input => input.Description)
                .NotEmpty()
                .MinimumLength(10)
                .MaximumLength(255);

            RuleFor(input => input.StartDate)
                .NotEmpty()
                .GreaterThanOrEqualTo(DateTime.Now);

            RuleFor(input => input.EndDate)
                .NotEmpty()
                .GreaterThanOrEqualTo(DateTime.Now);

            RuleFor(input => input.Distance)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
