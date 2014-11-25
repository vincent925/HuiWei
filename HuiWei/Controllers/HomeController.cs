using Domain.System.Core;
using Domain.System.Service;
using HuiWei.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWei.Controllers
{
    public class HomeController : BaseController
    {
        NewsService n = new NewsService();
        ArticleService a = new ArticleService();
        public ActionResult Index()
        {
            IList<Article> articles=a.SearchArticles();
            PostModel p = new PostModel();
            p.Articles = articles;
            return View(p);
        }

        public ActionResult About()
        {
            NewViewModel nvm = new NewViewModel();
            nvm.News = n.SearchNews();
            return View(nvm);
        }
    }
}