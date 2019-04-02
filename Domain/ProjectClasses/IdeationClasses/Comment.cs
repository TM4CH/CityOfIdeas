using Domain.UserClasses;
using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.IdeationClasses
{
    public class Comment
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
        [Required] public virtual Idea Idea { get; set; }
        [Required] public virtual User User { get; set; }
    }
}