namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Task 1 >>>>>

            #region
            int[] Num = { 50, 32, 22, 55, 10 };

            Console.WriteLine("Numbers are >>>");

            for (int i = 0; i < Num.Length; i++)
            {
                Console.WriteLine(i);

            }

            #endregion



            //Task 2 >>>>

            #region
            int[] Num1 = { 50, 32, 22, 55, 10 };

            Console.WriteLine("  Numbers are >>>");

            foreach (int cup in Num1)
            {
                Console.WriteLine(cup);
            }

            #endregion


            //Task 3 >>>>

            #region

            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine(" Numbers entered are >>>");

            foreach (int cup in num)
            {
                Console.WriteLine(cup);
            }

            #endregion



            //Task 4 >>>>

            #region

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }



            Console.WriteLine($"sum = {sum} ");
            #endregion



            //Task 5 >>>>

            #region

            int[] num22 = new int[5];

            for (int i = 0; i < num22.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                num22[i] = Convert.ToInt32(Console.ReadLine());
            }


            int max = num22[0];

            for (int i = 0; i < num22.Length; i++)
            {
                if (num22[i] > max)
                {
                    max = num22[i];
                }
            }

            Console.WriteLine($" max = {max} ");

            #endregion



            //Task 6 >>>>

            #region

            int[] nums = new int[5];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }


            int min = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            Console.WriteLine($" min = {min} ");

            #endregion



            //Task 7 >>>>

            #region

            int[] nums1 = new int[10];

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                nums1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" even numbers are :");

            foreach (int cup in nums1)
            {
                if (cup % 2 == 0)
                {
                    Console.WriteLine(cup);
                }
            }

            #endregion


            //Task 8 >>>>

            #region

            int[] cat = new int[5];
            int sum1 = 0;

            for (int i = 0; i < cat.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                cat[i] = Convert.ToInt32(Console.ReadLine());
                sum1 += cat[i];
            }


            double ave = (double)sum1 / cat.Length;
            Console.WriteLine($"the average of the numbers is = {ave}");


            #endregion



            //Task 9 >>>>

            #region

            int[] cat12 = { 10, 30, 5, 44, 73 };

            Console.WriteLine("the array is :");
            for (int i = 0; i < cat12.Length; i++)
            {

                Console.WriteLine(cat12[i] + " ");

            }

            Console.WriteLine("the reversed array of the original array is :");
            for (int i = cat12.Length - 1; i >= 0; i--)
            {

                Console.WriteLine(cat12[i] + " ");

            }

            #endregion


            //Task 10 >>>>

            #region

            int[] cat123 = { 10, 30, 5, 44, 73 };

            Console.WriteLine("enter the number you want to search :");
            int search = Convert.ToInt32(Console.ReadLine());

            int index = Array.IndexOf(cat123, search);

            if (index != -1)
            {
                Console.WriteLine($"number {search} found at index {index}");
            }
            else
            {
                Console.WriteLine($"number not found");
            }
           
            #endregion






        }
    }
}
