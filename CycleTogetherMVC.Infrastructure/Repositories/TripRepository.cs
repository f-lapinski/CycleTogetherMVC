using CycleTogetherMVC.Domain.Interface;
using CycleTogetherMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Infrastructure.Repositories
{
    public class TripRepository : ITripRepository
    {
        private readonly Context _context;

        public TripRepository(Context context)
        {
            _context = context;
        }

        public void DeleteTrip(int tripId)
        {
            var trip = _context.Trips.Find(tripId);
            if (trip != null)
            {
                _context.Trips.Remove(trip);
                _context.SaveChanges();
            }
        }

        public int AddTrip(Trip trip)
        {
            _context.Trips.Add(trip);
            _context.SaveChanges();

            return trip.Id;
        }

        public Trip GetTripById(int tripId)
        {
            var trip = _context.Trips.FirstOrDefault(t => t.Id == tripId);
            return trip;
        }

        public IQueryable<Trip> GetAllActiveTrips()
        {
            var trips = _context.Trips.Where(t => t.IsActive == true);
            return trips;
        }
    }
}
