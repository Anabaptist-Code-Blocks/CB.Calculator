namespace WinFormsControlLibrary
{
    partial class DemoCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            zeroButton = new CalculatorButton();
            changeSignButton = new CalculatorButton();
            decimalButton = new CalculatorButton();
            additionButton = new CalculatorButton();
            oneButton = new CalculatorButton();
            twoButton = new CalculatorButton();
            threeButton = new CalculatorButton();
            minusButton = new CalculatorButton();
            equalsButton = new CalculatorButton();
            sevenButton = new CalculatorButton();
            eightButton = new CalculatorButton();
            nineButton = new CalculatorButton();
            divisionButton = new CalculatorButton();
            clearButton = new CalculatorButton();
            multiplicationButton = new CalculatorButton();
            sixButton = new CalculatorButton();
            fiveButton = new CalculatorButton();
            fourButton = new CalculatorButton();
            displayTextBox = new TextBox();
            listView1 = new ListView();
            History = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Size = new Size(494, 458);
            splitContainer1.SplitterDistance = 377;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(zeroButton, 0, 4);
            tableLayoutPanel1.Controls.Add(changeSignButton, 1, 4);
            tableLayoutPanel1.Controls.Add(decimalButton, 2, 4);
            tableLayoutPanel1.Controls.Add(additionButton, 3, 4);
            tableLayoutPanel1.Controls.Add(oneButton, 0, 3);
            tableLayoutPanel1.Controls.Add(twoButton, 1, 3);
            tableLayoutPanel1.Controls.Add(threeButton, 2, 3);
            tableLayoutPanel1.Controls.Add(minusButton, 3, 3);
            tableLayoutPanel1.Controls.Add(equalsButton, 4, 3);
            tableLayoutPanel1.Controls.Add(sevenButton, 0, 1);
            tableLayoutPanel1.Controls.Add(eightButton, 1, 1);
            tableLayoutPanel1.Controls.Add(nineButton, 2, 1);
            tableLayoutPanel1.Controls.Add(divisionButton, 3, 1);
            tableLayoutPanel1.Controls.Add(clearButton, 4, 1);
            tableLayoutPanel1.Controls.Add(multiplicationButton, 3, 2);
            tableLayoutPanel1.Controls.Add(sixButton, 2, 2);
            tableLayoutPanel1.Controls.Add(fiveButton, 1, 2);
            tableLayoutPanel1.Controls.Add(fourButton, 0, 2);
            tableLayoutPanel1.Controls.Add(displayTextBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(373, 454);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // zeroButton
            // 
            zeroButton.Dock = DockStyle.Fill;
            zeroButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            zeroButton.Key = Calculator.Backend.CalculatorKey.Num0;
            zeroButton.Location = new Point(5, 365);
            zeroButton.Margin = new Padding(5);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(64, 84);
            zeroButton.TabIndex = 24;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // changeSignButton
            // 
            changeSignButton.Dock = DockStyle.Fill;
            changeSignButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            changeSignButton.Key = null;
            changeSignButton.Location = new Point(79, 365);
            changeSignButton.Margin = new Padding(5);
            changeSignButton.Name = "changeSignButton";
            changeSignButton.Size = new Size(64, 84);
            changeSignButton.TabIndex = 23;
            changeSignButton.Text = "+/-";
            changeSignButton.UseVisualStyleBackColor = true;
            // 
            // decimalButton
            // 
            decimalButton.Dock = DockStyle.Fill;
            decimalButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            decimalButton.Key = null;
            decimalButton.Location = new Point(153, 365);
            decimalButton.Margin = new Padding(5);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(64, 84);
            decimalButton.TabIndex = 22;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = true;
            // 
            // additionButton
            // 
            additionButton.Dock = DockStyle.Fill;
            additionButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            additionButton.Key = Calculator.Backend.CalculatorKey.OpAdd;
            additionButton.Location = new Point(227, 365);
            additionButton.Margin = new Padding(5);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(64, 84);
            additionButton.TabIndex = 21;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = true;
            // 
            // oneButton
            // 
            oneButton.Dock = DockStyle.Fill;
            oneButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            oneButton.Key = Calculator.Backend.CalculatorKey.Num1;
            oneButton.Location = new Point(5, 275);
            oneButton.Margin = new Padding(5);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(64, 80);
            oneButton.TabIndex = 19;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            // 
            // twoButton
            // 
            twoButton.Dock = DockStyle.Fill;
            twoButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            twoButton.Key = Calculator.Backend.CalculatorKey.Num2;
            twoButton.Location = new Point(79, 275);
            twoButton.Margin = new Padding(5);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(64, 80);
            twoButton.TabIndex = 18;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            threeButton.Dock = DockStyle.Fill;
            threeButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            threeButton.Key = Calculator.Backend.CalculatorKey.Num3;
            threeButton.Location = new Point(153, 275);
            threeButton.Margin = new Padding(5);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(64, 80);
            threeButton.TabIndex = 17;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            // 
            // minusButton
            // 
            minusButton.Dock = DockStyle.Fill;
            minusButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            minusButton.Key = Calculator.Backend.CalculatorKey.OpSubtrat;
            minusButton.Location = new Point(227, 275);
            minusButton.Margin = new Padding(5);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(64, 80);
            minusButton.TabIndex = 16;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            // 
            // equalsButton
            // 
            equalsButton.Dock = DockStyle.Fill;
            equalsButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            equalsButton.Key = Calculator.Backend.CalculatorKey.OpEquals;
            equalsButton.Location = new Point(301, 275);
            equalsButton.Margin = new Padding(5);
            equalsButton.Name = "equalsButton";
            tableLayoutPanel1.SetRowSpan(equalsButton, 2);
            equalsButton.Size = new Size(67, 174);
            equalsButton.TabIndex = 15;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            sevenButton.Dock = DockStyle.Fill;
            sevenButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            sevenButton.Key = Calculator.Backend.CalculatorKey.Num7;
            sevenButton.Location = new Point(5, 95);
            sevenButton.Margin = new Padding(5);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(64, 80);
            sevenButton.TabIndex = 0;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            eightButton.Dock = DockStyle.Fill;
            eightButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            eightButton.Key = Calculator.Backend.CalculatorKey.Num8;
            eightButton.Location = new Point(79, 95);
            eightButton.Margin = new Padding(5);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(64, 80);
            eightButton.TabIndex = 1;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            // 
            // nineButton
            // 
            nineButton.Dock = DockStyle.Fill;
            nineButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            nineButton.Key = Calculator.Backend.CalculatorKey.Num9;
            nineButton.Location = new Point(153, 95);
            nineButton.Margin = new Padding(5);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(64, 80);
            nineButton.TabIndex = 2;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            // 
            // divisionButton
            // 
            divisionButton.Dock = DockStyle.Fill;
            divisionButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            divisionButton.Key = Calculator.Backend.CalculatorKey.OpDivide;
            divisionButton.Location = new Point(227, 95);
            divisionButton.Margin = new Padding(5);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(64, 80);
            divisionButton.TabIndex = 3;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Fill;
            clearButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Key = Calculator.Backend.CalculatorKey.OpClear;
            clearButton.Location = new Point(301, 95);
            clearButton.Margin = new Padding(5);
            clearButton.Name = "clearButton";
            tableLayoutPanel1.SetRowSpan(clearButton, 2);
            clearButton.Size = new Size(67, 170);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Dock = DockStyle.Fill;
            multiplicationButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationButton.Key = Calculator.Backend.CalculatorKey.OpMultiply;
            multiplicationButton.Location = new Point(227, 185);
            multiplicationButton.Margin = new Padding(5);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(64, 80);
            multiplicationButton.TabIndex = 8;
            multiplicationButton.Text = "*";
            multiplicationButton.UseVisualStyleBackColor = true;
            // 
            // sixButton
            // 
            sixButton.Dock = DockStyle.Fill;
            sixButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            sixButton.Key = Calculator.Backend.CalculatorKey.Num6;
            sixButton.Location = new Point(153, 185);
            sixButton.Margin = new Padding(5);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(64, 80);
            sixButton.TabIndex = 7;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            fiveButton.Dock = DockStyle.Fill;
            fiveButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fiveButton.Key = Calculator.Backend.CalculatorKey.Num5;
            fiveButton.Location = new Point(79, 185);
            fiveButton.Margin = new Padding(5);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(64, 80);
            fiveButton.TabIndex = 6;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            fourButton.Dock = DockStyle.Fill;
            fourButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            fourButton.Key = Calculator.Backend.CalculatorKey.Num4;
            fourButton.Location = new Point(5, 185);
            fourButton.Margin = new Padding(5);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(64, 80);
            fourButton.TabIndex = 5;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            // 
            // displayTextBox
            // 
            displayTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(displayTextBox, 5);
            displayTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            displayTextBox.Location = new Point(3, 25);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(367, 39);
            displayTextBox.TabIndex = 25;
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { History });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(109, 454);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // History
            // 
            History.Text = "History";
            History.Width = 90;
            // 
            // DemoCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "DemoCalculator";
            Size = new Size(494, 458);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView listView1;
        private ColumnHeader History;
        private TableLayoutPanel tableLayoutPanel1;
        private CalculatorButton fourButton;
        private CalculatorButton fiveButton;
        private CalculatorButton sixButton;
        private CalculatorButton multiplicationButton;
        private CalculatorButton sevenButton;
        private CalculatorButton eightButton;
        private CalculatorButton nineButton;
        private CalculatorButton divisionButton;
        private CalculatorButton clearButton;
        private CalculatorButton zeroButton;
        private CalculatorButton changeSignButton;
        private CalculatorButton decimalButton;
        private CalculatorButton additionButton;
        private CalculatorButton oneButton;
        private CalculatorButton twoButton;
        private CalculatorButton threeButton;
        private CalculatorButton minusButton;
        private CalculatorButton equalsButton;
        private TextBox displayTextBox;
    }
}