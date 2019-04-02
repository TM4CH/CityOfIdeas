using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.ProjectClasses.SurveyClasses.AnswerClasses
{
    public class MultipleChoiceAnswer : Answer
    {
        [Required] public virtual ICollection<ChoiceAnswer> Answers { get; set; }
    }
}