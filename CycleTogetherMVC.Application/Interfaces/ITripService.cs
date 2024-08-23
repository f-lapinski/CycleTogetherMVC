using CycleTogetherMVC.Application.ViewModels.Trip;
using CycleTogetherMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.Interfaces
{
    public interface ITripService
    {
        ListTripForListVm GetAllTripsForList();

        int AddTrip(NewTripVm trip);

        TripDetailsVm GetTripDetails(int tripId);

        NewTripVm GetTripForEdit(int tripId);

        void UpdateTrip(NewTripVm model);

        void DeleteTrip(int tripId);

        TripComment AddComment(int id, string comment);
    }
}
