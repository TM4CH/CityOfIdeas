using System.Collections.Generic;
using Domain.ProjectClasses.AnswerClasses;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IQuestionAnswerRepository
    {
        /*
         *     CRUD ChoiceAnswer
         */
            
        //Create Methods
        void CreateQuestionAnswer(QuestionAnswer questionAnswer);
        
        //Read Methods
        IEnumerable<QuestionAnswer> ReadAllQuestionAnswers();
        QuestionAnswer ReadQuestionAnswer(string id);
        
        //Update Methods
        void UpdateQuestionAnswer(QuestionAnswer questionAnswer);
        
        //Delete Methods
        void DeleteQuestionAnswer(string id);  
    }
}