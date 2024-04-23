using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group11_FinaalProject
{
    public partial class Greyson_Problem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n))
            {
                Solution solution = new Solution();
                string result = solution.CountAndSay(n);
                lblResult.Text = result;
            }
            else
            {
                lblResult.Text = "Invalid input: Please enter a valid integer value.";
            }
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n <= 0)
                return "";
            string result = "1";
            for (int i = 1; i < n; i++)
            {
                result = Say(result);
            }
            return result;
        }

        private string Say(string str)
        {
            string result = "";
            int count = 1;
            char digit = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == digit)
                {
                    count++;
                }
                else
                {
                    result += count.ToString() + digit;
                    count = 1;
                    digit = str[i];
                }
            }
            result += count.ToString() + digit;
            return result;
        }
    }

} 



