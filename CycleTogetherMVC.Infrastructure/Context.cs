using CycleTogetherMVC.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Trip> Trips {  get; set; }

        public DbSet<TripComment> TripComments { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}
