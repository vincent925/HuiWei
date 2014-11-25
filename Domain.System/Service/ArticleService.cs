using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Service
{
    public class ArticleService
    {
        private readonly EchoContext db = new EchoContext();
        public bool CreateArticle(string title, string content, Int64 userId)
        {
            UserService u = new UserService();
            User user = u.GetUser(userId);
            var Article = new Article { Title = title, Content = content, UserName = user.UserName, CreateTime = DateTime.Now };
            db.Articles.Add(Article);
            db.SaveChanges();
            return true;
        }
        public bool SaveArticle(Int64 articleId, Reply reply)
        {
            var article = db.Articles.FirstOrDefault(r => r.ArticleId == articleId);
            article.Replys.Add(reply);
            db.SaveChanges();
            return true;
        }
        public IList<Article> SearchArticles()
        {
            IList<Article> articles = null;
            var query = from b in db.Articles
                        orderby b.CreateTime descending
                        select b;
            articles = query.ToList<Article>();
            return articles;
        }

        public Article GetArticle(Int64 articleId)
        {
            var db = new EchoContext();
            var query = from b in db.Articles
                        where b.ArticleId == articleId
                        select b;
            return query.First<Article>();
        }
    }
}
