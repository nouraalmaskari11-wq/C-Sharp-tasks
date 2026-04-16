namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region for loop
            /* for (int i = 0; i < 5; i++)
             {

                 Console.WriteLine("Enter First Number");
                 int Num = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter second Number");
                 int Num2 = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine($"first num + second num = {Num + Num2}");
                 Console.WriteLine($"first num - second num = {Num - Num2}");
                 Console.WriteLine($"first num * second num = {Num * Num2}");

                 if (Num2 == 0)
                 {
                     Console.WriteLine(" can not divided by 0");
                 }

                 else
                 {
                     Console.WriteLine($"first num / second num = {Num / Num2}");
                 }
                 //////////////////////////////////////////////////
                 ///

                 //for (int X =1; X<5; X++)
                 //{
                 //    for (int y= 0; y < 3; y++)
                 //    {
                 //        Console.WriteLine("Hello word");
                 //    }
                 //}

             */

            ///
            #endregion


            #region for loop

            //Console.WriteLine("Enter any number: ");
            //    int number =Convert.ToInt32( Console.ReadLine());
            //    bool num = true;

            //     if (number < 2)
            //          num = false;
            //        else
            //        {

            //            for (int i = 2; i * i <= number; i++)
            //            {
            //                if (number % i == 0)
            //                {
            //                    num = false;
            //                    break;
            //                }
            //            }
            //        }

            //        if (num)
            //            Console.WriteLine("Its a prime number");


            #endregion





            #region while loop for guessing the random number

            //Random rand = new Random();
            //int randomNum = rand.Next(1, 9);
            //int attmp = 3;


            //Console.WriteLine("Enter any number");

            //while (attmp > 0)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num == randomNum)
            //    {
            //        Console.WriteLine(" your guess is correct");
            //    }
            //    else
            //    {
            //        attmp--;

            //        if (attmp >0)
            //        {
            //            Console.WriteLine("try again");
            //        }

            //        else
            //        {
            //            Console.WriteLine($"you have used all your tries. the number was {randomNum}");
            //        }

            //    }

            //}
            #endregion


            #region is the word can be deaded same from to side
            static bool Perfect(string word)
        {
            string cat = word.Replace(" ", "").ToLower();

            for (int i = 0; i < cat.Length / 2; i++)
            {
                if (cat[i] != cat[cat.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;

                
        }
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            if (Perfect(input))
                Console.WriteLine($"{input} is a perfect word (Perfect).");
            else
                Console.WriteLine($"{input} is not a Perfect.");

            #endregion



        }



    }


}

