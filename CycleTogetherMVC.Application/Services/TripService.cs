using CycleTogetherMVC.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.Services
{
    public class TripService : ITripService
    {
        public List<int> GetAllTrips()
        {
            return new List<int> { 1, 2, 3, 4 };
        }
    }
}
