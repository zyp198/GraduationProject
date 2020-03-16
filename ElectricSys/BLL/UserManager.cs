using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ElectricSys.IBLL;
using ElectricSys.Entity;
using ElectricSys.IDAL;
using ElectricSys.DAL;
using System.Data.Entity;

namespace ElectricSys.BLL
{
    public class UserManager : IUserManager
    {

        public async Task ChagePassword(string username, string oldPwd, string newPwd)
        {
          
        }

        public async Task ChangeUserInformation(string username, string telephone, bool sex)
        {
            throw new NotImplementedException();
        }

        public async Task<user> GetUserByUserID(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password, out Guid userid)
        {
            using (IUserService userSvc = new UserService())
            {
                var user = userSvc.GetAllAsync().FirstOrDefaultAsync(m => m.user_name == username && m.user_password == password);
                user.Wait();
                var data = user.Result;
                if (data == null)
                {
                    userid = new Guid();
                    return false;
                }
                else
                {
                    userid = data.user_id;
                    return true;
                }

            }
        }
    }
}