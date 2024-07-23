using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.Trip
{
    public class TripForListVm
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required int Distance { get; set; }
    }
}
