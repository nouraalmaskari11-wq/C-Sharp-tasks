namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 – Day Name Printer
            Console.WriteLine("Enter a number from 1 to 7: ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Invalid day number"); break;
            }


            //Task 2 – Multiplication Table

            Console.WriteLine("Enter a number !");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num}X {i} = {num * (i)}");
            }


            //Task 3 – Countdown Timer

            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number");
            }
            else
            {
                while (number >= 1)
                {
                    Console.WriteLine(number);
                    number--;
                }
                Console.WriteLine("Go!");
            }


            //Task 4 – Season Detector with Month Validation

            Console.WriteLine("Enter a month number (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            switch(month)
            {
            case 12: case 1: case 2: Console.WriteLine("Winter"); break;
            case 3: case 4: case 5: Console.WriteLine("Spring"); break;
            case 6: case 7: case 8: Console.WriteLine("Summer"); break;
            case 9: case 10: case 11: Console.WriteLine("Autum"); break;
            default: Console.WriteLine("Invalid month number"); break;
            }


            //Task 5 – Sum of Even and Odd Numbers

            Console.WriteLine("Enter a Posittive number");
            int N = Convert.ToInt32(Console.ReadLine());

            int evenSum =0;
            int oddSum = 0;

            for (int i=1 ; i <= N; i++ )
            {
                if (i % 2 == 0) evenSum += i;
                else oddSum += i;
            }

            Console.WriteLine($"Sum of even numbers: {evenSum}");
            Console.WriteLine($"Sum of odd numbers: {oddSum}");



            //Task 6 – Password Retry System

            int correctPassword = 1234;
            int attempts = 0;
            
            while (attempts < 3)
            {
                Console.Write("Enter password: ");
                int enteredPassword = Convert.ToInt32(Console.ReadLine());

                if (enteredPassword == correctPassword)
                {
                    Console.WriteLine("Access Granted");
                    return;
                }
                else
                {
                    attempts++;
                    if (attempts == 3)
                        Console.WriteLine("Account Locked");
                    else
                        Console.WriteLine($"Wrong password. {3 - attempts} attempts remaining.");
                }
            }



            //Task 7 – Simple Calculator

            while (true)
            {
                Console.Write("Enter operator (+, -, *, /) or 'exit' to quit: ");
                string op = Console.ReadLine();

                if (op.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+": Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); break;
                    case "-": Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
                    case "*": Console.WriteLine($"{num1} × {num2} = {num1 * num2}"); break;
                    case "/":
                        if (num2 != 0)
                            Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;
                    default: Console.WriteLine("Invalid operator"); break;
                }
            }


     



        }
    }
}
