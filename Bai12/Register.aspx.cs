using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["member"] != null)
                Response.Redirect("/");
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            string nickName = Request.Form.Get("nickname");
            string color = Request.Form.Get("color");
            Member member = new Member(nickName, color);

            List<Member> members = (List<Member>)Application["members"];
            if (members == null)
                members = new List<Member>();
            members.Add(member);
            Application["members"] = members;

            Session.Add("member", member);
            Response.Redirect("/");
        }
    }
}