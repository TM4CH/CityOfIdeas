using System.ComponentModel.DataAnnotations;
using Domain.Project;

namespace Domain
{
    public class VoteIdeation : Vote
    {
        [Required]
        public virtual Ideation Ideation { get; set; }
    }
}