using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace FitnessCentreSite.Models
{
    public class CustomUserStore : IUserStore<AppUser>
    {
        static readonly List<AppUser> Users = new List<AppUser>();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(AppUser User)
        {
            return Task.Factory.StartNew(() => Users.Add(User));
        }

        public Task UpdateAsync(AppUser User)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(AppUser user)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> FindByNameAsync(string userName)
        {
            return Task<AppUser>.Factory.StartNew(() => Users.FirstOrDefault(u => u.UserName == userName));
        }

    }
}