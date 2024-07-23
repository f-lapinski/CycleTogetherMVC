using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Domain.Model
{
    public class Trip
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public required DateTime StartDate { get; set; }

        public required DateTime EndDate { get; set; }

        public required int Distance { get; set; }

        public ICollection<TripComment> TripComments { get; set; } = new List<TripComment>();

        public required string Author { get; set; }
    }
}
