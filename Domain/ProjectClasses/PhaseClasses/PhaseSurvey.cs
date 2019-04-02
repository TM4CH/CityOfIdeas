using System.Collections.Generic;
using Domain.Project;

namespace Domain.ProjectClasses.PhaseClasses
{
    public class PhaseSurvey
    {
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}