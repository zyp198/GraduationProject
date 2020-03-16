using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectricSys.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }

        //参数的名称需要和表单的字段名称一致，这样系统便会直接赋值。
        public ActionResult GetUserInfo(string username, string password)
        {


            //为了方便演示，我们直接输出这两个值，表示我们已经拿到了数据
            return Content(username + "*****" + password);
        }
    }
}