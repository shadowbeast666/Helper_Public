using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Windows
{
    public class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Last_Login { get; set; }


        public string FullInfo
        {
            get
            {
                return $"{Id} { Login } {Password} { Email } { Role } { Last_Login }";
            }
        }
    }

}
