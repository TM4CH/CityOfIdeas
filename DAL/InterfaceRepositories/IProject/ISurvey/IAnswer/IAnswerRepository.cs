using System.Collections.Generic;
using Domain.Project.Answer;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IAnswerRepository
    {
        /*
         *     CRUD Answer
         */
        
        //Create Methods
        Answer CreateAnswer(Answer answer);
        
        //Read Methods
        IEnumerable<Answer> ReadAnswer();
        Answer ReadAnswer(string id);
        
        //Update Methods
        void UpdateAnswer(Answer answer);
        
        //Delete Methods
        void DeleteAnswer(string id);
    }
}