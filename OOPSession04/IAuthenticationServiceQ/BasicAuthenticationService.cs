using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSession04.IAuthenticationServiceQ
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string validUsername1 = "user1";
        private string validPassword1 = "password1";
        private string validRole1 = "admin";

        private string validUsername2 = "user2";
        private string validPassword2 = "password2";
        private string validRole2 = "user";
        public bool AuthenticateUser(string username, string password)
        {
            return (username == validUsername1 && password == validPassword1) ||
              (username == validUsername2 && password == validPassword2);
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == validUsername1)
            {
                return role == validRole1;
            }
            else if (username == validUsername2)
            {
                return role == validRole2;
            }
            return false;
        }
    }
}
