using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group11_FinaalProject
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmdDanny.Click += CmdDanny_Click;
            cmdGreyson.Click += CmdGreyson_Click;
            cmdHenry.Click += CmdHenry_Click;
        }
        protected void CmdDanny_Click(object sender, EventArgs e)
        {
            Response.Redirect("Danny_Problem.aspx");
        }

        protected void CmdGreyson_Click(object sender, EventArgs e)
        {
            Response.Redirect("Greyson_Problem.aspx");
        }

        protected void CmdHenry_Click(object sender, EventArgs e)
        {
            Response.Redirect("Henry_Problem.aspx");
        }
    }
}