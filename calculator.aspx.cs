using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculator
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1=Convert.ToDouble(TextBox1.Text);
            double num2=Convert.ToDouble(TextBox2.Text);
            double sum= num1+ num2;
            TextBox3.Text = sum.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double sub = num1 - num2;
            TextBox3.Text = sub.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double mul = num1 * num2;
            TextBox3.Text = mul.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double dev = num1 / num2;
            TextBox3.Text = dev.ToString();
        }
    }
}