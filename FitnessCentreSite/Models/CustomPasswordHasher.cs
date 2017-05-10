using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;


namespace FitnessCentreSite.Models
{
    public class CustomPasswordHasher : PasswordHasher
    {
        public override string HashPassword(string password)
        {
            return base.HashPassword(password);
        }

        public override PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            if (hashedPassword.Equals(providedPassword))
            {
                return PasswordVerificationResult.Success;
            }
            else
            {
                return PasswordVerificationResult.Failed;
            }
        }

    }
}