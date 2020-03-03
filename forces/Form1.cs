using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }
  double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double cos(double x)
        {

            return (Math.Cos(x * Math.PI / 180.0));
        }

private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {//read txt box values 
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);

            //calculate fx and fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            //put values for Fx and Fy in labels 
            label1.Text = "Fx = " + Fx + "N";
            label2.Text = "Fy = " + Fy + "N";




        }
    }
}
 