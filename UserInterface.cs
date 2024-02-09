using CalculatorQuiz2;

public sealed class UserInterface {
    private static readonly UserInterface instance = new UserInterface();
    private static Calculator calculator = new Calculator();
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
            getOperands();
            GetCommand(out command); 

            switch (command)
            {
                case 1:
                   //calculator add
                    break;
                case 2:
                    //calculator subtract
                    break;
                case 3:
                    //calculator multiply
                    break;
                case 4:
                    //calculator divide
                    break;
                case 5:
                    Exit();
                    break;
                default:
                    Console.WriteLine("[ERR] Invalid command! Please try again.");
                    break;
            }
        }


    }

    public bool getOperands() {
        Console.WriteLine("Input your first operand:");
        string? input = Console.ReadLine();
        decimal temp;

        while(decimal.TryParse(input, out temp) == false && input?.Equals("ans") != true){
            Console.WriteLine("Input is invalid. Please input another number:");
            input = Console.ReadLine();
        }

        if(input?.Equals("ans") != true) {
            calculator.setCurrentValue(temp);
        } 
         
         Console.WriteLine("Input your second operand:");
        input = Console.ReadLine();

        while(decimal.TryParse(input, out this.operand) == false){
            Console.WriteLine("Input is invalid. Please input another number:");
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