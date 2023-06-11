using System.Windows.Forms;

namespace GT_ModernCalculator
{
    public partial class StandardCalculator : Form
    {
        //private ScienceCalculator scienceCalculatorForm;
        private bool isAnimating = false;
        private int targetWidth;
        private int currentWidth;
        private System.Windows.Forms.Timer animationTimer;
        private double currentResult = 0.0;
        private double previousNumber = 0.0;
        private string operation = "";
        private bool isOperationPerformed = false;
        private bool isModSelected = false;
        private bool switchingToAnotherForm = false;
        private bool isClosing = false;


        public StandardCalculator()
        {

            InitializeComponent();
            //scienceCalculatorForm = new ScienceCalculator();
            //Display App Product Version
            LabelVersionStandard.Text = "V." + ProductVersion + "-Release";
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 10; // Adjust this value to control the animation speed
            animationTimer.Tick += AnimationTimer_Tick;


        }
        //Switch between forms

        private void BtnScience_Click(object sender, EventArgs e)
        {
            // Create a new instance of the ScienceCalculator form
            ScienceCalculator scienceCalculatorForm = new ScienceCalculator();

            // Hide the current form
            this.Hide();

            // Show the ScienceCalculator form
            scienceCalculatorForm.ShowDialog();

            // Close the current form
            this.Close();
        }
        private void BtnTemperature_Click(object sender, EventArgs e)
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            this.Hide();

            temperatureConverter.ShowDialog();

            this.Close();
        }

        // Calculation function
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "." && TxtOut0.Text.Contains("."))
            {
                // Ignore multiple decimal points
                return;
            }

            if (operation == "Mod")
            {
                if (isOperationPerformed)
                {
                    TxtOut0.Clear();
                    isOperationPerformed = false;
                }

                TxtOut0.Text += button.Text;
                TxtOut1.Text += button.Text;
            }
            else
            {
                if (TxtOut0.Text == "0" || isOperationPerformed)
                {
                    TxtOut0.Clear();
                    isOperationPerformed = false;
                }

                TxtOut0.Text += button.Text;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;

            if (operation == "1/x")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0.Text, out currentNumber))
                {
                    if (currentNumber != 0)
                    {
                        currentNumber = 1 / currentNumber;
                        TxtOut0.Text = currentNumber.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        ClearAll();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            else if (operation == "x^2")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0.Text, out currentNumber))
                {
                    currentNumber = Math.Pow(currentNumber, 2);
                    TxtOut0.Text = currentNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            else if (operation == "√")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0.Text, out currentNumber))
                {
                    if (currentNumber >= 0)
                    {
                        currentNumber = Math.Sqrt(currentNumber);
                        TxtOut0.Text = currentNumber.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid input! Cannot take square root of a negative number.");
                        ClearAll();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            else
            {
                if (TxtOut1.Text.Length >= 2)
                {
                    TxtOut1.Text = TxtOut1.Text.Remove(TxtOut1.Text.Length - 2);
                }

                previousNumber = double.Parse(TxtOut0.Text);
                if (TxtOut1.Text == "0")
                {
                    TxtOut1.Text = "";
                }
                TxtOut1.Text += previousNumber.ToString() + " " + GetOperatorSymbol(operation) + " ";
                TxtOut0.Clear();
            }

            isOperationPerformed = true;
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOut1.Text) && !string.IsNullOrEmpty(TxtOut0.Text))
            {
                double firstOperand, secondOperand;
                string[] parts = TxtOut1.Text.Split(' ');

                if (double.TryParse(parts[0], out firstOperand) && double.TryParse(TxtOut0.Text, out secondOperand))
                {
                    double result;

                    switch (operation)
                    {
                        case "+":
                            result = firstOperand + secondOperand;
                            break;
                        case "-":
                            result = firstOperand - secondOperand;
                            break;
                        case "*":
                            result = firstOperand * secondOperand;
                            break;
                        case "/":
                            result = firstOperand / secondOperand;
                            break;
                        case "x^y":
                            result = Math.Pow(firstOperand, secondOperand);
                            break;
                        case "Mod":
                            result = firstOperand % secondOperand;
                            break;
                        default:
                            MessageBox.Show("Invalid operation!");
                            return;
                    }

                    TxtOut1.Text = "";
                    TxtOut0.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter valid numbers.");
                    ClearAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter both operands.");
                return;
            }

            isOperationPerformed = true;
        }

        private void OneOverXButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0.Text, out currentNumber))
            {
                if (currentNumber != 0)
                {
                    currentNumber = 1 / currentNumber;
                    TxtOut0.Text = currentNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero!");
                    ClearAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
                return;
            }
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0.Text, out currentNumber))
            {
                currentNumber = Math.Pow(currentNumber, 2);
                TxtOut0.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
                return;
            }
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0.Text, out currentNumber))
            {
                if (currentNumber >= 0)
                {
                    currentNumber = Math.Sqrt(currentNumber);
                    TxtOut0.Text = currentNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input! Cannot take square root of a negative number.");
                    ClearAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
                return;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            TxtOut0.Text = "0";
            //TxtOut1.Text = "0";
        }

        private void ClearAll()
        {
            TxtOut0.Text = "0";
            TxtOut1.Text = "0";
            currentResult = 0.0;
            previousNumber = 0.0;
            operation = "";
            isOperationPerformed = false;
        }
        private string GetOperatorSymbol(string operation)
        {
            switch (operation)
            {
                case "+":
                    return "+";
                case "-":
                    return "-";
                case "*":
                    return "×"; // Multiplication symbol
                case "/":
                    return "÷"; // Division symbol
                default:
                    return operation;
            }
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOut1.Text))
            {
                if (TxtOut1.Text.EndsWith(" "))
                {
                    TxtOut1.Text = TxtOut1.Text.Remove(TxtOut1.Text.Length - 3, 3);
                }
                else
                {
                    TxtOut1.Text = TxtOut1.Text.Remove(TxtOut1.Text.Length - 1, 1);
                }
            }
            else if (!string.IsNullOrEmpty(TxtOut0.Text))
            {
                if (TxtOut0.Text.Any(char.IsDigit))
                {
                    int lastIndex = TxtOut0.Text.LastIndexOfAny("0123456789".ToCharArray());
                    TxtOut0.Text = TxtOut0.Text.Remove(lastIndex, 1);
                }
                else
                {
                    TxtOut0.Text = "0";
                }
            }
        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0.Text, out currentNumber))
            {
                currentNumber = currentNumber / 100;
                TxtOut0.Text = currentNumber.ToString();
                TxtOut1.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
            }
        }
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0.Text, out currentNumber))
            {
                currentNumber *= -1;
                TxtOut0.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
            }
        }
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!TxtOut0.Text.Contains("."))
            {
                TxtOut0.Text += ".";
            }
        }

        //Sidebar Panel function
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (!isAnimating)
            {
                if (panelSidebarS.Visible)
                {
                    // Close the sidebar
                    StartSidebarAnimation(false);
                }
                else
                {
                    // Open the sidebar
                    panelSidebarS.Visible = true;
                    SubscribeButtonClickEvents();
                    SubscribeFormClickEvent();
                    StartSidebarAnimation(true);
                }
            }
        }
        private void SubscribeButtonClickEvents()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control != BtnMenu)
                    control.Click += CloseSidebarOnClick;
            }
        }
        private void SubscribeFormClickEvent()
        {
            this.Click += CloseSidebarOnClick;
        }
        private void CloseSidebarOnClick(object? sender, EventArgs e)
        {
            panelSidebarS.Visible = false;
            UnsubscribeEvents();
        }
        private void UnsubscribeEvents()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control != BtnMenu)
                    control.Click -= CloseSidebarOnClick;
            }
            this.Click -= CloseSidebarOnClick;
        }
        // Sidebar Animation
        private void StartSidebarAnimation(bool open)
        {
            targetWidth = open ? 60 : 0; // Adjust the target width based on open or close
            animationTimer.Tag = open;
            animationTimer.Start();
            isAnimating = true; // Set the flag to true when the animation starts
        }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
        {
            bool open = (bool)animationTimer.Tag;

            if (open && panelSidebarS.Width < targetWidth)
            {
                panelSidebarS.Width += 5; // Adjust the increment value for a smooth animation
            }
            else if (!open && panelSidebarS.Width > targetWidth)
            {
                panelSidebarS.Width -= 5; // Adjust the increment value for a smooth animation
            }
            else
            {
                animationTimer.Stop(); // Stop the timer when the animation is complete
                UnsubscribeEvents(); // Unsubscribe the events

                if (!open)
                {
                    panelSidebarS.Visible = false; // Hide the sidebar after closing animation
                }

                isAnimating = false; // Reset the flag when the animation is complete
            }
        }
        // Exit confirmation
        private void StandardCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing && e.CloseReason == CloseReason.UserClosing)
            {
                isClosing = true;

                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;  // Allow the form to close
                    isClosing = false; // Reset the flag

                    // Exit the application
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;   // Cancel the closing action
                    isClosing = false; // Reset the flag
                }
            }
        }





    }
}