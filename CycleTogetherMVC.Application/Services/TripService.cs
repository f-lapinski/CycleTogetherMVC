using AutoMapper;
using AutoMapper.QueryableExtensions;
using CycleTogetherMVC.Application.Interfaces;
using CycleTogetherMVC.Application.ViewModels.Trip;
using CycleTogetherMVC.Application.ViewModels.TripComment;
using CycleTogetherMVC.Domain.Interface;
using CycleTogetherMVC.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.Services
{
    public class TripService : ITripService
    {
        private readonly ITripRepository _tripRepository;
        private readonly IMapper _mapper;

        public TripService(ITripRepository tripRepository, IMapper mapper)
        {
            _tripRepository = tripRepository;
            _mapper = mapper;
        }
        public int AddTrip(NewTripVm trip)
        {
            var newTrip = _mapper.Map<Trip>(trip);
            newTrip.Author = "Test User";
            newTrip.IsActive = true;
            var id = _tripRepository.AddTrip(newTrip);

            return id;
        }

        public ListTripForListVm GetAllTripsForList()
        {
            var trips = _tripRepository.GetAllActiveTrips()
                .ProjectTo<TripForListVm>(_mapper.ConfigurationProvider).ToList();

            var tripList = new ListTripForListVm()
            {
                Trips = trips,
                Count = trips.Count
            };

            return tripList;
        }

        public TripDetailsVm GetTripDetails(int tripId)
        {
            var trip = _tripRepository.GetTripById(tripId);
            var tripComments = _tripRepository.GetTripComments(tripId)
                .ProjectTo<CommentForListVm>(_mapper.ConfigurationProvider).ToList();
            
            var tripVm = _mapper.Map<TripDetailsVm>(trip);
            tripVm.Comments = tripComments;

            return tripVm;
        }

        public NewTripVm GetTripForEdit(int tripId)
        {
            var trip = _tripRepository.GetTripById(tripId);
            var tripVm = _mapper.Map<NewTripVm>(trip);

            return tripVm;
        }

        public void UpdateTrip(NewTripVm model)
        {
            var trip = _mapper.Map<Trip>(model);
            _tripRepository.UpdateTrip(trip);
        }

        public void DeleteTrip(int tripId)
        {
            _tripRepository.DeleteTrip(tripId);
        }

        public int AddComment(NewCommentVm model)
        {
            var newComment = _mapper.Map<TripComment>(model);
            newComment.Author = "Test Author of Comment";
            var id = _tripRepository.AddComment(newComment);

            return id;
        }
    }
}
