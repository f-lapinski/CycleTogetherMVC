using CycleTogetherMVC.Application.ViewModels.TripComment;
using CycleTogetherMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.Trip
{
    public class TripDetailsVm
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Distance { get; set; }

        public ListCommentForListVm Comments {  get; set; }

        public string Author { get; set; }
    }
}
