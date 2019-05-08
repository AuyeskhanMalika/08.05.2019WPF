using Services;
using System.Data.Entity;

namespace DataAccess
{
    public class DataInitializer : DropCreateDatabaseAlways<SecurityContext>
    {
        protected override void Seed(SecurityContext context)
        {
            context.Users.Add(new Models.User
            {
                Login = "admin",
                Password = DataEncryptor.HashPassword("123")
            });
        }
    }
}
