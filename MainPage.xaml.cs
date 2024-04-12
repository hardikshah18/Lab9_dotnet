namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        string currentNumber = string.Empty;
        string operation = string.Empty;
        double firstNumber = 0;
        double secondNumber = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void NumberButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentNumber += button.Text;
            DisplayLabel.Text = currentNumber;
        }
        private void OperationButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = double.Parse(currentNumber);
            currentNumber = string.Empty;

            DisplayLabel.Text = $"{firstNumber} {operation}";
        }

        private void EqualsButton_Clicked(object sender, EventArgs e)
        {
            secondNumber = double.Parse(currentNumber);
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                        DisplayLabel.Text = "Error";
                    break;
            }
            DisplayLabel.Text = $"{result}";
            currentNumber = result.ToString();

            operation = string.Empty;
        }



        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            currentNumber = string.Empty;
            operation = string.Empty;
            firstNumber = 0;
            secondNumber = 0;
            DisplayLabel.Text = "0";
        }
    }
}
