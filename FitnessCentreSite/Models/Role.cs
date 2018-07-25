using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.Attributes;
using Microsoft.AspNet.Identity;

namespace FitnessCentreSite.Models
{
    [Class(Table = "Roles")]
    public class Role : IRole<int>
    {
        [Id(0, Name = "Id")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; protected set; }

        [Property(Column ="RoleName")]
        public virtual string Name { get; set; }

        [Property]
        public virtual string ApplicationName { get; set; }

        [Bag(0, Table = "UsersInRoles", Inverse = true, Cascade = "save-update")]
        [Key(1, Column = "RolesId")]
        [ManyToMany(2, ClassType = typeof(User), Column = "UsersId")]
        public virtual IList<User> UsersInRole { get; set; }

        public Role()
        {
            UsersInRole = new List<User>();
        }
    }
}