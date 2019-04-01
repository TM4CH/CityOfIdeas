using Domain;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace DAL.EF
{
    public class UserDataInitializer
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedUsers(UserManager<User> userManager)
        {
            CreateUser("super", "Superadmin", userManager);
            CreateUser("admin", "Administrator", userManager);
            CreateUser("mod", "Moderator", userManager);
            CreateUser("user", "User", userManager);
            CreateUser("userVer", "UserVerified", userManager);
            CreateUser("userOrg", "UserOrganisation", userManager);
        }

        public static void SeedRoles(RoleManager<Role> roleManager)
        {
            CreatRole("Superadmin", roleManager);
            CreatRole("Administrator", roleManager);
            CreatRole("Moderator", roleManager);
            CreatRole("User", roleManager);
            CreatRole("UserVerified", roleManager);
            CreatRole("UserOrganisation", roleManager);
        }

        private static void CreateUser(string name, string role,UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync(name).Result == null)
            {
                User user = new User
                {
                    UserName = name + "@localhost",
                    Email = name + "@localhost"
                };

                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                name = textInfo.ToTitleCase(name);

                IdentityResult result = userManager.CreateAsync
                (user, name + "123.").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role).Wait();
                }
            }
        }

        private static void CreatRole(string roles, RoleManager<Role> roleManager)
        {
            if (!roleManager.RoleExistsAsync(roles).Result)
            {
                Role role = new Role
                {
                    Name = roles
                };

                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
    }
}
