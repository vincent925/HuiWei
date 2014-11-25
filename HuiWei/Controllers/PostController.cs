using Domain.System.Service;
using HuiWei.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWei.Controllers
{
    public class PostController : BaseController
    {
        ArticleService a = new ArticleService();
        //
        // GET: /Post/
        public ActionResult Add()
        {
            return View();
        }
         [HttpPost]
         [ValidateInput(false)]
        public ActionResult Add(PostModel postModel)
        {
            a.CreateArticle(postModel.Title, postModel.PContent, this.CurrentUser.UserId);
            return RedirectToAction("Index", "Home");
        }
	}
}