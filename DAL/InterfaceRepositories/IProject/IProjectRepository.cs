using System.Collections.Generic;
using Domain.Project;

namespace DAL.IProject
{
    public interface IProjectRepository
    {
        /*
         *     CRUD Project
         */
        
        //Create Methods
        Project CreateProject(Project project);
        
        //Read Methods
        IEnumerable<Project> ReadProjects();
        Project ReadProject(string id);
        
        //Update Methods
        void UpdateProject(Project ticket);
        
        //Delete Methods
        void DeleteProject(string id);
    }
}
