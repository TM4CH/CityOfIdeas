using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.IdeationClasses
{
    public class Tag
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
    }
}