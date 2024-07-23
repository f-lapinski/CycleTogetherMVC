using CycleTogetherMVC.Application.Interfaces;
using CycleTogetherMVC.Application.ViewModels.Trip;
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
        public int AddTrip(NewTripVm trip)
        {
            throw new NotImplementedException();
        }

        public ListTripForListVm GetAllTripsForList()
        {
            throw new NotImplementedException();
        }

        public TripDetailsVm GetTripDetails(int tripId)
        {
            throw new NotImplementedException();
        }
    }
}
