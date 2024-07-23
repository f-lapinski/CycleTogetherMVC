using CycleTogetherMVC.Application.Interfaces;
using CycleTogetherMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.Services
{
    public class TripService : ITripService
    {
        public List<Trip> GetAllTripsForList()
        {
            return new List<Trip>();
        }
    }
}
