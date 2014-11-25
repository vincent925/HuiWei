using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System.Service
{
    public class UserService
    {
        public bool CreateUser(string userName, string passWord, string email)
        {
            using (var db = new EchoContext())
            {
                var user = new User { UserName = userName, PassWord = passWord, Email = email, CreateTime = DateTime.Now };
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
        }

        public User GetUser(Int64 userId)
        {
            using (var db = new EchoContext())
            {
                var query = from b in db.Users
                            where b.UserId == userId
                            select b;
                return query.First();
            }
        }

        public UserDTO Login(string userName,string passWord)
        {
            User user = null;
            UserDTO ud = new UserDTO();
            using (var db = new EchoContext())
            {
                var query = from b in db.Users
                            where b.UserName == userName
                            select b;
                if (query.Count()!=0)
                {
                    user = query.First();
                }
            }
            if (user==null)
            {
                ud.Result = false;
                ud.Msg = "用户不存在";
            }
            else if (Commond.Help.Sha256(user.PassWord) == Commond.Help.Sha256(passWord))
            {
                ud.Result = true;
                ud.Msg = "登陆成功";
                ud.user = user;
            }
            else if (Commond.Help.Sha256(user.PassWord) != Commond.Help.Sha256(passWord))
            {
                ud.Result = false;
                ud.Msg = "密码错误";
            }
            else
            {
                ud.Result = false;
                ud.Msg = "系统错误";
            }
            return ud;
        }
    }
}
