using System.Collections.Generic;
using Domain.ProjectClasses.PhaseClasses;

namespace DAL.IProject.IPhase
{
    public interface IPhaseRepository
    {
        /*
         *     CRUD Phase
         */
        
        //Create Methods
        void CreatePhase(Phase phase);
        
        //Read Methods
        IEnumerable<Phase> ReadAllPhases();
        Phase ReadPhase(string id);
        
        //Update Methods
        void UpdatePhase(Phase phase);
        
        //Delete Methods
        void DeletePhase(string id);
    }
}