using System.Collections.Generic;
using Domain.ProjectClasses.PhaseClasses;

namespace DAL.IProject.IPhase
{
    public interface IPhaseIdeationRepository
    {
        /*
         *     CRUD PhaseIdeation
         */
        
        //Create Methods
        void CreatePhaseIdeation(PhaseIdeation phaseIdeation);
        
        //Read Methods
        IEnumerable<PhaseIdeation> ReadAllPhaseIdeations();
        PhaseIdeation ReadPhaseIdeation(string id);
        
        //Update Methods
        void UpdatePhaseIdeation(PhaseIdeation phaseIdeation);
        
        //Delete Methods
        void DeletePhaseIdeation(string id);
    }
}