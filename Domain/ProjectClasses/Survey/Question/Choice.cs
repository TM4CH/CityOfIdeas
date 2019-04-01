using System.ComponentModel.DataAnnotations;

namespace Domain.Project
{
    public class Choice
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
    }
}