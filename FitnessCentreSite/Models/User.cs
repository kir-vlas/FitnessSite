using Microsoft.AspNet.Identity;
using NHibernate.AspNet.Identity;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Models
{
    [Class(Table = "[User]")]
    public class User : IUser<int>
    {
        [Id(0, Name = "Id")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; protected set; }

        public User()
        {
            Roles = new List<Role>();
        }

        [Property]
        public virtual string UserName { get; set; }

        [Property]
        public virtual string PasswordHash { get; set; }

        [Property]
        public virtual string FirstName { get; set; }

        [Property]
        public virtual string LastName { get; set; }

        [Property]
        public virtual byte[] Photo { get; set; }

        [Property]
        public virtual string About { get; set; }

        [Bag(0, Table = "UsersInRoles", Cascade = "save-update")]
        [Key(1, Column = "UsersId")]
        [ManyToMany(2, ClassType = typeof(Role), Column = "RolesId")]
        public virtual IList<Role> Roles { get; set; }

        public virtual void AddRole(Role role)
        {
            role.UsersInRole.Add(this);
            Roles.Add(role);
        }

        public virtual void DeleteRole(Role role)
        {
            role.UsersInRole.Remove(this);
            Roles.Remove(role);
        }
    }
}