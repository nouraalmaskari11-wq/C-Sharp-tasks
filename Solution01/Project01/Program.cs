namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please Enter First Number !");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please Enter second Number !");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1}+ {num2}= {num1 + num2}");
            Console.WriteLine($"{num1}- {num2}= {num1 - num2}");
            Console.WriteLine($"{num1}* {num2}= {num1 * num2}");
            Console.WriteLine($"{num1}/ {num2}= {num1 / num2}");

        }
    }
}
