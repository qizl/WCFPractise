using Contracts;

namespace Services
{
    public class GeneralCalculatorService : IGeneralCalculator
    {
        public double Add(double x, double y) => x + y;
    }
}
