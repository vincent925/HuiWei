using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWei.Controllers
{
    public class BaseController : Controller
    {
        //定义一个基类的UserInfo对象
        public User CurrentUser { get; set; }

        /// <summary>
        /// 重写基类在Action之前执行的方法
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            CurrentUser = Session["ss_User"] as User;

            //检验用户是否已经登录，如果登录则不执行，否则则执行下面的跳转代码
            //if (CurrentUser == null)
            //{
            //    Response.Redirect("/Account/Login");
            //}
        }
	}
}