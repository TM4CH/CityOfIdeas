using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.IIdeation
{
    public interface IIdeationRepository
    {
        /*
         *     CRUD Ideation
         */
        
        //Create Methods
        Ideation CreateIdeation(Ideation ideation);
        
        //Read Methods
        IEnumerable<Ideation> ReadIdeation();
        Ideation ReadIdeation(string id);
        
        //Update Methods
        void UpdateIdeation(Ideation ideation);
        
        //Delete Methods
        void DeleteIdeation(string id);
    }
}