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

        private void UpdateInput(string value)
        {
            this.result.Text = "";
            input += value;
            this.result.Text += input;
        }

        private void PerformCalculation()
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                results = num1 + num2;
            }
            else if (operation == '-')
            {
                results = num1 - num2;
            }
            else if (operation == '*')
            {
                results = num1 * num2;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    results = num1 / num2;
                }
                else
                {
                    result.Text = "Div/Zero!";
                    return;
                }
            }

            result.Text = results.ToString();
            operand1 = results.ToString();
            input = string.Empty;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            UpdateInput("0");
        }

        private void one_Click(object sender, EventArgs e)
        {
            UpdateInput("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            UpdateInput("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            UpdateInput("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            UpdateInput("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            UpdateInput("5");
        }

        private void sixe_Click(object sender, EventArgs e)
        {
            UpdateInput("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            UpdateInput("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            UpdateInput("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            UpdateInput("9");
        }

        private void dot_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!string.IsNullOrEmpty(operand1))
                {
                    PerformCalculation();
                }
                operand1 = input;
                operation = '/';
                input = string.Empty;
            }
        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!string.IsNullOrEmpty(operand1))
                {
                    PerformCalculation();
                }
                operand1 = input;
                operation = '*';
                input = string.Empty;
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!string.IsNullOrEmpty(operand1))
                {
                    PerformCalculation();
                }
                operand1 = input;
                operation = '-';
                input = string.Empty;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (!string.IsNullOrEmpty(operand1))
                {
                    PerformCalculation();
                }
                operand1 = input;
                operation = '+';
                input = string.Empty;
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input) && !string.IsNullOrEmpty(operand1))
            {
                PerformCalculation();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            this.input = "";
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.results = 0.0;
        }
    }
}
