using System.Collections.Generic;
using Domain.ProjectClasses.AnswerClasses;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IAnswerRepository
    {
        /*
         *     CRUD Answer
         */
        
        //Create Methods
        void CreateAnswer(Answer answer);
        
        //Read Methods
        IEnumerable<Answer> ReadAllAnswers();
        Answer ReadAnswer(string id);
        
        //Update Methods
        void UpdateAnswer(Answer answer);
        
        //Delete Methods
        void DeleteAnswer(string id);
    }
}