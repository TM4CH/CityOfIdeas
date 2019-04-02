using System.Collections.Generic;
using Domain.ProjectClasses.PhaseClasses;

namespace DAL.IProject.IPhase
{
    public interface IPhaseSurveyRepository
    {
        /*
         *     CRUD PhaseSurvey
         */
        
        //Create Methods
        void CreatePhaseSurvey(PhaseSurvey phaseSurvey);
        
        //Read Methods
        IEnumerable<PhaseSurvey> ReadAllPhaseSurveys();
        PhaseSurvey ReadPhaseSurvey(string id);
        
        //Update Methods
        void UpdatePhaseSurvey(PhaseSurvey phaseSurvey);
        
        //Delete Methods
        void DeletePhaseSurvey(string id);
    }
}