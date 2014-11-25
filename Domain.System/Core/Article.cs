using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Core
{
    public class Article
    {
        [Key]
        public Int64 ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Reply> Replys { get; set; }
    }
}
