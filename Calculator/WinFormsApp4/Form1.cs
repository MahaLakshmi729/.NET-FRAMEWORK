using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter the value: ";
            int no1 = int.Parse(textBox1.Text);
            int no2 = int.Parse(textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "result of addition";
            int no1 = int.Parse(textBox1.Text);
            int no2 = int.Parse(textBox2.Text);
            int ans = no1 + no2;
            textBox3.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "result of subtraction";
            int no1 = int.Parse(textBox1.Text);
            int no2 = int.Parse(textBox2.Text);
            int ans = no1 - no2;
            textBox3.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "result of multiplication";
            int no1 = int.Parse(textBox1.Text);
            int no2 = int.Parse(textBox2.Text);
            int ans = no1 * no2;
            textBox3.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "result of division";
            int no1 = int.Parse(textBox1.Text);
            int no2 = int.Parse(textBox2.Text);
            int ans = no1 / no2;
            textBox3.Text = ans.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}