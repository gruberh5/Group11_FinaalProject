using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group11_FinaalProject
{
    public partial class Henry_Problem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class Solution
        {
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
        }

    }

    }