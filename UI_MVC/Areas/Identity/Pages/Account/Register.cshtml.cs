using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Domain;
using Domain.UserClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace UI_MVC.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<RegisterModel> _logger;

        public RegisterModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "UserName")]
            public string UserName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [MaxLength(100)]
            [Display(Name = "Street")]
            public string Street { get; set; }

            [MaxLength(5)]
            [Display(Name = "House Number")]
            public string HouseNumber { get; set; }

            [MaxLength(12)]
            [Display(Name = "Zipcode")]
            public string Zipcode { get; set; }

            [MaxLength(30)]
            [Display(Name = "City")]
            public string City { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new User { UserName = Input.UserName, Email = Input.Email, Adress = new Adress() { Street = Input.Street, City = Input.City, HouseNumber = Input.HouseNumber, Zipcode = Input.Zipcode } };

                var usercheck = await _userManager.FindByEmailAsync(Input.Email);

                var checkemail = true;
                if (usercheck != null)
                {
                    ModelState.AddModelError(string.Empty, "Email is already used.");
                    checkemail = false;
                }

                if (checkemail)
                {
                    var result = await _userManager.CreateAsync(user, Input.Password);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created a new account with password.");

                        _userManager.AddToRoleAsync(user,
                             "User").Wait();

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
                        var body = new StringBuilder();
                        body.AppendFormat("Hello, {0}\n", user.UserName);
                        body.AppendLine(@"Your KAUH Account about to activate click the link below to complete the actination process");
                        body.AppendLine("<a href=\"ctokenlink\">login</a>");
                        mail.Body = body.ToString();


                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("tomenilias@gmail.com", "bsLdV6%vefkgz&YxcYdLx5SQ5G9m@E");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);

                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("SendEmailConfirmation", "Account", new { id = user.Id });
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
