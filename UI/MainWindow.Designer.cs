namespace UI
{
    partial class MainWindow
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
            calculatorButton1 = new WinFormsControlLibrary.CalculatorButton();
            SuspendLayout();
            // 
            // calculatorButton1
            // 
            calculatorButton1.Key = Calculator.Backend.CalculatorKey.Num7;
            calculatorButton1.Location = new Point(102, 75);
            calculatorButton1.Name = "calculatorButton1";
            calculatorButton1.Size = new Size(75, 71);
            calculatorButton1.TabIndex = 0;
            calculatorButton1.Text = "calculatorButton1";
            calculatorButton1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculatorButton1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "MainWindow";
            Text = "UI";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary.CalculatorButton calculatorButton1;
    }
}