using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        MathPro math = new MathPro();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_FirstNumber.Text);
            int num2 = Convert.ToInt32(txt_SecondNumber.Text);
            int equals = math.plus(num1, num2);
            lbl_Result.Text = equals.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(txt_FirstNumber.Text);
            int num2=Convert.ToInt32(txt_SecondNumber.Text);
            int equals = math.minus(num1, num2);
            lbl_Result.Text = equals.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_FirstNumber.Text);
            int num2 = Convert.ToInt32(txt_SecondNumber.Text);
            int equals = math.times(num1, num2);
            lbl_Result.Text = equals.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_FirstNumber.Text);
            int num2 = Convert.ToInt32(txt_SecondNumber.Text);
            int equals = math.divide(num1, num2);
            lbl_Result.Text = equals.ToString();
        }
    }
}
