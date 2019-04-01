using System.Collections.Generic;
using Domain.Project.Phase;

namespace DAL.IProject.IPhase
{
    public interface IPhaseSurveyRepository
    {
        /*
         *     CRUD PhaseSurvey
         */
        
        //Create Methods
        PhaseSurvey CreatePhaseSurvey(PhaseSurvey phaseSurvey);
        
        //Read Methods
        IEnumerable<PhaseSurvey> ReadPhaseSurvey();
        PhaseSurvey ReadPhaseSurvey(string id);
        
        //Update Methods
        void UpdatePhaseSurvey(PhaseSurvey phaseSurvey);
        
        //Delete Methods
        void DeletePhaseSurvey(string id);
    }
}