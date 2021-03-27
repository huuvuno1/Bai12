using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["member"] == null)
                Response.Redirect("/Register.aspx");
            List<Member> members = (List<Member>)Application["members"];
            if (members == null)
                return;
            string html = "";
            foreach (Member member in members)
            {
                html += @"<div class='member'>
                            <div class='name'>" + member.NickName + @"</div>
                            <div class='color' style='--color: " + member.Color + @"'></div>
                        </div>";
            }
            listMember.InnerHtml = html;
        }
    }
}