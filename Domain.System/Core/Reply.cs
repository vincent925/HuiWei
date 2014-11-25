using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Core
{
    public class Reply
    {
        [Key]
        public Int64 ReplyId { get; set; }
        public Int64 ArticleID { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserName { get; set; }

        public virtual Article Article { get; set; }
    }
}
