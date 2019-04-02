using System.ComponentModel.DataAnnotations;
using Domain.ProjectClasses.IdeationClasses;

namespace Domain.VoteClasses
{
    public class VoteIdeation : Vote
    {
        [Required]
        public virtual Ideation Ideation { get; set; }
    }
}