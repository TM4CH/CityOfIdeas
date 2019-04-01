using System.ComponentModel.DataAnnotations;

namespace Domain.Project.Answer
{
    public class ChoiceAnswer
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
    }
}