using System.Collections.Generic;
using Domain.Project.Answer;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IChoiceAnswerRepository
    {
        /*
         *     CRUD ChoiceAnswer
         */
        
        //Create Methods
        ChoiceAnswer CreateChoiceAnswer(ChoiceAnswer choiceAnswer);
        
        //Read Methods
        IEnumerable<ChoiceAnswer> ReadChoiceAnswer();
        ChoiceAnswer ReadChoiceAnswer(string id);
        
        //Update Methods
        void UpdateChoiceAnswer(ChoiceAnswer choiceAnswer);
        
        //Delete Methods
        void DeleteChoiceAnswer(string id);
    }
}