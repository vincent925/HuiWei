using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Service
{
    public class NewsService
    {
        public bool CreateNew(string title, string content, bool isDevelopment)
        {
            using (var db = new EchoContext())
            {
                var news = new New { Title = title, Content = content, IsDevelopment = isDevelopment, CreateTime = DateTime.Now };
                db.News.Add(news);
                db.SaveChanges();
                return true;
            }
        }

        public IList<New> SearchNews()
        {
            IList<New> news = null;
            using (var db = new EchoContext())
            {
                var query = from b in db.News
                            orderby b.CreateTime descending
                            select b;
                news = query.ToList<New>();
            }
            return news;
        }
    }
}
