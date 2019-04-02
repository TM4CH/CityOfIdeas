using System.Collections.Generic;
using Domain.Project;
using Domain.ProjectClasses;

namespace DAL.IProject.ISurvey
{
    public interface ISurveyRepository
    {
        /*
         *     CRUD Survey
         */
            
        //Create Methods
        void CreateSurvey(Survey survey);
        
        //Read Methods
        IEnumerable<Survey> ReadAllSurveys();
        Survey ReadSurvey(string id);
        
        //Update Methods
        void UpdateSurvey(Survey survey);
        
        //Delete Methods
        void DeleteSurvey(string id);        
    }
}