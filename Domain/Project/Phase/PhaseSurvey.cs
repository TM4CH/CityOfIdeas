using System.Collections.Generic;

namespace Domain.Project.Phase
{
    public class PhaseSurvey
    {
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}