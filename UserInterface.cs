public sealed class UserInterface {
    private static readonly UserInterface instance = new UserInterface();

    private UserInterface() { } // Private constructor to prevent external creation

    // Static field that returns the instance we defined
    public static UserInterface Instance
    {
        get { return instance; }
    }

       
    public void Start()
    {
        int command = default; // 0 is the default value
        
        while (command != 5)
        {
            GetCommand(out command); 

            switch (command)
            {
                case 1:
                   
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    Console.WriteLine("hi");
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
    public bool GetCommand(out int command)
    {
        Console.WriteLine("Choose an Operand:");
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