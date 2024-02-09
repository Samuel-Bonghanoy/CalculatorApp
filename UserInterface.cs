using CalculatorQuiz2;

public sealed class UserInterface
{
    private static readonly UserInterface instance = new();
    private static readonly Calculator calculator = new();
    decimal operand;

    private UserInterface() { } // Private constructor to prevent external creation

    // Static field that returns the instance we defined
    public static UserInterface Instance
    {
        get { return instance; }
    }


    public void Start()
    {
        int command = default;

        while (command != 5)
        {
            Console.WriteLine("================= ENTER YOUR CALCULATION ====================");
            GetOperands();
            GetCommand(out command);

            switch (command)
            {
                case 1:
                    calculator.Add(operand);
                    Console.WriteLine("The answer is " + Math.Round(calculator.CurrentValue, 2));

                    break;
                case 2:
                    calculator.Subtract(operand);
                    Console.WriteLine("The answer is " + Math.Round(calculator.CurrentValue, 2));

                    break;
                case 3:
                    calculator.Multiply(operand);
                    Console.WriteLine("The answer is " + Math.Round(calculator.CurrentValue, 2));

                    break;
                case 4:
                    if (this.operand == 0)
                    {
                        Console.WriteLine("Math Error. Please input another calculation.");
                    }
                    else
                    {
                        calculator.Divide(operand);
                        Console.WriteLine("The answer is " + Math.Round(calculator.CurrentValue, 2));
                    }

                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("[ERR] Invalid calculation! Please try again.");
                    break;
            }
        }

    }

    public bool GetOperands()
    {
        string? input;
        decimal temp;

        do
        {
            Console.Write($"Input your first operand{(calculator.HasPreviousAnswer ? " (type 'ans' for previous result)" : "")}: ");
            input = Console.ReadLine();

            if (decimal.TryParse(input, out temp))
            {
                break; // Exit the loop if input is a valid decimal number
            }
            else if (input == "ans")
            {
                if (calculator.HasPreviousAnswer)
                {
                    break; // Exit the loop if there is a previous answer
                }
                else
                {
                    Console.WriteLine("[ERR] Input is invalid! No previous answer available.");
                }
            }
            else
            {
                Console.WriteLine("[ERR] Input is invalid! Please try again.");
            }
        } while (true);

        if (input?.Equals("ans") != true)
        {
            calculator.CurrentValue = temp;
        }

        Console.Write("Input your second operand: ");
        input = Console.ReadLine();

        while (decimal.TryParse(input, out this.operand) == false)
        {
            Console.Write("[ERR] Input is invalid!\nPlease input another number: ");
            input = Console.ReadLine();
        }

        return true;
    }
    public bool GetCommand(out int command)
    {
        Console.WriteLine("Choose an Operation:");
        Console.WriteLine("1 - Add");
        Console.WriteLine("2 - Subtract");
        Console.WriteLine("3 - Multiply");
        Console.WriteLine("4 - Divide");
        Console.WriteLine("5 - Exit");
        Console.Write("Choice: ");
        string? rawInput = Console.ReadLine();
        int parsedInput;
        bool isValidInput = int.TryParse(rawInput, out parsedInput);

        if (isValidInput)
        {
            command = parsedInput;

            return true;
        }
        else
        {
            command = default;
            return false;
        }
    }

    public static void Exit()
    {
        System.Environment.Exit(0);
    }
}