using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Core
{
    public class New
    {
        [Key]
        public Int64 NewId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDevelopment { get; set; }
        public DateTime CreateTime { get; set; }
    }
    public class EchoContext : DbContext
    {
        public EchoContext()
            : base("Echo365DB")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Reply> Replys { get; set; }
    }
}
