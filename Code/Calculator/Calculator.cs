namespace Cucumba.Demo.Calculator;
public static class Dear
{
    private class CalculatorImplementation : IAmCalculator
    {
        private double _result;

        public static CalculatorImplementation New => new();
        private CalculatorImplementation()
        {
            _result = 0d;
        }

        public IAmCalculator Add(double value)
        {
            _result += value;
            return this;
        }

        public IAmCalculator Subtract(double value)
        {
            _result -= value;
            return this;
        }

        public IAmCalculator MultiplyBy(double value)
        {
            _result *= value;
            return this;
        }

        public IAmCalculator DivideBy(double value)
        {
            if (value == 0)
            {
                throw new InvalidOperationException("Division by zero is not allowed.");
            }

            _result /= value;
            return this;
        }

        public double Please()
        {
            return _result;
        }
    }

    public static IAmCalculator Calculator => CalculatorImplementation.New;
}

public interface IAmCalculator
{
    IAmCalculator Add(double value);
    IAmCalculator Subtract(double value);
    IAmCalculator MultiplyBy(double value);
    IAmCalculator DivideBy(double value);
    double Please();
}