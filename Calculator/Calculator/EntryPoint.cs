using Calculator.Actions;
using Calculator.Calculator;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare Variables, Initialize objects etc
        bool stopApp = false;
        double rslt;

        //Run app
        while (!stopApp)
        {
            //Construct UI
            Console.WriteLine("Welcome to the basic calculator! \n" +
            "Select a function: \n" +
            "1 - Addition \n" +
            "2 - Substraction\n" +
            "3 - Multiplication\n" +
            "4 - Division\n");

            //User Input
            double InputOne;
            double InputTwo;

            //Select Function
            int functionSelect = int.Parse(Console.ReadLine().ToString());
            switch (functionSelect)
            {
                case 1:
                    InputOne = GetUserInput.GetInputOne();
                    InputTwo = GetUserInput.GetInputTwo();

                    rslt = CalcOperations.Add(InputOne, InputTwo);
                    
                    Console.WriteLine("Result");
                    Console.WriteLine(rslt);
                    break;
                case 2:
                    InputOne = GetUserInput.GetInputOne();
                    InputTwo = GetUserInput.GetInputTwo();

                    rslt = CalcOperations.Subtract(InputTwo, InputOne);

                    Console.WriteLine("Result");
                    Console.WriteLine(rslt);
                    break;
                case 3:
                    InputOne = GetUserInput.GetInputOne();
                    InputTwo = GetUserInput.GetInputTwo();

                    if (InputTwo == 0)
                    {
                        Console.WriteLine("Please enter another number than 0.");
                        InputTwo = GetUserInput.GetInputTwo();
                    }

                    rslt = CalcOperations.Multiply(InputTwo, InputOne);
                    Console.WriteLine("Result");
                    Console.WriteLine(rslt);
                    break;
                case 4:
                    InputOne = GetUserInput.GetInputOne();
                    InputTwo = GetUserInput.GetInputTwo();

                    if (InputTwo == 0)
                    {
                        Console.WriteLine("Please enter another number than 0.");
                        InputTwo = GetUserInput.GetInputTwo();
                    }

                    rslt = CalcOperations.Divide(InputTwo, InputOne);
                    Console.WriteLine("Result");
                    Console.WriteLine(rslt);
                    break;

            }

            //Exit App
            Console.WriteLine();
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") stopApp = true;
        }
    }
}