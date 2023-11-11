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

        // L/B/S/C

        public int[] calories_of_diets = { 115,175,135,235};
        public int[] calories_of_low_fats = { 125, 325, 225, 340 };
        public int[] calories_of_fats = { 175, 365, 280, 400 };

        public double[] price_of_diets = { 0.25,0.55,0.75,0.80};
        public double[] price_of_low_fats = { 0.35, 0.65,0.85,0.90};
        public double[] price_of_fats = { 0.40,0.80,0.85,1 };

        public int piece_of_lemon;
        public int piece_of_banana;
        public int piece_of_straw;
        public int piece_of_choco;

        public double lemon_price;
        public double lemon_calories;
        public double banana_price;
        public double banana_calories;
        public double straw_price;
        public double straw_calories;
        public double choco_price;
        public double choco_calories;



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

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

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

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainManager(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                lemon_calories = calories_of_diets[0];
                straw_calories = calories_of_diets[1];
                banana_calories = calories_of_diets[2];
                choco_calories = calories_of_diets[3];

                lemon_price = price_of_diets[0];
                straw_price = price_of_diets[1];
                banana_price = price_of_diets[2];
                choco_price = price_of_diets[3];

                piece_of_lemon =(int)numericUpDown1.Value;
                piece_of_banana = (int)numericUpDown2.Value;
                piece_of_straw = (int)numericUpDown3.Value;
                piece_of_choco = (int)numericUpDown4.Value;
            }

            if (radioButton2.Checked)
            {
                lemon_calories = calories_of_low_fats[0];
                straw_calories = calories_of_low_fats[1];
                banana_calories = calories_of_low_fats[2];
                choco_calories = calories_of_low_fats[3];

                lemon_price = price_of_low_fats[0];
                straw_price = price_of_low_fats[1];
                banana_price = price_of_low_fats[2];
                choco_price = price_of_low_fats[3];

                piece_of_lemon = (int)numericUpDown1.Value;
                piece_of_banana = (int)numericUpDown2.Value;
                piece_of_straw = (int)numericUpDown3.Value;
                piece_of_choco = (int)numericUpDown4.Value;


            }

            if (radioButton3.Checked)
            {
                lemon_calories = calories_of_fats[0];
                straw_calories = calories_of_fats[1];
                banana_calories = calories_of_fats[2];
                choco_calories = calories_of_fats[3];

                lemon_price = price_of_fats[0];
                straw_price = price_of_fats[1];
                banana_price = price_of_fats[2];
                choco_price = price_of_fats[3];

                piece_of_lemon = (int)numericUpDown1.Value;
                piece_of_banana = (int)numericUpDown2.Value;
                piece_of_straw = (int)numericUpDown3.Value;
                piece_of_choco = (int)numericUpDown4.Value;
            }

            total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana *banana_calories ) + (piece_of_straw *straw_calories ) + (piece_of_choco * choco_calories);
            total_price=(piece_of_lemon*lemon_price)+(piece_of_banana*banana_price)+(piece_of_straw*straw_price)+(piece_of_choco*choco_price);

            if (radioButton4.Checked)
            {
                total_calories = total_calories + (peanut_kcal*piece_of_banana) + (peanut_kcal * piece_of_lemon) + (peanut_kcal * piece_of_straw) + (peanut_kcal * piece_of_choco);
            }

            if (radioButton4.Checked)
            {
                total_calories = total_calories + (hazenut_kcal * piece_of_banana) + (hazenut_kcal * piece_of_lemon) + (hazenut_kcal * piece_of_straw) + (hazenut_kcal * piece_of_choco);
            }

            if (radioButton4.Checked)
            {
                total_calories = total_calories + (anteplnut_kcal * piece_of_banana) + (anteplnut_kcal * piece_of_lemon) + (anteplnut_kcal * piece_of_straw) + (anteplnut_kcal * piece_of_choco);
            }

            textBox3.Text = total_price.ToString();
            textBox4.Text=total_calories.ToString();
        }

    }
}
