using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using NHibernate;
using System.Threading.Tasks;

namespace FitnessCentreSite.Models
{
    public class IdentityStore : IUserStore<User, int>,
        IUserRoleStore<User, int>,
        IRoleStore<Role,int>,
        IUserPasswordStore<User, int>,
        IUserLockoutStore<User, int>,
        IUserTwoFactorStore<User, int>
    {

        private static Task completedTask = Task.FromResult(false);
        private string _applicationName;
        private readonly ISession session;


        public string ApplicationName
        {
            get { return _applicationName; }
            set { _applicationName = value; }
        }

        public IdentityStore(ISession session)
        {
            ApplicationName = "FitnessCentreSite";
            this.session = session;
        }

        #region IUserStore<User, int>
        public Task CreateAsync(User user)
        {
            return Task.Run(() => 
            {
                try
                {
                    session.SaveOrUpdate(user);
                }
                catch(Exception ex) { }
            });
        }

        public Task DeleteAsync(User user)
        {
            return Task.Run(() => session.Delete(user));
        }

        public Task<User> FindByIdAsync(int userId)
        {
            return Task.Run(() => session.Get<User>(userId));
        }

        public Task<User> FindByNameAsync(string userName)
        {
            return Task.Run(() =>
            {
                return session.QueryOver<User>()
                    .Where(u => u.UserName == userName)
                    .SingleOrDefault();
            });
        }

        public Task UpdateAsync(User user)
        {
            return Task.Run(() => session.SaveOrUpdate(user));
        }
        #endregion

        #region IUserPasswordStore<User, int>
        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            return Task.Run(() => user.PasswordHash = passwordHash);
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(User user)
        {
            return Task.FromResult(true);
        }
        #endregion

        #region IUserLockoutStore<User, int>
        public Task<DateTimeOffset> GetLockoutEndDateAsync(User user)
        {
            return Task.FromResult(DateTimeOffset.MaxValue);
        }

        public Task SetLockoutEndDateAsync(User user, DateTimeOffset lockoutEnd)
        {
            return completedTask;
        }

        public Task<int> IncrementAccessFailedCountAsync(User user)
        {
            return Task.FromResult(0);
        }

        public Task ResetAccessFailedCountAsync(User user)
        {
            return completedTask;
        }

        public Task<int> GetAccessFailedCountAsync(User user)
        {
            return Task.FromResult(0);
        }

        public Task<bool> GetLockoutEnabledAsync(User user)
        {
            return Task.FromResult(false);
        }

        public Task SetLockoutEnabledAsync(User user, bool enabled)
        {
            return completedTask;
        }
        #endregion

        #region IUserTwoFactorStore<User, int>
        public Task SetTwoFactorEnabledAsync(User user, bool enabled)
        {
            return completedTask;
        }

        public Task<bool> GetTwoFactorEnabledAsync(User user)
        {
            return Task.FromResult(false);
        }
        #endregion

        #region IUserRoleStore<User,int>
        public Task AddToRoleAsync(User user, string roleName)
        {
            return Task.Run(() =>
            {
                User usr = usr = session.CreateCriteria(typeof(User))
                                            .Add(NHibernate.Criterion.Restrictions.Eq("Username", user.UserName))
                                            .Add(NHibernate.Criterion.Restrictions.Eq("ApplicationName", this.ApplicationName))
                                            .UniqueResult<User>();
                if (usr != null)
                {
                    Role role = session.CreateCriteria(typeof(Role))
                                            .Add(NHibernate.Criterion.Restrictions.Eq("RoleName", roleName))
                                            .Add(NHibernate.Criterion.Restrictions.Eq("ApplicationName", this.ApplicationName))
                                            .UniqueResult<Role>();
                    usr.AddRole(role);
                }
                session.SaveOrUpdate(usr);
            });
        }

        public Task CreateRoleAsync(string roleName)
        {
            return Task.Run(() =>
            {
                Role role = new Role();
                role.ApplicationName = this.ApplicationName;
                role.Name = roleName;
                session.Save(role);
            });
        }

        public Task RemoveFromRoleAsync(User user, string roleName)
        {
            return Task.Run(() =>
            {
                User usr = session.CreateCriteria(typeof(User))
                                .Add(NHibernate.Criterion.Restrictions.Eq("Username", user.UserName))
                                .Add(NHibernate.Criterion.Restrictions.Eq("ApplicationName", this.ApplicationName))
                                .UniqueResult<User>();
                var rolestodelete = new List<Role>();
                IList<Role> roles = usr.Roles;
                foreach (Role r in roles)
                {
                    if (r.Name.Equals(roleName))
                        rolestodelete.Add(r);
                }
                foreach (Role rd in rolestodelete)
                {
                    usr.DeleteRole(rd);
                }
                session.SaveOrUpdate(usr);
            });
        }

        public Task<IList<string>> GetRolesAsync(User user)
        {
            return Task.Run(() =>
            {
                Role role = session.CreateCriteria(typeof(Role))
                    .Add(NHibernate.Criterion.Restrictions.Eq("Name", "Client"))
                    .Add(NHibernate.Criterion.Restrictions.Eq("ApplicationName", this.ApplicationName))
                    .UniqueResult<Role>();
                IList<User> us = role.UsersInRole;
                IList<string> lst = new List<string>();
                lst.Add(role.Name);
                return lst;
            });
        }

        public Task<bool> IsInRoleAsync(User user, string roleName)
        {
            return Task.Run(() =>
            {
                bool userInRole = false;
                User usr = session.CreateCriteria(typeof(User))
                                        .Add(NHibernate.Criterion.Restrictions.Eq("Username", user.UserName))
                                        .Add(NHibernate.Criterion.Restrictions.Eq("ApplicationName", this.ApplicationName))
                                        .UniqueResult<User>();
                if (usr != null)
                {
                    IList<Role> usrrls = usr.Roles;
                    foreach (Role r in usrrls)
                    {
                        if (r.Name.Equals(roleName))
                        {
                            userInRole = true;
                            break;
                        }
                    }
                }
                return userInRole;
            });
        }

        #endregion

        #region IRoleStore<Role,int>
        public Task CreateAsync(Role role)
        {
            return Task.Run(() => session.SaveOrUpdate(role));
        }

        public Task UpdateAsync(Role role)
        {
            return Task.Run(() => session.SaveOrUpdate(role));
        }

        public Task DeleteAsync(Role role)
        {
            return Task.Run(() => session.Delete(role));
        }

        Task<Role> IRoleStore<Role, int>.FindByIdAsync(int roleId)
        {
            return Task.Run(() => session.Get<Role>(roleId));
        }

        Task<Role> IRoleStore<Role, int>.FindByNameAsync(string roleName)
        {
            return Task.Run(() =>
            {
                return session.QueryOver<Role>()
                    .Where(u => u.Name == roleName)
                    .SingleOrDefault();
            });
        }
        #endregion

        public void Dispose()
        {
            //do nothing
        }

    }
}