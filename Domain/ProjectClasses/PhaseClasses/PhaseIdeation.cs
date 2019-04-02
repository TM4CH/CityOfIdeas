using System.Collections.Generic;
using Domain.ProjectClasses.IdeationClasses;

namespace Domain.ProjectClasses.PhaseClasses
{
    public class PhaseIdeation : ProjectClasses.PhaseClasses.Phase
    {
        public virtual ICollection<Ideation> Ideations { get; set; }
    }
}