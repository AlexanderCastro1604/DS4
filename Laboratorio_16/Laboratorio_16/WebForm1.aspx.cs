using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b1.Text;
            }
            else
                tf.Text = tf.Text + b1.Text;
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b2.Text;
            }
            else
                tf.Text = tf.Text + b2.Text;
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b3.Text;
            }
            else
                tf.Text = tf.Text + b3.Text;
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b4.Text;
            }
            else
                tf.Text = tf.Text + b4.Text;
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b5.Text;
            }
            else
                tf.Text = tf.Text + b5.Text;
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b6.Text;
            }
            else
                tf.Text = tf.Text + b6.Text;
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b7.Text;
            }
            else
                tf.Text = tf.Text + b7.Text;
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b8.Text;
            }
            else
                tf.Text = tf.Text + b8.Text;
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b9.Text;
            }
            else
                tf.Text = tf.Text + b9.Text;
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            if ((tf.Text == "+") || (tf.Text == "-") || (tf.Text == "*") || (tf.Text == "/"))
            {
                tf.Text = "";
                tf.Text = tf.Text + b0.Text;
            }
            else
                tf.Text = tf.Text + b0.Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tf.Text))
            {
                a = float.Parse(tf.Text);
                tf.Text = "";
                b = '+';
                tf.Text += b;
            }
        }

        protected void sub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tf.Text))
            {
                a = float.Parse(tf.Text);
                tf.Text = "";
                b = '-';
                tf.Text += b;
            }
        }

        protected void mul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tf.Text))
            {
                a = float.Parse(tf.Text);
                tf.Text = "";
                b = '*';
                tf.Text += b;
            }
        }

        protected void div_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tf.Text))
            {
                a = float.Parse(tf.Text);
                tf.Text = "";
                b = '/';
                tf.Text += b;
            }
        }

        protected void eql_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tf.Text))
            {
                c = float.Parse(tf.Text);
                tf.Text = "";
                if (b == '/')
                {
                    if (c != 0)
                    {
                        d = a / c;
                        tf.Text = d.ToString();
                        a = d;
                    }
                    else
                    {
                        tf.Text = "Error: División por cero";
                    }
                }
                else if (b == '*')
                {
                    d = a * c;
                    tf.Text = d.ToString();
                    a = d;
                }
                else if (b == '-')
                {
                    d = a - c;
                    tf.Text = d.ToString();
                    a = d;
                }
                else
                {
                    d = a + c;
                    tf.Text = d.ToString();
                    a = d;
                }
            }
        }

        protected void clr_Click(object sender, EventArgs e)
        {
            tf.Text = "";
            a = 0;
            c = 0;
            d = 0;
        }
    }
}