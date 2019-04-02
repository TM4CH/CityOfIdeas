using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.UserClasses;
using Domain.VoteClasses;

namespace Domain.ProjectClasses.IdeationClasses
{
    public class Idea
    {
        /*
         * Properties
         */
        [Key]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Map { get; set; }
        public string Video { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        // public ClosedQuestion ClosedQuestion { get; set; }
        // public OpenQuestion OpenQuestion { get; set; }
        public virtual ICollection<VoteIdeation> VoteIdeation { get; set; }
        [Required]
        public virtual User User { get; set; }
    }
}