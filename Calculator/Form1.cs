namespace Calculator
{
    public partial class Form1 : Form
    {
        double number1;
        double number2;
        double result;
        char op;
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textCalc.Text += "2";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textCalc.Text += "1";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textCalc.Text += "3";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textCalc.Text += "4";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textCalc.Text += "5";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textCalc.Text += "6";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textCalc.Text += "7";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textCalc.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textCalc.Text += "9";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textCalc.Text += "0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textCalc.Text += ",";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textCalc.Text);
            op = '+';
            textCalc.Clear();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textCalc.Text);
            op = '-';
            textCalc.Clear();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textCalc.Text);
            op = '*';
            textCalc.Clear();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textCalc.Text);
            op = '/';
            textCalc.Clear();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textCalc.Clear();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textCalc.Text);
            switch (op)
            {
                case '+': result= number1 + number2; break;
                case '-': result= number1 - number2; break;
                case '*': result= number1 * number2; break;
                case '/': result= number1 / number2; break;
            }
            textCalc.Text= Convert.ToString(result);
        }
    }
}