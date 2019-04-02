using System.Collections.Generic;
using Domain.ProjectClasses.IdeationClasses;

namespace DAL.IProject.IIdeation
{
    public interface IIdeaRepository
    {
        /*
         *     CRUD Idea
         */
        
        //Create Methods
        void CreateIdea(Idea idea);
        
        //Read Methods
        IEnumerable<Idea> ReadAllIdeas();
        Idea ReadIdea(string id);
        
        //Update Methods
        void UpdateIdea(Idea idea);
        
        //Delete Methods
        void DeleteIdea(string id);
    }
}