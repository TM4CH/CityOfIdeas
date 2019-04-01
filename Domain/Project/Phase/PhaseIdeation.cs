using System.Collections.Generic;

namespace Domain.Project
{
    public class PhaseIdeation : Phase
    {
        public virtual ICollection<Ideation> Ideations { get; set; }
    }
}