
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.IdeationClasses
{
    public class PropertyEnabled
    {
        [Key] public string Id { get; set; }
        [Required] public string Value { get; set; }
        [Required] public Boolean Enabled { get; set; }

        public PropertyEnabled(string value, bool enabled)
        {
            Value = value;
            Enabled = enabled;
        }
    }
}