using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.Trip
{
    public class ListTripForListVm
    {
        public List<TripForListVm> Trips { get; set; }

        public int Count { get; set; }
    }
}
