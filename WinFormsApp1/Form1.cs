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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // รับค่าจาก TextBox 1 และ TextBox 2
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);

            // ทำการคำนวณ
            double result = value1 * value2;

            // แสดงผลลัพธ์ใน Label หรือ TextBox ที่คุณต้องการ
            resultLabel.Text = "ผลคูณ: " + result.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}