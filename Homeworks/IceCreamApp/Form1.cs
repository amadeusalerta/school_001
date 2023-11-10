using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int peanut_kcal = 30;
        public int hazenut_kcal = 45;
        public int anteplnut_kcal = 75;
        public double total_price=0;
        public double current_price=0;
        public double total_calories=0;
        public double current_calories = 0;

        public int[] calories_of_diets = { 115,175,135,235};
        public int[] calories_of_low_fats = { 125, 325, 225, 340 };
        public int[] calories_of_fats = { 175, 365, 280, 400 };

        public double[] price_of_diets = { 0.25,0.55,0.75,0.80};
        public double[] price_of_low_fats = { 0.35, 0.65,0.85,0.90};
        public double[] price_of_fats = { 0.40,0.80,0.85,1 };



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1 != null && textBox2!=null )
            {
                groupBox2.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled =true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox3.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                current_calories = current_calories + peanut_kcal;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                current_calories = current_calories + hazenut_kcal;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                current_calories = current_calories + anteplnut_kcal;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0)) 
            {
                numericUpDown1.Enabled = true;
            }

            if (checkedListBox1.GetItemChecked(1))
            {
                numericUpDown2.Enabled = true;
            }

            if (checkedListBox1.GetItemChecked(2))
            {
                numericUpDown3.Enabled = true;
            }

            if (checkedListBox1.GetItemChecked(3))
            {
                numericUpDown4.Enabled = true;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 0)
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value != 0)
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value != 0)
            {
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            current_calories = Convert.ToDouble(textBox3.Text);
            textBox3.Text = current_calories.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
