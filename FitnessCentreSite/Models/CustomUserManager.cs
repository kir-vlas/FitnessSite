using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;


namespace FitnessCentreSite.Models
{
    public class CustomUserManager : UserManager<AppUser>
    {
        public CustomUserManager(CustomUserStore store)
            : base(store)
        {
            this.PasswordHasher = new CustomPasswordHasher();
        }

        public override Task<AppUser> FindAsync(string userName, string password)
        {
            Task<AppUser> taskInvoke = Task<AppUser>.Factory.StartNew(() =>
            {
                PasswordVerificationResult result = this.PasswordHasher.VerifyHashedPassword(userName, password);
                if (result == PasswordVerificationResult.SuccessRehashNeeded)
                {
                    return Store.FindByNameAsync(userName).Result;
                }
                return null;
            });
            return taskInvoke;
        }
    }

}