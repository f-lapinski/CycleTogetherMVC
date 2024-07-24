using CycleTogetherMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Domain.Interface
{
    public interface ITripRepository
    {
        void DeleteTrip(int tripId);

        int AddTrip(Trip trip);

        Trip? GetTripById(int tripId);

        IQueryable<Trip> GetAllActiveTrips();

    }
}
