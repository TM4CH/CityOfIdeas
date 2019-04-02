using System.Collections.Generic;
using Domain.Project;
using Domain.ProjectClasses;

namespace DAL.IProject
{
    public interface IProjectRepository
    {
        /*
         *     CRUD Project
         */
        
        //Create Methods
        void CreateProject(Project project);
        
        //Read Methods
        IEnumerable<Project> ReadAllProjects();
        Project ReadProject(string id);
        
        //Update Methods
        void UpdateProject(Project ticket);
        
        //Delete Methods
        void DeleteProject(string id);
    }
}
