using System.ComponentModel.DataAnnotations;
using Domain.ProjectClasses.SurveyClasses.QuestionClasses;
using Domain.UserClasses;

namespace Domain.ProjectClasses.SurveyClasses.AnswerClasses
{
    public class Answer
    {
        [Key] public string Id { get; set; }
        [Required] public virtual Question Question { get; set; }
        [Required] public virtual User User { get; set; }
    }
}