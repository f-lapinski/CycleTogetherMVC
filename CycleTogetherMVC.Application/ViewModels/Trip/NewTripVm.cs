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

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Distance { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewTripVm, TripModel>();
        }
    }

    public class NewTripVmValidation : AbstractValidator<NewTripVm>
    {
        public NewTripVmValidation() 
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
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("Start Date must be Greater or Equal to Today Date");

            RuleFor(input => input.EndDate)
                .NotEmpty()
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("End Date must be Greater or Equal to Today Date");

            RuleFor(input => input.Distance)
                .NotEmpty()
                .GreaterThan(0).WithMessage("Distance must be greater than 0");
        }
    }
}
