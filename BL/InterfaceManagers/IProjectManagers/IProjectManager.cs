using System;
using System.Collections.Generic;
using Domain;
using Domain.PlatformClasses;
using Domain.ProjectClasses;
using Domain.UserClasses;

namespace BL.InterfaceManagers.IProjectManagers
{
    public interface IProjectManager
    {
        /*
         *     CRUD Project
         */
        //Create Methods
        void AddProject(
            string title,
            string location,
            string content,
            DateTime startDate,
            DateTime endDate,
            User user,
            Platform platform
            );

        //Read Methods
        IEnumerable<Project> GetAllProjects();
        Project GetProject(string id);

        //Update Methods
        void SetProject(
            string id,
            string title,
            string location,
            string content,
            DateTime startDate,
            DateTime endDate);

        //Delete Methods
        void RemoveProject(string id);
    }
}