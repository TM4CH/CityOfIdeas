using System.Collections.Generic;
using Domain.ProjectClasses.SurveyClasses;

namespace Domain.ProjectClasses.PhaseClasses
{
    public class PhaseSurvey
    {
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}