using System.ComponentModel.DataAnnotations;

namespace Domain.VoteClasses
{
    public class VoteProject : Vote
    {
        [Required]
        public virtual ProjectClasses.Project Project { get; set; }
    }
}