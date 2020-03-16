using ElectricSys.IDAL;
using ElectricSys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricSys.DAL
{
    public class UserService : BaseService<user>, IUserService
    {
        public UserService() : base(new ElectricSysContext())
        {
        }
    }
}