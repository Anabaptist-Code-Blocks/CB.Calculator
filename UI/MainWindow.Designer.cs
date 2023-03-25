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
            demoCalculator1 = new WinFormsControlLibrary.DemoCalculator();
            SuspendLayout();
            // 
            // demoCalculator1
            // 
            demoCalculator1.Dock = DockStyle.Fill;
            demoCalculator1.Location = new Point(0, 0);
            demoCalculator1.Name = "demoCalculator1";
            demoCalculator1.Size = new Size(555, 449);
            demoCalculator1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 449);
            Controls.Add(demoCalculator1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "MainWindow";
            Text = "UI";
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary.DemoCalculator demoCalculator1;
    }
}