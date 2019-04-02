using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.SurveyClasses.AnswerClasses
{
    public class QuestionAnswer : Answer
    {
        [Required] public string Answer { get; set; }
    }
}