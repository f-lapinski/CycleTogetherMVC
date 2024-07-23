using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTogetherMVC.Application.ViewModels.TripComment
{
    public class ListCommentForListVm
    {
        public List<CommentForListVm> Comments { get; set; }

        public int Count { get; set; }
    }
}
