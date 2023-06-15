using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT_ModernCalculator
{
    public partial class ScienceCalculator : Form
    {
        #region Calculation Initializing
        private double currentResult = 0.0;
        private double previousNumber = 0.0;
        private string operation = "";
        private bool isOperationPerformed = false;

        // Mod operation status
        private bool isModSelected = false;
        
        //Exit Form Need
        private bool isClosing = false;
        #endregion
        public ScienceCalculator()
        {

            InitializeComponent();
            //Display App Product Version
            LabelVersion.Text = "V." + ProductVersion + "-Release";
        }
        // Function to switch to Main Menu
        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuForm = new MainMenu();

            this.Hide();

            mainMenuForm.ShowDialog();

            this.Close();
        }
        //When number button clicked
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "." && TxtOut0S.Text.Contains("."))
            {
                // Ignore multiple decimal points
                return;
            }
            // Mod Operation init
            if (operation == "Mod")
            {
                if (isOperationPerformed)
                {
                    TxtOut0S.Clear();
                    isOperationPerformed = false;
                }

                TxtOut0S.Text += button.Text;
                TxtOut1S.Text += button.Text;
            }
            else
            {
                if (TxtOut0S.Text == "0" || isOperationPerformed)
                {
                    TxtOut0S.Clear();
                    isOperationPerformed = false;
                }

                TxtOut0S.Text += button.Text;
            }
        }
        #region Calculation Function And Operation

        // When button operation clicked, also define function for other operation
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;

            if (operation == "1/x")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    if (currentNumber != 0)
                    {
                        currentNumber = 1 / currentNumber;
                        TxtOut0S.Text = currentNumber.ToString();
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
            // Operation SquareNumber
            else if (operation == "x^2")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    currentNumber = Math.Pow(currentNumber, 2);
                    TxtOut0S.Text = currentNumber.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation SquareRoot
            else if (operation == "√")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    if (currentNumber >= 0)
                    {
                        currentNumber = Math.Sqrt(currentNumber);
                        TxtOut0S.Text = currentNumber.ToString();
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
            // Operation Hexadecimal
            else if (operation == "Hex")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    string result = Convert.ToString((long)currentNumber, 16);
                    TxtOut0S.Text = result;
                    TxtOut1S.Text = $"Hex({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation Octal
            else if (operation == "Oct")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    string result = Convert.ToString((long)currentNumber, 8);
                    TxtOut0S.Text = result;
                    TxtOut1S.Text = $"Oct({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation Bin
            else if (operation == "Bin")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    string result = Convert.ToString((long)currentNumber, 2);
                    TxtOut0S.Text = result;
                    TxtOut1S.Text = $"Bin({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation Mod
            else if (operation == "Mod")
            {
                if (!string.IsNullOrEmpty(TxtOut0S.Text))
                {
                    double currentNumber;

                    if (double.TryParse(TxtOut0S.Text, out currentNumber))
                    {
                        TxtOut1S.Text += currentNumber.ToString() + " Mod ";
                        isModSelected = true;
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
                    MessageBox.Show("Invalid input! Please enter a number before selecting Mod operation.");
                    return;
                }
            }
            // Operation In x
            else if (operation == "In x")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    if (currentNumber > 0)
                    {
                        double result = Math.Log(currentNumber);
                        TxtOut0S.Text = result.ToString();
                        TxtOut1S.Text = $"In x ({currentNumber})";
                    }
                    else
                    {
                        MessageBox.Show("Invalid input! Cannot take the natural logarithm of a non-positive number.");
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
            // Operation Sin
            else if (operation == "Sin")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Sin(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"Sin ({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation Cos
            else if (operation == "Cos")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Cos(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"Cos ({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation Tan
            else if (operation == "Tan")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Tan(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"Tan ({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation SinH
            else if (operation == "SinH")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Sinh(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"SinH ({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation CosH
            else if (operation == "CosH")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Cosh(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"CosH ({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation TanH
            else if (operation == "TanH")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Tanh(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"TanH ({currentNumber})";
                }
                else
                {
                    MessageBox.Show("Invalid input! Please enter a valid number.");
                    ClearAll();
                    return;
                }
            }
            // Operation exp
            else if (operation == "Exp")
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    double result = Math.Exp(currentNumber);
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"Exp({currentNumber})";
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
                if (TxtOut1S.Text.Length >= 2)
                {
                    TxtOut1S.Text = TxtOut1S.Text.Remove(TxtOut1S.Text.Length - 2);
                }

                previousNumber = double.Parse(TxtOut0S.Text);
                if (TxtOut1S.Text == "0")
                {
                    TxtOut1S.Text = "";
                }
                TxtOut1S.Text += previousNumber.ToString() + " " + GetOperatorSymbol(operation) + " ";
                TxtOut0S.Clear();
            }

            isOperationPerformed = true;
        }
        #endregion

        #region ScienceCalculator Button Click
        // Science calculator button operation
        private void BtnExp_Click(Object sender, EventArgs e)
        {
            operation = "Exp";
            OperationButton_Click(sender, e);
        }
        private void PiButton_Click(Object sender, EventArgs e)
        {
            double PIF = Math.PI;
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                if (currentNumber == 0)
                {
                    TxtOut0S.Text = PIF.ToString();
                    TxtOut1S.Text = "π";
                }
                else
                {
                    double result = currentNumber * PIF;
                    TxtOut0S.Text = result.ToString();
                    TxtOut1S.Text = $"π({currentNumber})";
                }
            }
            else
            {
                TxtOut0S.Text = PIF.ToString();
                TxtOut1S.Text = "π";
            }
        }
        private void InxButton_Click(Object sender, EventArgs e)
        {
            operation = "In x";
            OperationButton_Click(sender, e);
        }
        private void BtnBin_Click(Object sender, EventArgs e)
        {
            operation = "Bin";
            OperationButton_Click(sender, e);
        }
        private void BtnMod_Click(Object sender, EventArgs e)
        {
            operation = "Mod";
            OperationButton_Click(sender, e);
        }
        private void BtnHex_Click(Object sender, EventArgs e)
        {
            operation = "Hex";
            OperationButton_Click(sender, e);
        }
        private void BtnOct_Click(Object sender, EventArgs e)
        {
            operation = "Oct";
            OperationButton_Click(sender, e);
        }
        private void BtnSin_Click(Object sender, EventArgs e)
        {
            operation = "Sin";
            OperationButton_Click(sender, e);
        }
        private void BtnCos_Click(Object sender, EventArgs e)
        {
            operation = "Cos";
            OperationButton_Click(sender, e);
        }
        private void BtnTan_Click(Object sender, EventArgs e)
        {
            operation = "Tan";
            OperationButton_Click(sender, e);
        }
        private void BtnCosec_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                double result = 1 / Math.Sin(currentNumber);
                TxtOut0S.Text = result.ToString();
                TxtOut1S.Text = $"Cosec({currentNumber})";
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
                return;
            }
        }
        private void BtnInx_Click(Object sender, EventArgs e)
        {
            operation = "In x";
            OperationButton_Click(sender, e);
        }
        private void BtnSinH_Click(Object sender, EventArgs e)
        {
            operation = "SinH";
            OperationButton_Click(sender, e);
        }
        private void BtnCosH_Click(Object sender, EventArgs e)
        {
            operation = "CosH";
            OperationButton_Click(sender, e);
        }
        private void BtnTanH_Click(Object sender, EventArgs e)
        {
            operation = "TanH";
            OperationButton_Click(sender, e);
        }

        // Special Mod Button, because Mod is complicated
        private void ModButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOut0S.Text))
            {
                double currentNumber;

                if (double.TryParse(TxtOut0S.Text, out currentNumber))
                {
                    TxtOut1S.Text = currentNumber.ToString() + " Mod ";
                    operation = "Mod";
                    isOperationPerformed = true;
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
                MessageBox.Show("Invalid input! Please enter a number before selecting Mod operation.");
                return;
            }
        }

        // When equal button clicked
        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOut1S.Text) && !string.IsNullOrEmpty(TxtOut0S.Text))
            {
                double firstOperand, secondOperand;
                string[] parts = TxtOut1S.Text.Split(' ');

                if (double.TryParse(parts[0], out firstOperand) && double.TryParse(TxtOut0S.Text, out secondOperand))
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

                    TxtOut1S.Text = "";
                    TxtOut0S.Text = result.ToString();
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
        // Operation 1/x
        private void OneOverXButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                if (currentNumber != 0)
                {
                    currentNumber = 1 / currentNumber;
                    TxtOut0S.Text = currentNumber.ToString();
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
        // Operation x^2
        private void SquareButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                currentNumber = Math.Pow(currentNumber, 2);
                TxtOut0S.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
                return;
            }
        }
        //Operation SquareRoot
        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                if (currentNumber >= 0)
                {
                    currentNumber = Math.Sqrt(currentNumber);
                    TxtOut0S.Text = currentNumber.ToString();
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
        // Operation Percent
        private void PercentageButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                currentNumber = currentNumber / 100;
                TxtOut0S.Text = currentNumber.ToString();
                TxtOut1S.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
            }
        }

        // Convert number to positive or negative
        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            double currentNumber;

            if (double.TryParse(TxtOut0S.Text, out currentNumber))
            {
                currentNumber *= -1;
                TxtOut0S.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input! Please enter a valid number.");
                ClearAll();
            }
        }
        #endregion

        // Non Number And Calculation Button Operation

        // Clear field
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        //Clear Entry only
        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            TxtOut0S.Text = "0";
            //TxtOut1S.Text = "0";
        }

        // Clear all field and operation
        private void ClearAll()
        {
            TxtOut0S.Text = "0";
            TxtOut1S.Text = "0";
            currentResult = 0.0;
            previousNumber = 0.0;
            operation = "";
            isOperationPerformed = false;
        }
        // Display operator symbol to Minidisplay (TxtOut1)
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
                case "pi":
                    return "π";
                default:
                    return operation;
            }
        }
        // Remove one number at a time
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtOut1S.Text))
            {
                if (TxtOut1S.Text.EndsWith(" "))
                {
                    TxtOut1S.Text = TxtOut1S.Text.Remove(TxtOut1S.Text.Length - 3, 3);
                }
                else
                {
                    TxtOut1S.Text = TxtOut1S.Text.Remove(TxtOut1S.Text.Length - 1, 1);
                }
            }
            else if (!string.IsNullOrEmpty(TxtOut0S.Text))
            {
                if (TxtOut0S.Text.Any(char.IsDigit))
                {
                    int lastIndex = TxtOut0S.Text.LastIndexOfAny("0123456789".ToCharArray());
                    TxtOut0S.Text = TxtOut0S.Text.Remove(lastIndex, 1);
                }
                else
                {
                    TxtOut0S.Text = "0";
                }
            }
        }
        // Input decimal
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!TxtOut0S.Text.Contains("."))
            {
                TxtOut0S.Text += ".";
            }
        }
        // Exit confirmation
        private void ScienceCalculator_FormClosing(object sender, FormClosingEventArgs e)
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
