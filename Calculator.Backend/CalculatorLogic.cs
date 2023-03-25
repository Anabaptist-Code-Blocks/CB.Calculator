using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Backend
{
    public class CalculatorLogic
    {
        private Action<string> _onOperationCompleteCallback;
        public CalculatorLogic(Action<string> diplayCallback) { 
            _onOperationCompleteCallback = diplayCallback;
        }

        public void CalculatorButton_KeyClicked(object? sender, CalculatorEventArgs e)
        {
            var s = $"Calculator click: {e.Key}";
            Console.WriteLine(s);
            _onOperationCompleteCallback(s);
        }
    }
}
