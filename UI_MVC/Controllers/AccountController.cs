using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Domain;
using Domain.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }

        public async Task<IActionResult> SendEmailConfirmation(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            string ctoken = _userManager.GenerateEmailConfirmationTokenAsync(user).Result;
            string ctokenlink = Url.Action("ConfirmEmail", "Account", new
            {
                userId = user.Id,
                token = ctoken
            }, protocol: HttpContext.Request.Scheme);

            MailMessage mail = new MailMessage();
            System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("tomenilias@gmail.com");
            mail.To.Add(user.Email);
            mail.Subject = "Verification Mail";
            mail.Body = "Please click here " + ctokenlink + " to verify!";


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("tomenilias@gmail.com", "bsLdV6%vefkgz&YxcYdLx5SQ5G9m@E");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            return View();
        }
    }
}