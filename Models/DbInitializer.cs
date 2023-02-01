using Microsoft.Win32;
using System.Linq;
using WebApplication35.Context;

namespace WebApplication35.Models
{
    public static class DbInitializer
    {
        public static void Initialize(RegistryContext context)
        { 
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User()
                {
                    Name = "Login1",
                    Password = "Password1",
                    Email = "user1@gmail.com",

                    ZipCode = 20000
                }
            };
            foreach (var user in users)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}
