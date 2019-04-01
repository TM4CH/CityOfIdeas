using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.ISurvey.IQuestion
{
    public interface IMultipleChoiceQuestionRepository
    {
        /*
         *     CRUD MultipleChoiceQuestion
         */
            
        //Create Methods
        void CreateMultipleChoiceQuestion(MultipleChoiceQuestion multipleChoiceQuestion);
        
        //Read Methods
        IEnumerable<MultipleChoiceQuestion> ReadAllMultipleChoiceQuestions();
        MultipleChoiceQuestion ReadMultipleChoiceQuestion(string id);
        
        //Update Methods
        void UpdateMultipleChoiceQuestion(MultipleChoiceQuestion multipleChoiceQuestion);
        
        //Delete Methods
        void DeleteMultipleChoiceQuestion(string id);  
    }
}