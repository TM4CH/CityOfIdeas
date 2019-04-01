using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.EF;
using DAL.IProject;
using Domain;
using Domain.Project;

namespace BL
{
    public class ProjectManager : IProjectManager
    {
        private readonly IProjectRepository repo;

        public ProjectManager()
        {
            repo = new ProjectRepository();
        }

        public Project AddProject(string titel, string preface, string text)
        {
            throw new NotImplementedException();
        }

        public void ChangeProject(Project ticket)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(string projectNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetProjects()
        {
            throw new NotImplementedException();
        }

        public Project GetProjectWithIdeations(string projectNumber)
        {
            throw new NotImplementedException();
        }

        public void RemoveProject(string projectNumber)
        {
            throw new NotImplementedException();
        }

        public void Stem(string projectNumber)
        {
            throw new NotImplementedException();
        }
    }
}
