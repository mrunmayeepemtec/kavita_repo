using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcWebApplication1Framework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(firstText.Text.ToString());
            double y = double.Parse(lastText.Text.ToString());
            double res = x + y;
            resultText.Text = res.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            double x = double.Parse(firstText.Text.ToString());
            double y = double.Parse(lastText.Text.ToString());
            double res = x - y;
            resultText.Text = res.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            double x = double.Parse(firstText.Text.ToString());
            double y = double.Parse(lastText.Text.ToString());
            double res = x * y;
            resultText.Text = res.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            double x = double.Parse(firstText.Text.ToString());
            double y = double.Parse(lastText.Text.ToString());
            double res = x / y;
            resultText.Text = res.ToString();
        }
    }
}