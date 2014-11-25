using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Service
{
    public class ReplyService
    {
        private readonly EchoContext db = new EchoContext();
        public Reply CreateReply(string content, Int64 userId, Int64 articleID)
        {
            UserService u = new UserService();
            User user = u.GetUser(userId);
            Reply r = null;
            var Reply = new Reply { Content = content, UserName = user.UserName, CreateTime = DateTime.Now, ArticleID = articleID };
            r = Reply;
            db.Replys.Add(Reply);
            db.SaveChanges();
            return r;
        }
        public Reply GetReply(Int64 replyId)
        {
            Reply reply = null;
            var query = from b in db.Replys
                        where b.ReplyId == replyId
                        select b;
            reply = query.First();
            return reply;
        }
        //public IList<Article> SearchArticles()
        //{
        //    IList<Article> articles = null;
        //    using (var db = new EchoContext())
        //    {
        //        var query = from b in db.Articles
        //                    orderby b.CreateTime descending
        //                    select b;
        //        articles = query.ToList<Article>();
        //    }
        //    return articles;
        //}
    }
}
