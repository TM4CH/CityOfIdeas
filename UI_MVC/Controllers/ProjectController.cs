using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.InterfaceManagers.IPlatformManagers;
using BL.InterfaceManagers.IProjectManagers;
using BL.Managers;
using Domain;
using Domain.Project;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI_MVC.Models;

namespace UI_MVC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectManager _projectManager;
        private readonly UserManager<User> _userManager;
        private readonly IPlatformManager _platformManager;

        public ProjectController(UserManager<User> userManager)
        {
            _projectManager = new ProjectManager();
            _platformManager = new PlatformManager();
            _userManager = userManager;
        }
        public IActionResult Index()
        {

            return View();
        }
        //CREATE project
        public async Task<IActionResult> CreateProject(ProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                //DIT GEBRUIKEN VANAF PAGINA AF IS
                //var user = await _userManager.GetUserAsync(User);

                //Test ophalen admin
                var user = await _userManager.FindByEmailAsync("admin@localhost");
                var platform = user.Platform.Id;
                _projectManager.AddProject(
                    model.Title,
                    model.Location,
                    model.Content,
                    model.StartDate,
                    model.EndDate,
                    user,
                     user.Platform
                    );
                return View();


            }
            return View();
        }
        //GET projects
        public IActionResult GetProject(string id)
        {
            return View(_projectManager.GetProject(id));
        }

        public IActionResult GetAllProjects()
        {
            Console.WriteLine(_projectManager.GetAllProjects());
            return View(_projectManager.GetAllProjects());
        }

        //EDIT project KAN VARIEREN DUS ZEKER NOG NAKIJKEN
        public IActionResult EditProject(string id, ProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                _projectManager.SetProject(
                    id,
                    model.Title,
                    model.Location,
                    model.Content,
                    model.StartDate,
                    model.EndDate
                  );
            }
            return View();
        }

        //DELETE project
        public IActionResult DeleteProject(string id)
        {
            _projectManager.RemoveProject(id);
            return View();

        }
    }
}