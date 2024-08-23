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

        public Trip? GetTripById(int tripId)
        {
            var trip = _context.Trips.SingleOrDefault(t => t.Id == tripId);
            return trip;
        }

        public IQueryable<Trip> GetAllActiveTrips()
        {
            var trips = _context.Trips.Where(t => t.IsActive == true);
            return trips;
        }

        public IQueryable<TripComment> GetTripComments(int tripId)
        {
            var comments = _context.TripComments.Where(c => c.TripId == tripId);
            return comments;
        }

        public void UpdateTrip(Trip trip)
        {
            _context.Attach(trip);
            _context.Entry(trip).Property("Title").IsModified = true;
            _context.Entry(trip).Property("Description").IsModified = true;
            _context.Entry(trip).Property("StartDate").IsModified = true;
            _context.Entry(trip).Property("EndDate").IsModified = true;
            _context.Entry(trip).Property("Distance").IsModified = true;
            _context.SaveChanges();

        }

        public void AddComment(TripComment comment)
        {
            _context.TripComments.Add(comment);
            _context.SaveChanges();
        }
    }
}
