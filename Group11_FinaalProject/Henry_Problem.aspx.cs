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
    public partial class Henry_Problem : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void txtHeights_TextChanged(object sender, EventArgs e)
        {
            string[] heightStrings = txtHeights.Text.Split(',');
            int[] heights = Array.ConvertAll(heightStrings, int.Parse);
            int[] answer = CanSeePersonsCount(heights);
            lblOutput.Text = "Number of people each person can see to their right: " + string.Join(", ", answer);
        }

        public int[] CanSeePersonsCount(int[] heights)
        {
            int[] ans = new int[heights.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < heights.Length; i++)
            {
                int height = heights[i];
                while (stack.Count != 0 && heights[stack.Peek()] <= height)
                {
                    ans[stack.Pop()] += 1;
                }
                if (stack.Count != 0)
                {
                    ans[stack.Peek()] += 1;
                }
                stack.Push(i);
            }
            return ans;
        }

        protected void cmdGenerate_Click(object sender, EventArgs e)
        {
            int[] heights = { 10, 6, 8, 5, 11, 9 }; // Example input
            int[] answer = CanSeePersonsCount(heights);
            lblOutput.Text = "Number of people each person can see to their right: " + string.Join(", ", answer);
        }
    }

}