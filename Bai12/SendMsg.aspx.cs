using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class SendMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member member = (Member)Session.Contents["member"];
            if (member == null)
                Response.Redirect("/Register.aspx");

            string message = Request.Unvalidated.Form.Get("message");
            Messager messager = new Messager(member, message, DateTime.Now);

            List<Messager> messagers = (List<Messager>)Application["messages"];

            if (messagers == null)
                messagers = new List<Messager>();

            messagers.Add(messager);

            Application["messages"] = messagers;

            Response.Redirect("/PostMsg.html");

        }
    }
}