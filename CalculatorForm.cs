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
        }

        private void ConvertToBinary_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }
        }

        private void ConvertLocational_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                ClearError();
                return;
            }
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
                if (StoredOperand != null && StoredOperation != null && currentInputStringBuilder.Length != 0)
                {
                    Operation o = (Operation)StoredOperation;
                    double storedOperand = (double)StoredOperand;
                    double currentOperand = Double.Parse(currentInputStringBuilder.ToString());
                    double result = PerformOperation(o, storedOperand, currentOperand);


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

            StoredOperation = o;
            UpdateStoredOperationLabel();

            StoreOperand();
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
                Console.WriteLine(ex.Message);
            }
        }

        private double PerformOperation(Operation operation, double numberOne, double numberTwo)
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

    }
}