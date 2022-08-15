using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDa userda = new UserDa();
        public bool LoginUser(string user, string pass) { 
        return userda.Login(user,pass);
       }
    }
}
