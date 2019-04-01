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
        void CreateIdeation(Ideation ideation);
        
        //Read Methods
        IEnumerable<Ideation> ReadAllIdeations();
        Ideation ReadIdeation(string id);
        
        //Update Methods
        void UpdateIdeation(Ideation ideation);
        
        //Delete Methods
        void DeleteIdeation(string id);
    }
}