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
        public IActionResult Create()
        {
            return View(new NewTripVm());
        }

        [HttpPost]
        public IActionResult Create(NewTripVm model)
        {
            var id = _tripService.AddTrip(model);
            return RedirectToAction("Index");
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
