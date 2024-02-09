namespace CalculatorQuiz2
{
    public class Calculator
    {
        public decimal CurrentValue
        {
            get; set;
        }

        public void Add(decimal operand)
        {
            decimal res = this.CurrentValue + operand;
            this.CurrentValue = res;
        }

        public void Subtract(decimal operand)
        {
            decimal res = this.CurrentValue - operand;
            this.CurrentValue = res;
        }

        public void Multiply(decimal operand)
        {
            decimal res = this.CurrentValue * operand;
            this.CurrentValue = res;
        }

        public void Divide(decimal operand)
        {
            decimal res = this.CurrentValue / operand;
            this.CurrentValue = res;
        }
    }
}