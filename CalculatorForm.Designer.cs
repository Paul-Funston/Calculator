namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearButton = new System.Windows.Forms.Button();
            this.KeypadZero = new System.Windows.Forms.Button();
            this.KeypadPeriod = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.OperationSum = new System.Windows.Forms.Button();
            this.OperationMinus = new System.Windows.Forms.Button();
            this.OperationMultiply = new System.Windows.Forms.Button();
            this.OperationDivide = new System.Windows.Forms.Button();
            this.KeypadOne = new System.Windows.Forms.Button();
            this.KeypadTwo = new System.Windows.Forms.Button();
            this.KeypadThree = new System.Windows.Forms.Button();
            this.KeypadFour = new System.Windows.Forms.Button();
            this.KeypadFive = new System.Windows.Forms.Button();
            this.Keypad6 = new System.Windows.Forms.Button();
            this.KeypadSeven = new System.Windows.Forms.Button();
            this.KeypadEight = new System.Windows.Forms.Button();
            this.KeypadNine = new System.Windows.Forms.Button();
            this.ConvertToDecimal = new System.Windows.Forms.Button();
            this.ConvertToBinary = new System.Windows.Forms.Button();
            this.ConvertLocational = new System.Windows.Forms.Button();
            this.StoredOperationLabel = new System.Windows.Forms.Label();
            this.CurrentInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.AccessibleDescription = "Clears and reset calculator";
            this.ClearButton.AccessibleName = "Clear Button";
            this.ClearButton.Location = new System.Drawing.Point(10, 350);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(70, 50);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // KeypadZero
            // 
            this.KeypadZero.AccessibleDescription = "Append a 0 to input";
            this.KeypadZero.AccessibleName = "KeypadZero";
            this.KeypadZero.Location = new System.Drawing.Point(90, 350);
            this.KeypadZero.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadZero.Name = "KeypadZero";
            this.KeypadZero.Size = new System.Drawing.Size(70, 50);
            this.KeypadZero.TabIndex = 2;
            this.KeypadZero.TabStop = false;
            this.KeypadZero.Text = "0";
            this.KeypadZero.UseVisualStyleBackColor = true;
            this.KeypadZero.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadPeriod
            // 
            this.KeypadPeriod.AccessibleDescription = "Append a decimal to input";
            this.KeypadPeriod.AccessibleName = "Keypad Point";
            this.KeypadPeriod.Location = new System.Drawing.Point(170, 350);
            this.KeypadPeriod.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadPeriod.Name = "KeypadPeriod";
            this.KeypadPeriod.Size = new System.Drawing.Size(70, 50);
            this.KeypadPeriod.TabIndex = 1;
            this.KeypadPeriod.TabStop = false;
            this.KeypadPeriod.Text = ".";
            this.KeypadPeriod.UseVisualStyleBackColor = true;
            this.KeypadPeriod.Click += new System.EventHandler(this.Period_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.AccessibleDescription = "Get result of equation";
            this.EqualsButton.AccessibleName = "Equals Button";
            this.EqualsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EqualsButton.Location = new System.Drawing.Point(250, 350);
            this.EqualsButton.Margin = new System.Windows.Forms.Padding(5);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(70, 50);
            this.EqualsButton.TabIndex = 0;
            this.EqualsButton.TabStop = false;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.Equals_Click);
            // 
            // OperationSum
            // 
            this.OperationSum.AccessibleDescription = "The additionoperation to get a sum";
            this.OperationSum.AccessibleName = "Addition Operation";
            this.OperationSum.Location = new System.Drawing.Point(250, 290);
            this.OperationSum.Margin = new System.Windows.Forms.Padding(5);
            this.OperationSum.Name = "OperationSum";
            this.OperationSum.Size = new System.Drawing.Size(70, 50);
            this.OperationSum.TabIndex = 10;
            this.OperationSum.TabStop = false;
            this.OperationSum.Text = "+";
            this.OperationSum.UseVisualStyleBackColor = true;
            this.OperationSum.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationMinus
            // 
            this.OperationMinus.AccessibleDescription = "The subtraction operation to get a difference";
            this.OperationMinus.AccessibleName = "Subtraction Operation";
            this.OperationMinus.Location = new System.Drawing.Point(250, 230);
            this.OperationMinus.Margin = new System.Windows.Forms.Padding(5);
            this.OperationMinus.Name = "OperationMinus";
            this.OperationMinus.Size = new System.Drawing.Size(70, 50);
            this.OperationMinus.TabIndex = 11;
            this.OperationMinus.TabStop = false;
            this.OperationMinus.Text = "-";
            this.OperationMinus.UseVisualStyleBackColor = true;
            this.OperationMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationMultiply
            // 
            this.OperationMultiply.AccessibleDescription = "The multiplication operation to get a product";
            this.OperationMultiply.AccessibleName = "Multiply Operation";
            this.OperationMultiply.Location = new System.Drawing.Point(250, 170);
            this.OperationMultiply.Margin = new System.Windows.Forms.Padding(5);
            this.OperationMultiply.Name = "OperationMultiply";
            this.OperationMultiply.Size = new System.Drawing.Size(70, 50);
            this.OperationMultiply.TabIndex = 12;
            this.OperationMultiply.TabStop = false;
            this.OperationMultiply.Text = "X";
            this.OperationMultiply.UseVisualStyleBackColor = true;
            this.OperationMultiply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // OperationDivide
            // 
            this.OperationDivide.AccessibleDescription = "The division operation to get a quotient";
            this.OperationDivide.AccessibleName = "Divide Operation";
            this.OperationDivide.Location = new System.Drawing.Point(250, 110);
            this.OperationDivide.Margin = new System.Windows.Forms.Padding(5);
            this.OperationDivide.Name = "OperationDivide";
            this.OperationDivide.Size = new System.Drawing.Size(70, 50);
            this.OperationDivide.TabIndex = 13;
            this.OperationDivide.TabStop = false;
            this.OperationDivide.Text = "/";
            this.OperationDivide.UseVisualStyleBackColor = true;
            this.OperationDivide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // KeypadOne
            // 
            this.KeypadOne.AccessibleDescription = "Append a 1 to input";
            this.KeypadOne.AccessibleName = "KeypadOne";
            this.KeypadOne.Location = new System.Drawing.Point(10, 290);
            this.KeypadOne.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadOne.Name = "KeypadOne";
            this.KeypadOne.Size = new System.Drawing.Size(70, 50);
            this.KeypadOne.TabIndex = 1;
            this.KeypadOne.TabStop = false;
            this.KeypadOne.Text = "1";
            this.KeypadOne.UseVisualStyleBackColor = true;
            this.KeypadOne.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadTwo
            // 
            this.KeypadTwo.AccessibleDescription = "Append a 2 to input";
            this.KeypadTwo.AccessibleName = "KeypadTwo";
            this.KeypadTwo.Location = new System.Drawing.Point(90, 290);
            this.KeypadTwo.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadTwo.Name = "KeypadTwo";
            this.KeypadTwo.Size = new System.Drawing.Size(70, 50);
            this.KeypadTwo.TabIndex = 2;
            this.KeypadTwo.TabStop = false;
            this.KeypadTwo.Text = "2";
            this.KeypadTwo.UseVisualStyleBackColor = true;
            this.KeypadTwo.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadThree
            // 
            this.KeypadThree.AccessibleDescription = "Append a 3 to input";
            this.KeypadThree.AccessibleName = "KeypadThree";
            this.KeypadThree.Location = new System.Drawing.Point(170, 290);
            this.KeypadThree.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadThree.Name = "KeypadThree";
            this.KeypadThree.Size = new System.Drawing.Size(70, 50);
            this.KeypadThree.TabIndex = 3;
            this.KeypadThree.TabStop = false;
            this.KeypadThree.Text = "3";
            this.KeypadThree.UseVisualStyleBackColor = true;
            this.KeypadThree.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadFour
            // 
            this.KeypadFour.AccessibleDescription = "Append a 4 to input";
            this.KeypadFour.AccessibleName = "KeypadFour";
            this.KeypadFour.Location = new System.Drawing.Point(10, 230);
            this.KeypadFour.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadFour.Name = "KeypadFour";
            this.KeypadFour.Size = new System.Drawing.Size(70, 50);
            this.KeypadFour.TabIndex = 4;
            this.KeypadFour.TabStop = false;
            this.KeypadFour.Text = "4";
            this.KeypadFour.UseVisualStyleBackColor = true;
            this.KeypadFour.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadFive
            // 
            this.KeypadFive.AccessibleDescription = "Append a 5 to input";
            this.KeypadFive.AccessibleName = "KeypadFive";
            this.KeypadFive.Location = new System.Drawing.Point(90, 230);
            this.KeypadFive.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadFive.Name = "KeypadFive";
            this.KeypadFive.Size = new System.Drawing.Size(70, 50);
            this.KeypadFive.TabIndex = 5;
            this.KeypadFive.TabStop = false;
            this.KeypadFive.Text = "5";
            this.KeypadFive.UseVisualStyleBackColor = true;
            this.KeypadFive.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // Keypad6
            // 
            this.Keypad6.AccessibleDescription = "Append a 6 to input";
            this.Keypad6.AccessibleName = "KeypadSix";
            this.Keypad6.Location = new System.Drawing.Point(170, 230);
            this.Keypad6.Margin = new System.Windows.Forms.Padding(5);
            this.Keypad6.Name = "Keypad6";
            this.Keypad6.Size = new System.Drawing.Size(70, 50);
            this.Keypad6.TabIndex = 6;
            this.Keypad6.TabStop = false;
            this.Keypad6.Text = "6";
            this.Keypad6.UseVisualStyleBackColor = true;
            this.Keypad6.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadSeven
            // 
            this.KeypadSeven.AccessibleDescription = "Append a 7 to input";
            this.KeypadSeven.AccessibleName = "KeypadSeven";
            this.KeypadSeven.Location = new System.Drawing.Point(10, 170);
            this.KeypadSeven.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadSeven.Name = "KeypadSeven";
            this.KeypadSeven.Size = new System.Drawing.Size(70, 50);
            this.KeypadSeven.TabIndex = 7;
            this.KeypadSeven.TabStop = false;
            this.KeypadSeven.Text = "7";
            this.KeypadSeven.UseVisualStyleBackColor = true;
            this.KeypadSeven.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadEight
            // 
            this.KeypadEight.AccessibleDescription = "Append a 8 to input";
            this.KeypadEight.AccessibleName = "KeypadEight";
            this.KeypadEight.Location = new System.Drawing.Point(90, 170);
            this.KeypadEight.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadEight.Name = "KeypadEight";
            this.KeypadEight.Size = new System.Drawing.Size(70, 50);
            this.KeypadEight.TabIndex = 8;
            this.KeypadEight.TabStop = false;
            this.KeypadEight.Text = "8";
            this.KeypadEight.UseVisualStyleBackColor = true;
            this.KeypadEight.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // KeypadNine
            // 
            this.KeypadNine.AccessibleDescription = "Append a 9 to input";
            this.KeypadNine.AccessibleName = "KeypadNine";
            this.KeypadNine.Location = new System.Drawing.Point(170, 170);
            this.KeypadNine.Margin = new System.Windows.Forms.Padding(5);
            this.KeypadNine.Name = "KeypadNine";
            this.KeypadNine.Size = new System.Drawing.Size(70, 50);
            this.KeypadNine.TabIndex = 9;
            this.KeypadNine.TabStop = false;
            this.KeypadNine.Text = "9";
            this.KeypadNine.UseVisualStyleBackColor = true;
            this.KeypadNine.Click += new System.EventHandler(this.Keypad_Click);
            // 
            // ConvertToDecimal
            // 
            this.ConvertToDecimal.AccessibleDescription = "Convert unsigned binary number in number display to a decimal number";
            this.ConvertToDecimal.AccessibleName = "Convert To Decimal";
            this.ConvertToDecimal.Location = new System.Drawing.Point(10, 110);
            this.ConvertToDecimal.Margin = new System.Windows.Forms.Padding(5);
            this.ConvertToDecimal.Name = "ConvertToDecimal";
            this.ConvertToDecimal.Size = new System.Drawing.Size(70, 50);
            this.ConvertToDecimal.TabIndex = 15;
            this.ConvertToDecimal.TabStop = false;
            this.ConvertToDecimal.Text = "DEC";
            this.ConvertToDecimal.UseVisualStyleBackColor = true;
            this.ConvertToDecimal.Click += new System.EventHandler(this.ConvertToDecimal_Click);
            // 
            // ConvertToBinary
            // 
            this.ConvertToBinary.AccessibleDescription = "Converts a positive integer in number display to an unsigned binary number";
            this.ConvertToBinary.AccessibleName = "Convert to Binary number";
            this.ConvertToBinary.Location = new System.Drawing.Point(90, 110);
            this.ConvertToBinary.Margin = new System.Windows.Forms.Padding(5);
            this.ConvertToBinary.Name = "ConvertToBinary";
            this.ConvertToBinary.Size = new System.Drawing.Size(70, 50);
            this.ConvertToBinary.TabIndex = 16;
            this.ConvertToBinary.TabStop = false;
            this.ConvertToBinary.Text = "BIN";
            this.ConvertToBinary.UseVisualStyleBackColor = true;
            this.ConvertToBinary.Click += new System.EventHandler(this.ConvertToBinary_Click);
            // 
            // ConvertLocational
            // 
            this.ConvertLocational.AccessibleDescription = "Converts a decimal number to a locational numeral";
            this.ConvertLocational.AccessibleName = "Convert Decimal to Locational Numeral";
            this.ConvertLocational.Location = new System.Drawing.Point(170, 110);
            this.ConvertLocational.Margin = new System.Windows.Forms.Padding(5);
            this.ConvertLocational.Name = "ConvertLocational";
            this.ConvertLocational.Size = new System.Drawing.Size(70, 50);
            this.ConvertLocational.TabIndex = 17;
            this.ConvertLocational.TabStop = false;
            this.ConvertLocational.Text = "LOC";
            this.ConvertLocational.UseVisualStyleBackColor = true;
            this.ConvertLocational.Click += new System.EventHandler(this.ConvertLocational_Click);
            // 
            // StoredOperationLabel
            // 
            this.StoredOperationLabel.AccessibleDescription = "Label displays stored operation";
            this.StoredOperationLabel.AccessibleName = "Stored Operation";
            this.StoredOperationLabel.BackColor = System.Drawing.SystemColors.Window;
            this.StoredOperationLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StoredOperationLabel.Location = new System.Drawing.Point(250, 47);
            this.StoredOperationLabel.Name = "StoredOperationLabel";
            this.StoredOperationLabel.Size = new System.Drawing.Size(70, 34);
            this.StoredOperationLabel.TabIndex = 20;
            this.StoredOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentInputLabel
            // 
            this.CurrentInputLabel.AccessibleDescription = "Display for current number input";
            this.CurrentInputLabel.AccessibleName = "InputDisplay";
            this.CurrentInputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.CurrentInputLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentInputLabel.Location = new System.Drawing.Point(10, 47);
            this.CurrentInputLabel.Name = "CurrentInputLabel";
            this.CurrentInputLabel.Size = new System.Drawing.Size(230, 34);
            this.CurrentInputLabel.TabIndex = 21;
            this.CurrentInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClearButton;
            this.ClientSize = new System.Drawing.Size(329, 409);
            this.Controls.Add(this.CurrentInputLabel);
            this.Controls.Add(this.StoredOperationLabel);
            this.Controls.Add(this.ConvertLocational);
            this.Controls.Add(this.ConvertToBinary);
            this.Controls.Add(this.ConvertToDecimal);
            this.Controls.Add(this.KeypadNine);
            this.Controls.Add(this.KeypadEight);
            this.Controls.Add(this.KeypadSeven);
            this.Controls.Add(this.Keypad6);
            this.Controls.Add(this.KeypadFive);
            this.Controls.Add(this.KeypadFour);
            this.Controls.Add(this.KeypadThree);
            this.Controls.Add(this.KeypadTwo);
            this.Controls.Add(this.KeypadOne);
            this.Controls.Add(this.OperationDivide);
            this.Controls.Add(this.OperationMultiply);
            this.Controls.Add(this.OperationMinus);
            this.Controls.Add(this.OperationSum);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.KeypadPeriod);
            this.Controls.Add(this.KeypadZero);
            this.Controls.Add(this.ClearButton);
            this.KeyPreview = true;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculatorForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ClearButton;
        private Button KeypadZero;
        private Button KeypadPeriod;
        private Button EqualsButton;
        private Button OperationSum;
        private Button OperationMinus;
        private Button OperationMultiply;
        private Button OperationDivide;
        private Button KeypadOne;
        private Button KeypadTwo;
        private Button KeypadThree;
        private Button KeypadFour;
        private Button KeypadFive;
        private Button Keypad6;
        private Button KeypadSeven;
        private Button KeypadEight;
        private Button KeypadNine;
        private Button ConvertToDecimal;
        private Button ConvertToBinary;
        private Button ConvertLocational;
        private Label StoredOperationLabel;
        private Label CurrentInputLabel;
    }
}