using System.Diagnostics.CodeAnalysis;

namespace calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string operation = "";
        bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOperationClicked == true)
            {
                textBox1.Clear();
                isOperationClicked = false;

            }
            textBox1.Text = textBox1.Text + "1";
        }
        private void Number_Click(object sender, EventArgs e)
        {
            if (isOperationClicked == true)
            {
                textBox1.Clear();
                isOperationClicked = false;
            }

            Button btn = (Button)sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "+";
            isOperationClicked = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "-";
            isOperationClicked = true;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "*";
            isOperationClicked = true;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "/";
            isOperationClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(textBox1.Text);
            double result = 0;
            if (operation == "+")
            {
                result = num1 + num2;
            }
            else if (operation == "-")
            {
                result = num1 - num2;
            }
            else if (operation == "*")
            {
                result = num1 * num2;
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    MessageBox.Show("Division by zero is not possible!");
                    return;
                }
            }
            textBox1.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            operation = "";
        }
    }
}
