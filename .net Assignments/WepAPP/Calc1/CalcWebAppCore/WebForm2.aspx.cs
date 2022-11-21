using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Calc2;
using Calc3;

namespace CalcWebAppCore
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //calc2 operations = new calc2();
            calc3 operations = new calc3();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Add(x, y);
            resultText.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //calc2 operations = new calc2();
            calc3 operations = new calc3();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Subtract(x, y);
            resultText.Text = res.ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //calc2 operations = new calc2();
            calc3 operations = new calc3();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Multiply(x, y);
            resultText.Text = res.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //calc2 operations = new calc2();
            calc3 operations = new calc3();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Divide(x, y);
            resultText.Text = res.ToString();
        }
    }
}