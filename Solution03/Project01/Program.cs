namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 – Day Name Printer

            #region
            Console.WriteLine("Enter a number from 1 to 7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

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
            #endregion

            //Task 2 – Multiplication Table

            #region
            Console.WriteLine("Enter a number !");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num}X {i} = {num * (i)}");
            }
            #endregion

            //Task 3 – Countdown Timer

            #region
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
            #endregion

            //Task 4 – Season Detector with Month Validation

            #region
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
            #endregion

            //Task 5 – Sum of Even and Odd Numbers

            #region
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

            #endregion

            //Task 6 – Password Retry System

            #region
            int correctPassword = 1234;
            int attempts = 0;
            
            while (attempts < 3)
            {
                Console.WriteLine("Enter password: ");
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
            #endregion


            //Task 7 – Simple Calculator

            #region
            while (true)
            {
                Console.WriteLine("Enter operator (+, -, *, /) or 'exit' to quit: ");
                string op = Console.ReadLine();

                if (op.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.WriteLine("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
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


            #endregion


            //Task 8 – Prime Number Checker in a Range


            #region

            Console.WriteLine("Enter start of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            bool foundAnyPrime = false;

            Console.WriteLine("Prime numbers in range: ");


            for (int numb = start; numb <= end; numb++)
            {

                bool isPrime = true;


                if (numb > 1)
                {

                    for (int divisor = 2; divisor < numb; divisor++)
                    {
                        if (numb % divisor == 0)
                        {

                            isPrime = false;
                            break;
                        }
                    }
                }
                else
                {

                    isPrime = false;
                }


                if (isPrime)
                {
                    Console.WriteLine($"{numb} ");
                    foundAnyPrime = true;
                }
            }


            if (!foundAnyPrime)
            {
                Console.WriteLine("No prime numbers found");
            }
            else
            {
                Console.WriteLine();
            }



            #endregion


            //Task 9 – Student Grade Report

            #region
            Console.WriteLine("Enter the number of students: ");
            int M = Convert.ToInt32(Console.ReadLine());

            // Counters for each grade
            int excellent = 0, veryGood = 0, good = 0, pass = 0, fail = 0;
            int highest = 0, lowest = 100;

            // Loop through each student
            for (int i = 1; i <= M; i++)
            {
                Console.WriteLine("Enter score for student " + i + ": ");
                int score = Convert.ToInt32(Console.ReadLine());

                // Update highest and lowest
                if (score > highest) highest = score;
                if (score < lowest) lowest = score;

                // Switch statement for grading
                switch (score / 10)
                {
                    case 10:
                    case 9:
                        Console.WriteLine("Grade: Excellent");
                        excellent++;
                        break;
                    case 8:
                        Console.WriteLine("Grade: Very Good");
                        veryGood++;
                        break;
                    case 7:
                        Console.WriteLine("Grade: Good");
                        good++;
                        break;
                    case 6:
                        Console.WriteLine("Grade: Pass");
                        pass++;
                        break;
                    default:
                        Console.WriteLine("Grade: Fail");
                        fail++;
                        break;
                }
            }

            // Print report
            Console.WriteLine("\n--- REPORT ---");
            Console.WriteLine("Excellent: " + excellent);
            Console.WriteLine("Very Good: " + veryGood);
            Console.WriteLine("Good: " + good);
            Console.WriteLine("Pass: " + pass);
            Console.WriteLine("Fail: " + fail);
            Console.WriteLine("Highest: " + highest);
            Console.WriteLine("Lowest: " + lowest);

            #endregion


            //Task 10 – Mini Banking System

            #region

            // Step 1 - Login ..
            string correctPIN = "9999";
            int attemptss = 0;

            while (attemptss < 3)
            {
                Console.WriteLine("Enter PIN: ");
                string enteredPIN = Console.ReadLine();

                if (enteredPIN == correctPIN)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    attemptss++;
                    if (attemptss == 3)
                    {
                        Console.WriteLine("Card Blocked");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong PIN. Try again.");
                    }
                }
            }

            // Step 2 & 3 - Banking System
            int balance = 5000;

            // Step 4 - Transaction Log arrays
            string[] transactionTypes = new string[100];
            int[] transactionAmounts = new int[100];
            int transactionCount = 0;

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Balance: ${balance}");
                        break;

                    case 2:
                        Console.WriteLine("Enter deposit amount: ");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());

                        if (depositAmount > 0 && depositAmount <= 10000)
                        {
                            balance = balance + depositAmount;
                            transactionTypes[transactionCount] = "Deposit";
                            transactionAmounts[transactionCount] = depositAmount;
                            transactionCount++;
                            Console.WriteLine($"Deposited: ${depositAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter withdrawal amount: ");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());

                        if (withdrawAmount > 0 && withdrawAmount <= balance)
                        {
                            balance = balance - withdrawAmount;
                            transactionTypes[transactionCount] = "Withdrawal";
                            transactionAmounts[transactionCount] = withdrawAmount;
                            transactionCount++;
                            Console.WriteLine($"Withdrew: ${withdrawAmount}");
                        }
                        else
                        {
                            if (withdrawAmount <= 0)
                            {
                                Console.WriteLine("Invalid withdrawal amount");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                        }
                        break;

                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;
                }
            }

            // Step 4 - Print transaction summary
            Console.WriteLine("\nTransaction Summary:");
            for (int i = 0; i < transactionCount; i++)
            {
                Console.WriteLine($"{transactionTypes[i]}: ${transactionAmounts[i]}");
            }

            Console.WriteLine($"Final balance: ${balance}");


            #endregion



        }
    }
}
