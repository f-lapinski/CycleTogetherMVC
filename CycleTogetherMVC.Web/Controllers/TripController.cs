using CycleTogetherMVC.Application.Interfaces;
using CycleTogetherMVC.Application.ViewModels.Trip;
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

        [HttpGet]
        public IActionResult AddTrip()
        {
            return View(new NewTripVm());
        }

        [HttpPost]
        public IActionResult AddTrip(NewTripVm model)
        {
            var id = _tripService.AddTrip(model);
            return View();
        }

        public IActionResult Details(int id) 
        {
            var trip = _tripService.GetTripDetails(id);

            if (trip == null)
            {;
                return NotFound();
            } 
            else
            {
                return View(trip);
            }
        }
    }
}
