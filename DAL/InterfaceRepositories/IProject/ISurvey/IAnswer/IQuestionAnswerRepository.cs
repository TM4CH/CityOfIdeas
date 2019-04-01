using System.Collections.Generic;
using Domain.Project.Answer;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IQuestionAnswerRepository
    {
        /*
         *     CRUD ChoiceAnswer
         */
            
        //Create Methods
        QuestionAnswer CreateQuestionAnswer(QuestionAnswer questionAnswer);
        
        //Read Methods
        IEnumerable<QuestionAnswer> ReadQuestionAnswer();
        QuestionAnswer ReadQuestionAnswer(string id);
        
        //Update Methods
        void UpdateQuestionAnswer(QuestionAnswer questionAnswer);
        
        //Delete Methods
        void DeleteQuestionAnswer(string id);  
    }
}