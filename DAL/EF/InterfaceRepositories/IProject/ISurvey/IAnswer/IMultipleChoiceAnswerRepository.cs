using System.Collections.Generic;
using Domain.ProjectClasses.SurveyClasses.AnswerClasses;

namespace DAL.IProject.ISurvey.IAnswer
{
    public interface IMultipleChoiceAnswerRepository
    {
        /*
         *     CRUD ChoiceAnswer
         */
        
        //Create Methods
        void CreateMultipleChoiceAnswer(MultipleChoiceAnswer multipleChoiceAnswer);
        
        //Read Methods
        IEnumerable<MultipleChoiceAnswer> ReadAllMultipleChoiceAnswers();
        ChoiceAnswer ReadMultipleChoiceAnswer(string id);
        
        //Update Methods
        void UpdateMultipleChoiceAnswer(MultipleChoiceAnswer multipleChoiceAnswer);
        
        //Delete Methods
        void DeleteMultipleChoiceAnswer(string id);        
    }
}