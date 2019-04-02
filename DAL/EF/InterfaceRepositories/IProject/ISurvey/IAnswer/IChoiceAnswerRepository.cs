using System.Collections.Generic;
using Domain.ProjectClasses.AnswerClasses;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IChoiceAnswerRepository
    {
        /*
         *     CRUD ChoiceAnswer
         */
        
        //Create Methods
        void CreateChoiceAnswer(ChoiceAnswer choiceAnswer);
        
        //Read Methods
        IEnumerable<ChoiceAnswer> ReadAllChoiceAnswers();
        ChoiceAnswer ReadChoiceAnswer(string id);
        
        //Update Methods
        void UpdateChoiceAnswer(ChoiceAnswer choiceAnswer);
        
        //Delete Methods
        void DeleteChoiceAnswer(string id);
    }
}