namespace Calculator.Backend
{
    public enum CalculatorKey
    {
        Num1,
        Num2,
        Num3,
        Num4,
        Num5,
        Num6,
        Num7,
        Num8,
        Num9,
        Num0,
        OpAdd,
        OpSubtrat,
        OpMultiply,
        OpDivide,
        OpEquals,
        OpClear
    }

    public class CalculatorEventArgs : EventArgs
    {
        public CalculatorKey Key;
        public static CalculatorEventArgs New(CalculatorKey key) =>
            new CalculatorEventArgs { Key = key };

        private CalculatorEventArgs() { }
    }
}