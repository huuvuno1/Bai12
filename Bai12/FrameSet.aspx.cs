using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai12
{
    public partial class FrameSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member member = (Member)Session["member"];
            if (member == null)
                Response.Redirect("/Register.aspx");
        }
    }
}