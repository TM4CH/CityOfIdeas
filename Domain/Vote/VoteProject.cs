using System.ComponentModel.DataAnnotations;

namespace Domain.Vote
{
    public class VoteProject : Vote
    {
        [Required]
        public virtual Project.Project Project { get; set; }
    }
}