using System.Collections.Generic;

namespace Domain.Project.Phase
{
    public class PhaseIdeation : Phase
    {
        public virtual ICollection<Ideation> Ideations { get; set; }
    }
}