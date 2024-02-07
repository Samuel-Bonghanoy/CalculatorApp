﻿namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        UserInterface ui = UserInterface.Instance;
        ui.Start();
    }
}