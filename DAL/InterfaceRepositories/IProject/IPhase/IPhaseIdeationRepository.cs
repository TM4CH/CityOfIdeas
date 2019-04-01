using System.Collections.Generic;
using Domain.Project;
using Domain.Project.Phase;

namespace DAL.IProject.IPhase
{
    public interface IPhaseIdeationRepository
    {
        /*
         *     CRUD PhaseIdeation
         */
        
        //Create Methods
        PhaseIdeation CreatePhaseIdeation(PhaseIdeation phaseIdeation);
        
        //Read Methods
        IEnumerable<PhaseIdeation> ReadPhaseIdeation();
        PhaseIdeation ReadPhaseIdeation(string id);
        
        //Update Methods
        void UpdatePhaseIdeation(PhaseIdeation phaseIdeation);
        
        //Delete Methods
        void DeletePhaseIdeation(string id);
    }
}