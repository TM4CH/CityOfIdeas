using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.ISurvey.IQuestion
{
    public interface IQuestionRepository
    {
        /*
         *     CRUD Question
         */
            
        //Create Methods
        Question CreateQuestion(Question question);
        
        //Read Methods
        IEnumerable<Question> ReadQuestion();
        Question ReadQuestion(string id);
        
        //Update Methods
        void UpdateQuestion(Question question);
        
        //Delete Methods
        void DeleteQuestion(string id);  
    }
}