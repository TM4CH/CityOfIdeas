using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.AnswerClasses
{
    public class QuestionAnswer : Answer
    {
        [Required] public string Answer { get; set; }
    }
}