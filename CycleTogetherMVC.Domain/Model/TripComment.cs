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

        public string Content { get; set; }

        public string Author { get; set; }

        public int TripId { get; set; }

        public Trip Trip { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
