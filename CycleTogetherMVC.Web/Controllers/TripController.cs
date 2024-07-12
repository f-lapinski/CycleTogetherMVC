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
            return View();
        }
    }
}
