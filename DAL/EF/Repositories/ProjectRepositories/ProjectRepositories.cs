using DAL.IProject;
using Domain.Project;
using Domain.ProjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EF.Repositories.ProjectRepositories
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

        //Create
        public void CreateProject(Project project)
        {
            _ctx.Projects.Update(project);    //Vragen aan knikkertje
            _ctx.SaveChanges();
        }

        //Read
        public IEnumerable<Project> ReadAllProjects()
        {
            return _ctx.Projects.AsEnumerable();
        }

        public Project ReadProject(string id)
        {
            return _ctx.Projects.Find(id);
        }

        //Update
        public void UpdateProject(Project project)
        {
            _ctx.Projects.Update(project);
            _ctx.SaveChanges();
        }

        //Delete
        public void DeleteProject(string id)
        {
            _ctx.Projects.Remove(ReadProject(id));
            _ctx.SaveChanges();
        }

        #endregion
    }
}
