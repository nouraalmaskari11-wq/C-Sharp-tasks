namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 – Positive, Negative, or Zero
            Console.WriteLine("Please Enter a Number !");
            int num = Convert.ToInt32( Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }


            //Task 2 – Even or Odd
            Console.WriteLine("Please Enter an integer Number !");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 %2== 0)
            {
                Console.WriteLine("Evan Number");
            }
           
            else
            {
                Console.WriteLine("Odd Number");
            }



            //Task 3 – Student Grade System 
            Console.WriteLine("Please Enter your Score !");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score > 100 || score < 0)
            {
                Console.WriteLine("Enter Avalid score between 0 - 100");
            }
            else if (score > 90)
            {
                Console.WriteLine("Excellent");
            }

            else if (score > 75)
            {
                Console.WriteLine(" Very Good");
            }

            else if (score > 60)
            {
                Console.WriteLine("Good");
            }

            else if (score > 50)
            {
                Console.WriteLine("Pass");
            }


            else
            {
                Console.WriteLine("Fail");
            }



            //Task 4 – Simple Login System

            string corrUserName = "admin";
            int corrPassword = 1234;

            Console.WriteLine("Please enter  UserName");
            string userName = Console.ReadLine();


            Console.WriteLine("Please enter  Password");
            int password =Convert.ToInt32(Console.ReadLine());


            if (userName == corrUserName && password == corrPassword)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }


            //Task 5 – Simple ATM System

            double balance = 1000;

            Console.Write("Enter withdrawal amount: ");

            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid Amount");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient Balance");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine("Withdrawal Successful");
                    Console.WriteLine($"Remaining Balance:" + balance);
                }
            }
            else
            {
                Console.WriteLine("Invalid Amount (Please enter a valid value)");
            }


        }
    }
}
