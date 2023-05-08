using System.DirectoryServices;
using System.Reflection.Emit;
using System.Text;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private enum Operation { 
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE
        }

        private Operation? StoredOperation { get; set; }
        private double? StoredOperand { get; set; }

        private StringBuilder currentInputStringBuilder = new StringBuilder();

        private bool isError { get; set; } = false;

        // EVENT LISTENER and FORM CONTROLS
        private void Keypad_Click(object sender, EventArgs e)
        {
            if(isError)
            {
                ClearError();
                return;
            }

            string value = (sender as Button).Text;
            int digit = -1;
            try
            {
                digit = Int32.Parse(value);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }

            if (digit >= 0)
            { 
                AppendDigit(digit);
            }
        }


        private void Equals_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            PerformEquation();
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            string value = (sender as Button).Text;

            switch (value)
            {
                case "+":
                    OperationAction(Operation.ADD);
                    break;

                case "-":
                    OperationAction(Operation.SUBTRACT);
                    break;

                case "X":
                    OperationAction(Operation.MULTIPLY);
                    break;

                case "/":
                    OperationAction(Operation.DIVIDE);
                    break;

                default:
                    break;
            }
        }

        private void Period_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            AddPeriod();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            ClearAll();
        }

        private void ConvertToDecimal_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            try
            {
                double inputNumber = Double.Parse(currentInputStringBuilder.ToString());
                if(isBinary(inputNumber))
                {
                    double result = UnsignedBinaryToDecimal(inputNumber);
                    currentInputStringBuilder.Clear();
                    currentInputStringBuilder.Append(result);
                    UpdateDisplayInputLabel();
                }
            }
            catch
            {
                ErrorState();
            }
        }

        private void ConvertToBinary_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            try
            {
                double inputNumber = Double.Parse(currentInputStringBuilder.ToString());

                if(isWholeNumber(inputNumber))
                {
                    double result = DecimalToBinary(inputNumber);
                    currentInputStringBuilder.Clear();
                    currentInputStringBuilder.Append(result);
                    UpdateDisplayInputLabel();
                }

            } catch { ErrorState(); }
        }

        private void ConvertLocational_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            try
            {
                double inputNumber = Double.Parse(currentInputStringBuilder.ToString());
                if (isBinary(inputNumber))
                {
                    string result = DecimalToLocational(inputNumber);
                    CurrentInputLabel.Text = result;
                    

                }

            } catch { ErrorState(); }
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }

            // Keys With Shift
            if((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                // Equal
                if ( e.KeyCode == Keys.Oemplus)
                {
                    OperationAction(Operation.ADD);
                }

                // *
                if(e.KeyCode == Keys.D8)
                {
                    OperationAction(Operation.MULTIPLY);
                }
            }

            // Keys without shift

            if(e.KeyValue >= 48 && e.KeyValue <= 57)
            {
                AppendDigit(e.KeyValue - 48);
            }

            if(e.KeyCode == Keys.OemPeriod)
            {
                AddPeriod();
            }

            // Equals
            if(e.KeyCode == Keys.Oemplus )
            {
                // Equals
            }

            if(e.KeyCode == Keys.OemMinus)
            {
                OperationAction(Operation.SUBTRACT);
            }

            if(e.KeyCode == Keys.Oem2)
            {
                OperationAction(Operation.DIVIDE);
            }
        }


        // Helper Methods

        private void ErrorState()
        {
            isError = true;
            StoredOperationLabel.Text = "ERROR";
        }

        private void ClearError()
        {
            ClearAll();
            isError = false;
        }

        private void ClearAll()
        {
            StoredOperand = null;
            StoredOperation = null;
            currentInputStringBuilder.Clear();
            CurrentInputLabel.Text = "";
        }
        private void AppendDigit(int n)
        {
            if(n >= 0 && n < 10)
            {
                currentInputStringBuilder.Append(n);
            }

            UpdateDisplayInputLabel();
        }
        private void AddPeriod()
        {
            if (!currentInputStringBuilder.ToString().Any(c => c.Equals('.')))
            {
                currentInputStringBuilder.Append('.');
            }
        }

        private void UpdateDisplayInputLabel()
        {
            CurrentInputLabel.Text = currentInputStringBuilder.ToString();
        }

        private void UpdateStoredOperationLabel()
        {
            string operation = "";

            switch (StoredOperation)
            {
                case Operation.ADD:
                    operation = "+";
                    break;

                case Operation.SUBTRACT:
                    operation = "-";
                    break;

                case Operation.MULTIPLY: 
                    operation = "*";
                    break;

                case Operation.DIVIDE: 
                    operation = "/";
                    break;

                default:
                    break;
            }

            StoredOperationLabel.Text = operation;
        }

        private void PerformEquation()
        {
            try
            {
                if (StoredOperand != null && StoredOperation != null && currentInputStringBuilder.Length > 0)
                {
                    Operation o = (Operation)StoredOperation;
                    double storedOperand = (double)StoredOperand;
                    double currentOperand = Double.Parse(currentInputStringBuilder.ToString());
                    double result = GetEquationResults(o, storedOperand, currentOperand);


                    currentInputStringBuilder.Clear();
                    currentInputStringBuilder.Append(result);
                    
                    storedOperand = result;
                    StoredOperation = null;

                    UpdateDisplayInputLabel();
                    UpdateStoredOperationLabel();
                }
            } catch
            {
                ErrorState();
            }
            
        }

        private void OperationAction(Operation o)
        {
            // currentInput, Stored Operand, and stored Operation - perform stored operation then replace storedOperation
            if (StoredOperand != null && StoredOperation != null && currentInputStringBuilder.Length > 0)
            {
                PerformEquation();
                StoredOperation = o;
            }

            //  NO current input, storedOperand and stored Operation - replace stored Operation
            if(StoredOperand != null && StoredOperation != null)
            {
                StoredOperation = o;
            }

            // No Stored Operation Store the Operation, and store current input as storedOperand
            if(StoredOperation == null && currentInputStringBuilder.Length > 0)
            {
                StoreOperand();
                StoredOperation = o;
            }

            UpdateStoredOperationLabel();
        }

        private void StoreOperand()
        {
            try
            {
                StoredOperand = Double.Parse(currentInputStringBuilder.ToString());
                currentInputStringBuilder.Clear();
            }
            catch (Exception ex)
            {
                ErrorState();
            }
        }

        private double GetEquationResults(Operation operation, double numberOne, double numberTwo)
        {
            double result = 0;

            switch (operation)
            {
                case Operation.ADD:
                    result = numberOne + numberTwo;
                    break;

                case Operation.SUBTRACT:
                    result = numberOne - numberTwo;
                    break;

                case Operation.MULTIPLY:
                    result = numberOne * numberTwo;
                    break;

                case Operation.DIVIDE:
                    result = numberOne / numberTwo;
                    break;
            }

            return result;
        }

        private bool isBinary(double n)
        {
            if (n < 0 || !isWholeNumber(n))
            {
                return false;
            }

            while (n > 0)
            {
                double digit = n % 10;

                if (digit > 1)
                {
                    return false;
                }

                n = (int)n / 10;
            }

            return true;

        }

        private bool isWholeNumber(double n)
        {
            return n == (int)n;
        }

        private double UnsignedBinaryToDecimal(double n)
        {
            if (!isBinary(n))
            {
                throw new ArgumentException();
            }

            int i = 0;
            double result = 0;

            while (n > 0)
            {
                double digit = n % 10;

                result += digit * (int)Math.Pow(2, i);
                n = (int)n / 10;
                i++;
            }

            return result;
        }

        private double DecimalToBinary(double n)
        {
            // No negative numbers
            if (n < 0) { throw new ArgumentException(); }

            int value = 0;
            int i = 0;

            // Find scale of n
            while (value < n)
            {
                value = (int)Math.Pow(2, i++);
            }

            i--;

            int result = 0;

            // build binary number

            while (n > 0)
            {
                if (i < 0) { break; }

                value = (int)Math.Pow(2, i);
                if (n >= value)
                {
                    n -= value;
                    result += 1 * (int)Math.Pow(10, i);
                }

                i--;
            }

            return result;
        }

        private string DecimalToLocational(double n)
        {
            StringBuilder result = new StringBuilder();
            string inputNumberString = n.ToString();
            int charCode = 65;

            if(!isBinary(n))
            {
                throw new ArgumentException();
            }

            
            for(int i = inputNumberString.Length - 1; i >= 0; i--)
            {
                if (inputNumberString[i] == '1')
                {
                    result.Append(Char.ConvertFromUtf32(charCode));
                }

                charCode++;
            }
            
            return result.ToString();
        }
    }
}