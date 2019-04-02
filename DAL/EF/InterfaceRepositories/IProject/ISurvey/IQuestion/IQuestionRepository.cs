using System.Collections.Generic;
using Domain.ProjectClasses;
using Domain.ProjectClasses.SurveyClasses.QuestionClasses;

namespace DAL.IProject.ISurvey.IQuestion
{
    public interface IQuestionRepository
    {
        /*
         *     CRUD Question
         */
            
        //Create Methods
        void CreateQuestion(Question question);
        
        //Read Methods
        IEnumerable<Question> ReadAllQuestions();
        Question ReadQuestion(string id);
        
        //Update Methods
        void UpdateQuestion(Question question);
        
        //Delete Methods
        void DeleteQuestion(string id);  
    }
}