using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionApp
{
    public class Account
    {
        protected string email;
        private string password;
        public Role accountRole;

        public Account(String email, String password, Role name)
        {
            this.email = email;
            this.password = password;
            this.accountRole = name;
        }
    }
}
