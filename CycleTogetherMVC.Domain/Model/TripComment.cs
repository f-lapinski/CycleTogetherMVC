using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Domain.Model
{
    public class TripComment
    {
        public int Id { get; set; }

        public required string Content { get; set; }

        public required string Author { get; set; }

        public required int TripId { get; set; }

        public required Trip Trip { get; set; }
    }
}
