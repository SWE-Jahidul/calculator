using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, res;
        float count;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;

        }

        private void button15_Click(object sender, EventArgs e)//Addition button
        {
            try
            {
                num = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();//clear the text box 
                count = 1; //count store case 
                label1.Text = num.ToString() + "+"; //display text on lable
            }
            catch(Exception ex)
            {
                Console.WriteLine("ok");
                Console.ReadKey();

            }

        }

        private void button14_Click(object sender, EventArgs e) //multiplicaton
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();//clear the text box 
            count = 3; //count store case 
            label1.Text = num.ToString() + "*"; //display text on lable

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // compute(); // Complete should not be here.
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)//substraction button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();//clear the text box
            textBox1.Focus();
            count = 2; //count store case 
            label1.Text = num.ToString() + "-"; //display text on lable

        }

        private void button16_Click(object sender, EventArgs e) //division button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();//clear the text box 
            textBox1.Focus();
            count = 4; //count store case 
            label1.Text = num.ToString() + "/"; //display text on lable

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            compute();
        }

        public void compute()
        {
            switch(count)
            {

                case 1:
                     //exception here.... fixed at line. 119 and fixed at line 155 
                        res = num + float.Parse(textBox1.Text);
                        textBox1.Text = res.ToString();
                    break;
                case 2: 

                    res = num - float.Parse(textBox1.Text);
                    textBox1.Text = res.ToString();
                    break;
                case 3:

                    res = num * float.Parse(textBox1.Text);
                    textBox1.Text = res.ToString();
                    break;

                case 4:

                    res = num / float.Parse(textBox1.Text);
                    textBox1.Text = res.ToString();
                    break;

                   

            }
        }


    }
}
