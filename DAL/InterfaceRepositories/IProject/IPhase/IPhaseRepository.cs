using System.Collections.Generic;
using Domain.Project;
using Domain.Project.Phase;

namespace DAL.IProject.IPhase
{
    public interface IPhaseRepository
    {
        /*
         *     CRUD Phase
         */
        
        //Create Methods
        Phase CreatePhase(Phase phase);
        
        //Read Methods
        IEnumerable<Phase> ReadPhase();
        Phase ReadPhase(string id);
        
        //Update Methods
        void UpdatePhase(Phase phase);
        
        //Delete Methods
        void DeletePhase(string id);
    }
}