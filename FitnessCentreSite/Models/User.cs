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

        [Property]
        public virtual string UserName { get; set; }

        [Property]
        public virtual string PasswordHash { get; set; }

    }
}