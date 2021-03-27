using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12
{
    public class Messager : Member
    {
        public string Message { get; set; }
        public DateTime timeStamp { get; set; }

        public Messager(Member member, string message, DateTime dateTime)
            : base (member.NickName, member.Color)
        {
            Message = message;
            timeStamp = dateTime;
        }

    }
}