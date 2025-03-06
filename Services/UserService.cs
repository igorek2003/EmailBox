using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailBox.Services
{
        public class UserService : IUserService
        {
            
            private static Dictionary<string, (string Name, string Password)> _users = new Dictionary<string, (string Name, string Password)>();

            public string SignUp(string email, string name, string password)
            {
                if (_users.ContainsKey(email))
                {
                    return null;  
                }

              
                _users[email] = (name, password);  
                return email;
            }

            public bool Login(string email, string password)
            {
                if (_users.ContainsKey(email))
                {
                 
                    return _users[email].Password == password;  
                }
                return false;
            }
        }
    
}
