namespace CalculatorQuiz2
{
    public class Calculator
    {
        public bool HasPreviousAnswer
        {
            get; private set;
        }
        public decimal CurrentValue
        {
            get; set;
        }

        public void Add(decimal operand)
        {
            decimal res = this.CurrentValue + operand;
            this.HasPreviousAnswer = true;
            this.CurrentValue = res;
        }

        public void Subtract(decimal operand)
        {
            decimal res = this.CurrentValue - operand;
            this.HasPreviousAnswer = true;
            this.CurrentValue = res;
        }

        public void Multiply(decimal operand)
        {
            decimal res = this.CurrentValue * operand;
            this.HasPreviousAnswer = true;
            this.CurrentValue = res;
        }

        public void Divide(decimal operand)
        {
            decimal res = this.CurrentValue / operand;
            this.HasPreviousAnswer = true;
            this.CurrentValue = res;
        }
    }
}