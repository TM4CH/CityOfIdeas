using System.ComponentModel.DataAnnotations;
using Domain.Project;

namespace Domain.ProjectClasses.AnswerClasses
{
    public class Answer
    {
        [Key] public string Id { get; set; }
        [Required] public virtual Question Question { get; set; }
        [Required] public virtual User User { get; set; }
    }
}