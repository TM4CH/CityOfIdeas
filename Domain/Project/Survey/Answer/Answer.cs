using System.ComponentModel.DataAnnotations;

namespace Domain.Project.Answer
{
    public class Answer
    {
        [Key] public string Id { get; set; }
        [Required] public virtual Question Question { get; set; }
        [Required] public virtual User.User User { get; set; }
    }
}