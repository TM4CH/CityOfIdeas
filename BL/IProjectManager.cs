using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Project;

namespace BL
{
    public interface IProjectManager
    {
        #region project
        IEnumerable<Project> GetProjects();
        Project GetProject(string projectNumber);
        Project GetProjectWithIdeations(string projectNumber);
        Project AddProject(string titel, string preface, string text);

        void ChangeProject(Project ticket);
        void RemoveProject(string projectNumber);
        void Stem(string projectNumber);
        #endregion
    }
}
