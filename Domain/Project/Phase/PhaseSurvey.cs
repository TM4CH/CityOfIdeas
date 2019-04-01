using System.Collections.Generic;

namespace Domain.Project
{
    public class PhaseSurvey
    {
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}