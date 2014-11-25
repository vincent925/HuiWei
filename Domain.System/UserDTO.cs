using Domain.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System
{
    public class UserDTO
    {
        public bool Result { get; set; }
        public string Msg { get; set; }
        public User user { get; set; }
    }
}
