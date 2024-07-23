using CycleTogetherMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CycleTogetherMVC.Web.Controllers
{
    public class TripController : Controller
    {
        private readonly ILogger _logger;
        
        private readonly ITripService _tripService;

        public TripController(ILogger logger, ITripService tripService)
        {
            _logger = logger;
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
            return View();
        }

        public IActionResult AddTrip(TripModel model)
        {
            var id = _tripService.AddTrip(model);
            return View();
        }

        public IActionResult ViewTrip(int tripId) 
        {
            var tripModel = _tripService.GetTripById(tripId);
            return View(tripModel);
        }
    }
}
