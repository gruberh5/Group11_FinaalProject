using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// Name: Henry Gruber
/// email: gruberhw@mail.uc.edu
/// Assignment Title: Final Project
/// Due Date: 4/22/2024
/// Course: IS 3050
/// Semester/Year: Spring 
/// Brief Description: This project displays our use of github, ASPX and C#
/// Citations: ChatGPT
/// Anything else that's relevant: StackOverFlow

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