using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.System.Service;
using Domain.System.Core;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        ArticleService a=new ArticleService();
        ReplyService r = new ReplyService();
        [TestMethod]
        public void TestMethod1()
        {
            Reply reply = r.CreateReply("1111",3,2);
           IList<Article> articles= a.SearchArticles();
           foreach (var item in articles)
           {
               
           }
        }

        [TestMethod]
        public void GetArticle()
        {
            Article articles = a.GetArticle(2);
            ICollection<Reply> Replys = articles.Replys;

        }
    }
}
