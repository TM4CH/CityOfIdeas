using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.ISurvey
{
    public interface ISurveyRepository
    {
        /*
         *     CRUD Survey
         */
            
        //Create Methods
        Survey CreateSurvey(Survey survey);
        
        //Read Methods
        IEnumerable<Survey> ReadSurvey();
        Survey ReadSurvey(string id);
        
        //Update Methods
        void UpdateSurvey(Survey survey);
        
        //Delete Methods
        void DeleteSurvey(string id);        
    }
}