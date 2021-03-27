using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12
{
    public class Member
    {
        public string NickName { get; set; }
        public string Color { get; set; }

        public Member() { }
        public Member(string nickname, string color)
        {
            NickName = nickname;
            Color = color;
        }
    }
}