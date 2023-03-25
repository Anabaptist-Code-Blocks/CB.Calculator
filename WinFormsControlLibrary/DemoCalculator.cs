using Calculator.Backend;

namespace WinFormsControlLibrary
{
    public partial class DemoCalculator : UserControl
    {
        CalculatorLogic _state;

        public DemoCalculator()
        {
            _state = new CalculatorLogic(s => displayTextBox.Text = s);
            InitializeComponent();

            oneButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            twoButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            threeButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            fourButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            fiveButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            sixButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            sevenButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            eightButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            nineButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            zeroButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            changeSignButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            decimalButton.KeyClicked += _state.CalculatorButton_KeyClicked;
            additionButton.KeyClicked += _state.CalculatorButton_KeyClicked;
        }
    }
}