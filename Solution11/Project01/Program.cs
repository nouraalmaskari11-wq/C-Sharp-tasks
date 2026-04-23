namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
               
                Console.WriteLine("<<<<<<<<<<<< simple calculator >>>>>>>>>>>>>>");

                
                Console.Write("please enter the first number: ");

                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("please enter the second number: ");

                double num2 = Convert.ToDouble(Console.ReadLine());

              
                Console.WriteLine("choose an operation:");
                Console.WriteLine("+ : Addition");
                Console.WriteLine("- : Subtraction");
                Console.WriteLine("* : Multiplication");
                Console.WriteLine("/ : Division");

                Console.Write("your choice: ");

                string operation = Console.ReadLine();


                double result = 0;

                bool validOperation = true;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: cannot divide by zero!");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation!");
                        validOperation = false;
                        break;
                }

               
                if (validOperation)
                {
                    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
                }

               
                Console.WriteLine("What would you like to do now?");
                Console.WriteLine("1- perform another calculation");
                Console.WriteLine("2- exit the program");
                Console.Write("your choice: ");

                string choice = Console.ReadLine();

                if (choice == "2")
                {
                    continueCalculating = false;

                    Console.WriteLine("goodbye!");
                }
                else if (choice != "1")
                {
                    Console.WriteLine("Invalid input. pro will exit.");

                    continueCalculating = false;
                }
            }
        }
    }
}
