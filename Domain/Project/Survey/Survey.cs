using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Project
{
    public class Survey
    {
        [Key] public string Id { get; set; }
        [Required] public virtual User.User  User{ get; set; }
        [Required] public virtual Phase.Phase Phase { get; set; }
        [Required] public virtual ICollection<Question> Questions { get; set; }    
    }
}