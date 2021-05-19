using Flee.PublicTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static ExpressionContext context = new ExpressionContext();
        public Form1()
        {
            InitializeComponent();
            
            // Allow the expression to use all static public methods of System.Math
            context.Imports.AddType(typeof(Math));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "tan()";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "sqrt()";
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "sin()";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "F/S";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "F/q";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "cos()";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "1/tan()";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "q*E*d";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "U/R";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            error.Hide();
            try
            {
                IDynamicExpression eDynamic = context.CompileDynamic(question.Text);
                double result = (double)eDynamic.Evaluate();
                Answer.Text = result.ToString();
            }
            catch(Exception ee)
            {
                try
                {
                    DataTable dt = new DataTable();
                    var v = dt.Compute(question.Text, "");
                    Answer.Text = v.ToString();
                }
                catch(Exception es)
                {
                    error.Show();
                }
                
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "pi";
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "+";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "-";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "*";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "sqrt(a^2 + b^2 + c^2)";
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "^(-1)";
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "(1.60217662 * 10^-19)";
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "log(a,b)";
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "log(a,10)";
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "log(a,e)";
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            question.Text = question.Text + "e";
        }
    }
}
