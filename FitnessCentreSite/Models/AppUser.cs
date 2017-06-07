using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Security.Cryptography;
using System.Text;

namespace FitnessCentreSite.Models
{
    public class AppUser : IUser
    {
        public string Id { get; private set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public byte[] password;

        SHA256 sha = SHA256.Create();

        public AppUser(string name, string pass)
        {
            Id = Guid.NewGuid().ToString();
            UserName = name;
            password = sha.ComputeHash(Encoding.ASCII.GetBytes(pass));
        }
    }

    //    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //    {
    //        public ApplicationDbContext()
    //            : base("DefaultConnection", throwIfV1Schema: false)
    //        {
    //        }

    //        public static ApplicationDbContext Create()
    //        {
    //            return new ApplicationDbContext();
    //        }
    //    }
}