using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member member = (Member)Session.Contents["member"];
            if (member == null)
                Response.Redirect("/Register.aspx");

            List<Messager> messages = (List<Messager>)Application["messages"];
            if (messages == null)
                return;

            string html = "";

            // sap xep
            messages.Sort((m1, m2) =>
            {
                return (m1.timeStamp > m2.timeStamp) ? 1 : -1;
            });

            foreach(Messager message in messages)
            {
                string align = "left";
                string name = message.NickName;
                if (message.NickName == member.NickName)
                {
                    align = "right";
                    name = "";
                }
                html += @"<div class='messages' style='--align: " + align + @"'>
                            <span class='nick_name'>"
                                + name +
                            @"</span>
                            <p class='text_chat' style='--color: " + message.Color + "'>"
                                + Server.HtmlEncode(message.Message) +
                            @"</p>
                        </div>
                        <div class='clear'></div>";
            }
            listMessage.InnerHtml = html;
        }
    }
}