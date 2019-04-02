using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.ProjectClasses.SurveyClasses;

namespace Domain.ProjectClasses.SurveyClasses.QuestionClasses
{
    public class MultipleChoiceQuestion : Question
    {
        [Required] public virtual ICollection<Choice> Choices { get; set; }
        [Required] public bool SingleChoice { get; set; }
        
    }
}