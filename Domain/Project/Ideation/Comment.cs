using System.ComponentModel.DataAnnotations;

namespace Domain.Project
{
    public class Comment
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
        [Required] public virtual Idea Idea { get; set; }
        [Required] public virtual User.User User { get; set; }
    }
}