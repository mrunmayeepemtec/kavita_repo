using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System;
using Calc1;

namespace CalcWebAppFramework
{
    public partial class Calculator1WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void textBox_TextChanged(object sender, EventArgs e)
        //{

        //}



        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    int operand1 = int.Parse(textBox1.Text);
        //    int operand2 = int.Parse(textBox3.Text);
        //    int operation = textBox2.Text.ToCharArray()[0];

        //    int result = 0;

        //    calc operations = new calc();

        //    switch (operation)
        //    {
        //        case '+':
        //            result = operations.Add(operand1, operand2);
        //            break;
        //        case '-':
        //            result = operations.Subtract(operand1, operand2);
        //            break;
        //        case '*':
        //            result = operations.Multiply(operand1, operand2);
        //            break;
        //        case '/':
        //            result = operations.Divide(operand1, operand2);
        //            break;
        //    }
        //    textBox4.Text = result.ToString();   
        //}

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            calc operations = new calc();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Add(x, y);
            resultText.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calc operations = new calc();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Subtract(x, y);
            resultText.Text = res.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            calc operations = new calc();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Multiply(x, y);
            resultText.Text = res.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            calc operations = new calc();
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int res = operations.Divide(x, y);
            resultText.Text = res.ToString();

        }

        //protected void Button4_Click(object sender, EventArgs e)
        //{

        //}
    }
}