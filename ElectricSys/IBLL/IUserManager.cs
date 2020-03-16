using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricSys.Entity;

namespace ElectricSys.IBLL
{
   public  interface IUserManager
    {
        bool Login(string username, string password, out Guid userid);
        Task ChagePassword(string username, string oldPwd, string newPwd);
        Task ChangeUserInformation(string username, string telephone, bool sex);
        Task <user> GetUserByUserID(Guid id);
    }
}
