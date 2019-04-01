using System.ComponentModel.DataAnnotations;
using Domain.Project;

namespace Domain.Vote
{
    public class VoteIdeation : Vote
    {
        [Required]
        public virtual Ideation Ideation { get; set; }
    }
}