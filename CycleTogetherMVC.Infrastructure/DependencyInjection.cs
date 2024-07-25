using CycleTogetherMVC.Domain.Interface;
using CycleTogetherMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services.AddTransient<ITripRepository, TripRepository>();
        }
    }
}
