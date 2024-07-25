﻿using CycleTogetherMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CycleTogetherMVC.Web.Controllers
{
    public class TripController : Controller
    {
        private readonly ITripService _tripService;

        public TripController(ITripService tripService)
        {
            _tripService = tripService;
        }
        public IActionResult Index()
        {
            var model = _tripService.GetAllTripsForList();
            return View(model);
        }

        public IActionResult AddTrip()
        {
            throw new NotImplementedException();
        }

        public IActionResult ViewTrip(int tripId) 
        {
            throw new NotImplementedException();
        }
    }
}
