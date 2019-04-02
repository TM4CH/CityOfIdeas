using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.SurveyClasses.AnswerClasses
{
    public class ChoiceAnswer
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
    }
}