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

        public class Solution
        {
            public string CountAndSay(int n)
            {
                string num = "1";

                for (int i = 0; i < n - 1; i++)
                {
                    Console.WriteLine(num);
                    num = word(num);
                }
                return num;
            }

            public string word(string num)
            {
                string ans = "";
                char current = num[0];
                int charCount = 0;
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == current)
                    {
                        charCount++;
                    }
                    else
                    {
                        ans += charCount.ToString() + current;
                        current = num[i];
                        charCount = 1;
                    }
                }
                ans += charCount.ToString() + current;
                return ans;
            }
        }
    }

}

        
