using Domain.System;
using Domain.System.Service;
using HuiWei.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWei.Controllers
{
    public class AccountController : Controller
    {
        UserService u = new UserService();
        //
        // GET: /Account/
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            UserDTO userDTO = u.Login(loginModel.UserName, loginModel.PassWord);
            if (userDTO.Result)
            {
                HttpContext.Session["ss_User"] = userDTO.user;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", userDTO.Msg);
            }
            return View(loginModel);
        }
    }
}