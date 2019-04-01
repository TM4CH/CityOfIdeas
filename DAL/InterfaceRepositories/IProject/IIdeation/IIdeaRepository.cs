using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject.IIdeation
{
    public interface IIdeaRepository
    {
        /*
         *     CRUD Idea
         */
        
        //Create Methods
        Idea CreateIdea(Idea idea);
        
        //Read Methods
        IEnumerable<Idea> ReadIdea();
        Idea ReadIdea(string id);
        
        //Update Methods
        void UpdateIdea(Idea idea);
        
        //Delete Methods
        void DeleteIdea(string id);
    }
}