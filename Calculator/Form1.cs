namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double results = 0.0;

        public Form1()
        {
            InitializeComponent();
        }


        private void zero_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "0";
            this.result.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "1";
            this.result.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "2";
            this.result.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "3";
            this.result.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "4";
            this.result.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "5";
            this.result.Text += input;
        }

        private void sixe_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "6";
            this.result.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "7";
            this.result.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "8";
            this.result.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            input += "9";
            this.result.Text += input;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void multi_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                results = num1 + num2;
                result.Text = results.ToString();
            }
            else if (operation == '-')
            {
                results = num1 - num2;
                result.Text = results.ToString();
            }
            else if (operation == '*')
            {
                results = num1 * num2;
                result.Text = results.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    results = num1 / num2;
                    result.Text = results.ToString();
                }
                else
                {
                    result.Text = "Div/Zero!";
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            this.input = "";
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
