using ElectricSys.BLL;
using ElectricSys.IBLL;
using ElectricSys.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ElectricSys.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
       [HttpPost]
        public ActionResult GetInfoUser(string username, string password,bool IsRemembered=false) {
            IUserManager userManager = new UserManager();
            Guid userid = new Guid();
            if (username=="root"&&password=="root")
            {
                if (IsRemembered)
                {
                    Response.Cookies.Add(new HttpCookie("loginName")
                    {
                        Value = username,
                        Expires = DateTime.Now.AddDays(7)
                    });
                    Response.Cookies.Add(new HttpCookie("userId")
                    {
                        Value = userid.ToString(),
                        Expires = DateTime.Now.AddDays(7)
                    });
                }
                else
                {
                    Session["loginName"] = username;
                    Session["userid"] = userid;
                }
                return RedirectToAction(nameof(Index));
            }
            else {
                return Content("用户名或者密码错误");
            }
        }
          public ActionResult Index() {
            return View();
         }
    }   
   }
