using System.Collections.Generic;
using Domain.Project.Answer;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IMultipleChoiceAnswerRepository
    {
        /*
         *     CRUD ChoiceAnswer
         */
        
        //Create Methods
        MultipleChoiceAnswer CreateMultipleChoiceAnswer(MultipleChoiceAnswer multipleChoiceAnswer);
        
        //Read Methods
        IEnumerable<MultipleChoiceAnswer> ReadMultipleChoiceAnswer();
        ChoiceAnswer ReadMultipleChoiceAnswer(string id);
        
        //Update Methods
        void UpdateMultipleChoiceAnswer(MultipleChoiceAnswer multipleChoiceAnswer);
        
        //Delete Methods
        void DeleteMultipleChoiceAnswer(string id);        
    }
}