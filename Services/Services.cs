using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailBox.Services
{
    public interface IUserService
    {
        string SignUp(string email, string name, string password); 
        bool Login(string email, string password); 
    }

}
