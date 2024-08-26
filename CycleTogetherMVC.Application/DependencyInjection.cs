using CycleTogetherMVC.Application.Interfaces;
using CycleTogetherMVC.Application.Services;
using CycleTogetherMVC.Application.Validators;
using CycleTogetherMVC.Application.ViewModels.Trip;
using CycleTogetherMVC.Application.ViewModels.TripComment;
using CycleTogetherMVC.Domain.Model;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ITripService, TripService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            
            services.AddScoped<IValidator<NewTripVm>, NewTripVmValidator>();
            services.AddScoped<IValidator<TripComment>, AddCommentValidator>();

            services.AddFluentValidationAutoValidation();

            return services;
        }
    }
}
