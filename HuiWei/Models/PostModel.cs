using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuiWei.Models
{
    public class PostModel
    {
        public string Title { get; set; }
        public string PContent { get; set; }
        public IList<Article> Articles { get; set; }
    }
}