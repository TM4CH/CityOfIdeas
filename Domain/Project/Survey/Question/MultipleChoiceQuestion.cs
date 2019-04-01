using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Project
{
    public class MultipleChoiceQuestion : Question
    {
        [Required] public virtual ICollection<Choice> Choices { get; set; }
        [Required] public Boolean SingleChoice { get; set; }
        
    }
}