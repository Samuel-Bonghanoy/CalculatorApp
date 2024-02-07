namespace CalculatorQuiz2
{
    public class Calculator
    {
        decimal currentValue;

        public decimal GetCurrentValue() {
            return currentValue;
        }

         public void SetCurrentValue(decimal newVal) {
            this.currentValue = newVal;
        }

        public void Add(decimal operand) {
            decimal res = currentValue + operand;
            SetCurrentValue(res);
        }

        public void Subtract(decimal operand) {
            decimal res = currentValue - operand;
            SetCurrentValue(res);
        }

        public void Multiply(decimal operand) {
            decimal res = currentValue * operand;
            SetCurrentValue(res);
        }

        public void Divide(decimal operand) {
            decimal res = currentValue / operand;
            SetCurrentValue(res);
        }
    }
}