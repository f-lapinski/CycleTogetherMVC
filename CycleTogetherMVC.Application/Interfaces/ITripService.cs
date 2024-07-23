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
        public List<Trip> GetAllTripsForList();
    }
}
