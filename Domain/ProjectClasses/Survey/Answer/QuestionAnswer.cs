using System.ComponentModel.DataAnnotations;

namespace Domain.Project.Answer
{
    public class QuestionAnswer : Answer
    {
        [Required] public string Answer { get; set; }
    }
}