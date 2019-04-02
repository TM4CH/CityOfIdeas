using BL.InterfaceManagers.IProjectManagers;
using DAL.EF.Repositories.ProjectRepositories;
using DAL.IProject;
using Domain.PlatformClasses;
using Domain.ProjectClasses;
using Domain.UserClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Managers
{
    public class ProjectManager : IProjectManager
    {
        private readonly IProjectRepository _repo;

        public ProjectManager()
        {
            _repo = new ProjectRepository();
        }

        #region CRUD

        /*
         *     CRUD Project
         */

        //Add Methods
        public void AddProject(
            string title,
            string location,
            string content,
            DateTime startDate,
            DateTime endDate,
            User user,
            Platform platform)
        {
            _repo.CreateProject(
                new Project()
                {
                    Title = title,
                    Location = location,
                    Content = content,
                    StartDate = startDate,
                    EndDate = endDate,
                    User = user,
                    Platform = platform
                });

        }

        //Get Methods
        public IEnumerable<Project> GetAllProjects()
        {
            return _repo.ReadAllProjects();
        }

        public Project GetProject(string id)
        {
            return _repo.ReadProject(id);
        }

        //Set Methods
        public void SetProject(
            string id,
            string title,
            string location,
            string content,
            DateTime startDate,
            DateTime endDate)
        {
            Project project = GetProject(id);
            project.Title = title;
            project.Location = location;
            project.Content = content;
            project.StartDate = startDate;
            project.EndDate = endDate;

            _repo.UpdateProject(project);

        }

        //Remove Methods
        public void RemoveProject(string id)
        {
            _repo.DeleteProject(id);
        }

        #endregion
    }
}
