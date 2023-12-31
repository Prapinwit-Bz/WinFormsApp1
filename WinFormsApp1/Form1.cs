﻿using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Attach the TextChanged event handler to TextBox1 and TextBox2
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
#pragma warning disable CS8321 // Local function is declared but never used
            if (double.TryParse(textBox1.Text, out double distance))
            {
                // Calculate the cost based on the given distance
                double cost = CalculateFare(distance);

                // Update TextBox2 with the calculated cost
                textBox4.Text = cost.ToString(); // Display cost with 2 decimal places
            }
            static double CalculateFare(double distance)
            {
                if (distance <= 1)
                {
                    return 40.00;
                }
                else if (distance <= 10)
                {
                    return 40.00 + (distance - 1) * 6.50;
                }
                else if (distance <= 20)
                {
                    return 40.00 + 9 * 6.50 + (distance - 10) * 7.00;
                }
                else if (distance <= 40)
                {
                    return 40.00 + 9 * 6.50 + 10 * 7.00 + (distance - 20) * 8.00;
                }
                else if (distance <= 60)
                {
                    return 40.00 + 9 * 6.50 + 10 * 7.00 + 20 * 8.00 + (distance - 40) * 8.50;
                }
                else if (distance <= 80)
                {
                    return 40.00 + 9 * 6.50 + 10 * 7.00 + 20 * 8.00 + 20 * 8.50 + (distance - 60) * 9.00;
                }
                else
                {
                    return 40.00 + 9 * 6.50 + 10 * 7.00 + 20 * 8.00 + 20 * 8.50 + 20 * 9.00 + (distance - 80) * 10.50;
                }
            }
#pragma warning restore CS8321 // Local function is declared but never used
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
#pragma warning disable CS8321 // Local function is declared but never used
            if (double.TryParse(textBox2.Text, out double distance))
            {
                // Calculate the cost based on the given distance
                double cost2 = distance * 3;

                // Update TextBox2 with the calculated cost
                textBox5.Text = cost2.ToString(); // Display cost with 2 decimal places
            }
#pragma warning restore CS8321 // Local function is declared but never used
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // รับค่าจาก TextBox 1 และ TextBox 2
            double value1 = Convert.ToDouble(textBox4.Text);
            double value2 = Convert.ToDouble(textBox5.Text);

            // ทำการคำนวณ
            double result = value1 + value2;

            // แสดงผลลัพธ์ใน Label หรือ TextBox ที่คุณต้องการ
            textBox3.Text = "" + result.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}