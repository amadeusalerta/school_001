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
        public int antepnut_kcal = 75;

        public double grand_total=0;

        public double total_price=0;
        public double current_price=0;
        public double total_calories=0;
        public double amount_of_order;
        public double order_price;
        public string name_of_additions;

        public ListViewItem newItem = new ListViewItem();

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

        private void button1_Click(object sender, EventArgs e)
        {
            grand_total = grand_total + total_price;
            textBox5.Text = grand_total.ToString();

            if (radioButton1.Checked)
            { newItem.SubItems.Add("Diet"); }
            else if (radioButton2.Checked)
            { newItem.SubItems.Add("Low Fat"); }
            else if (radioButton3.Checked)
            { newItem.SubItems.Add("Fat"); }

            newItem.SubItems.Add(name_of_additions);

            if (radioButton4.Checked)
            {
                newItem.SubItems.Add("Peanut");
            }

            if (radioButton5.Checked)
            {
                newItem.SubItems.Add("Hazelnut");
            }

            if (radioButton6.Checked)
            {
                newItem.SubItems.Add("Antepnut");
            }

            newItem.SubItems.Add(textBox3.Text);
            newItem.SubItems.Add(textBox4.Text);
            newItem.SubItems.Add(numericUpDown5.Value.ToString());
            newItem.SubItems.Add(textBox6.Text);

            listView1.Items.Add(newItem);

            button2.Enabled = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();


            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            listView1.Items.Clear();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
            if (groupBox4.Enabled = true)
            {
                button1.Enabled=true;
            }
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
            if (radioButton2.Checked)
            {
                groupBox3.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox3.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.Text = total_price.ToString();
                textBox4.Text = total_calories.ToString();
                textBox6.Text = order_price.ToString();
            }

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

                piece_of_lemon = (int)numericUpDown1.Value;
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

            if (radioButton4.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + peanut_kcal;
                order_price = total_price * amount_of_order;

            }

            if (radioButton5.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + hazenut_kcal; ;
                order_price = total_price * amount_of_order;
            }

            if (radioButton6.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + antepnut_kcal;
                order_price = (total_price) * (amount_of_order);
            }

            textBox3.Text = total_price.ToString();
            textBox4.Text = total_calories.ToString();
            textBox6.Text = order_price.ToString();
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox3.Text = total_price.ToString();
                textBox4.Text = total_calories.ToString();
                textBox6.Text = order_price.ToString();
            }

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

                piece_of_lemon = (int)numericUpDown1.Value;
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

            if (radioButton4.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + peanut_kcal;
                order_price = total_price * amount_of_order;

            }

            if (radioButton5.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + hazenut_kcal; ;
                order_price = total_price * amount_of_order;
            }

            if (radioButton6.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + antepnut_kcal;
                order_price = (total_price) * (amount_of_order);
            }

            textBox3.Text = total_price.ToString();
            textBox4.Text = total_calories.ToString();
            textBox6.Text = order_price.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                textBox3.Text = total_price.ToString();
                textBox4.Text = total_calories.ToString();
                textBox6.Text = order_price.ToString();
            }

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

                piece_of_lemon = (int)numericUpDown1.Value;
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

            if (radioButton4.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + peanut_kcal;
                order_price = total_price * amount_of_order;

            }

            if (radioButton5.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + hazenut_kcal; ;
                order_price = total_price * amount_of_order;
            }

            if (radioButton6.Checked)
            {
                total_calories = (piece_of_lemon * lemon_calories) + (piece_of_banana * banana_calories) + (piece_of_straw * straw_calories) + (piece_of_choco * choco_calories);
                total_price = (piece_of_lemon * lemon_price) + (piece_of_banana * banana_price) + (piece_of_straw * straw_price) + (piece_of_choco * choco_price);
                total_calories = total_calories + antepnut_kcal;
                order_price = (total_price) * (amount_of_order);
            }

            textBox3.Text = total_price.ToString();
            textBox4.Text = total_calories.ToString();
            textBox6.Text = order_price.ToString();

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.GetItemChecked(0)) 
            {
                pictureBox1.Image = imageList1.Images[0];
                numericUpDown1.Enabled = true;
                name_of_additions = (name_of_additions+"L");
            }

            if (checkedListBox1.GetItemChecked(1))
            {
                pictureBox2.Image = imageList1.Images[1];
                numericUpDown2.Enabled = true;
                name_of_additions = (name_of_additions + "B");
            }

            if (checkedListBox1.GetItemChecked(2))
            {
                pictureBox3.Image = imageList1.Images[2];
                numericUpDown3.Enabled = true;
                name_of_additions = (name_of_additions + "S");
            }

            if (checkedListBox1.GetItemChecked(3))
            {
                pictureBox4.Image = imageList1.Images[3];
                numericUpDown4.Enabled = true;
                name_of_additions = (name_of_additions + "C");
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

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            amount_of_order = (int)numericUpDown5.Value;
            order_price = total_price * amount_of_order;
            textBox6.Text = order_price.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
