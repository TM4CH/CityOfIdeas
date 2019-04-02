using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.ProjectClasses.PhaseClasses;

namespace Domain.ProjectClasses
{
    public class Survey
    {
        [Key] public string Id { get; set; }
        [Required] public virtual User  User{ get; set; }
        [Required] public virtual Phase Phase { get; set; }
        [Required] public virtual ICollection<Question> Questions { get; set; }    
    }
}