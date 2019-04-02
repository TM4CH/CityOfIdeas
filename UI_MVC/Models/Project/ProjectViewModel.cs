using Domain.ProjectClasses.PhaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI_MVC.Models
{
    public class ProjectViewModel
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }

    }
}
