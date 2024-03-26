using Microsoft.AspNetCore.Identity;

namespace Blogy.WebUI.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        //override the default error messages
        public override IdentityError PasswordTooShort ( int length )
        {
            return new IdentityError() 
            { 
                Code = "PasswordTooShort", 
                Description = "Passwords must be at least 6 characters."
            };   
        }
        public override IdentityError PasswordRequiresUpper ()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Passwords must have at least one uppercase ('A'-'Z')."
            };
        }
        public override IdentityError PasswordRequiresLower ()
        {
            return new IdentityError()
            {
                Code = "passwordRequiresLower",
                Description = "Passwords must have at least one lowercase ('a'-'z')."
            };
        }
        public override IdentityError PasswordRequiresDigit ()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Passwords must have at least one digit ('0'-'9')."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric ()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Passwords must have at least one non alphanumeric character."
            };
        }


    }
}
