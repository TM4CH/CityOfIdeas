using System;
using System.Collections.Generic;
using DAL.IProject;
using Domain.Project;

namespace DAL.EF
{
    public class ProjectRepository : IProjectRepository
    {
        //Fields
        private ApplicationDbContext _ctx;
        

        //Constructors
        public ProjectRepository()
        {
            _ctx = new ApplicationDbContext();
        }
        

        #region CRUD
        
        /*
         *     CRUD Project
         */
        
        //Create Methods
        public Project CreateProject(Project project)
        {
            throw new NotImplementedException();
        }

        //Read Methods
        public IEnumerable<Project> ReadProjects()
        {
            throw new NotImplementedException();
        }

        public Project ReadProject(string id)
        {
            throw new NotImplementedException();
        }

        //Update Methods
        public void UpdateProject(Project ticket)
        {
            throw new NotImplementedException();
        }

        //Delete Methods
        public void DeleteProject(string id)
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}
