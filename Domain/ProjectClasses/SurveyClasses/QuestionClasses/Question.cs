using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.SurveyClasses.QuestionClasses
{
    public class Question
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
    }
}