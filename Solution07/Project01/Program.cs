namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region creating array by asking user the numbers of rows, cols and the value of each cell finally show the array
            //Console.WriteLine("Enter the number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number of colums");
            //int cols = Convert.ToInt32(Console.ReadLine());



            //int[,] x = new int[rows, cols];

            //for (int i=0; i<rows; i++)
            //{
            //    for (int j=0; j<cols; j++)
            //    {
            //        Console.WriteLine($"Enter value for ({i} , {j} )=");
            //        x[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("  ");

            //Console.WriteLine("Your array is :");

            //Console.WriteLine("  ");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.WriteLine($"({i} , {j} ) = {x[i,j]}");

            //    }
            //}

            #endregion




            ///Student Management System Using Arrays (C#) -Assignment
            ///

            #region 
            Console.WriteLine();
            Console.WriteLine("Part-1");
            Console.WriteLine();
            string[] names = new string[5];

            Console.WriteLine("Enter name of 5 student ");

            for (int i=0; i<names.Length; i++)
            {
                Console.WriteLine($"Enter name of student {i+1} ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("student names ... ");
           

            for (int i=0; i < names.Length; i++)
            {

                Console.WriteLine($"{i+1}. {names[i]}");

            }

           ////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Part-2");
            Console.WriteLine();
            Console.WriteLine("Enter the student grade");

            int[,] grades = new int[5, 3];

            string[] subjects = { "Math", "Science", "English" };

            for (int i =0; i<5; i++)
            {
                Console.WriteLine($"Enter the grade of student {names[i]}");
               

                for (int j=0; j<3; j++)
                {
                    Console.WriteLine($"{subjects[j]} grade :  ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            ////////////////////////////////////////////////////////////
            Console.WriteLine("Part-3");
            Console.WriteLine();
            Console.WriteLine("Student grades:");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student: {names[i]}");
                Console.WriteLine($"Math: {grades[i, 0]}");
                Console.WriteLine($"Science: {grades[i, 1]}");
                Console.WriteLine($"English: {grades[i, 2]}");
                Console.WriteLine();
            }

            //////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Part-4");
            Console.WriteLine();
            Console.WriteLine("Student Averages:");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
                double average = sum / 3.0;

                Console.WriteLine($"Student: {names[i]}");
                Console.WriteLine($"Average: {average}");
                Console.WriteLine();
            }

            /////////////////////////////////////////////////
            Console.WriteLine("Part-5");
            Console.WriteLine();
            Console.WriteLine("Jagged Array - different number of subjects per student:");
            Console.WriteLine();


            int[][] jagGrades = new int[5][];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Student: {names[i]}");
                Console.WriteLine($"How many subjects does {names[i]} have? ");
                int numSubjects = Convert.ToInt32(Console.ReadLine());

                jagGrades[i] = new int[numSubjects];
                for (int j = 0; j < numSubjects; j++)
                {
                    Console.WriteLine($" Subject {j + 1} grade: ");
                    jagGrades[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Student Subjects and Grades:");
            Console.WriteLine();

            for (int i = 0; i < jagGrades.Length; i++)
            {
                Console.WriteLine($"Student: {names[i]}");
                Console.WriteLine($"Number of subjects: {jagGrades[i].Length}");
                Console.WriteLine("Grades: ");


                for (int j = 0; j < jagGrades[i].Length; j++)
                {
                    Console.WriteLine($"{jagGrades[i][j]} ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }


            /////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Part-6");
            Console.WriteLine();

            Console.Write("Enter student name to search: ");
            string searchName = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i]==searchName)
                {
                    Console.WriteLine($"Student found at index {i}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found");
            }

            /////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Part-7");
            Console.WriteLine();

            int highestGrade = grades[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grades[i, j] > highestGrade)
                    {
                        highestGrade = grades[i, j];
                    }
                }
            }

            Console.WriteLine($"The highest grade in the system is: {highestGrade}");

            //////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Bonus tasks");
            Console.WriteLine();

            // 1. Sort students alphabetically
            string[] sortedNames = (string[])names.Clone();
            Array.Sort(sortedNames);
            Console.WriteLine("1. Students sorted alphabetically:");
            for (int i = 0; i < sortedNames.Length; i++)
            {
                Console.WriteLine($"   {i + 1}. {sortedNames[i]}");
            }
            Console.WriteLine();

            // 2. Find the student with the highest average
            double highestAvg = 0;
            string bestStudent = "";
            for (int i = 0; i < 5; i++)
            {
                int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
                double avg = sum / 3.0;

                if (avg > highestAvg)
                {
                    highestAvg = avg;
                    bestStudent = names[i];
                }
            }
            Console.WriteLine($"2. Student with the highest average: {bestStudent} ({highestAvg})");
            Console.WriteLine();

            // 3. Count how many students passed (average >= 50)
            int passCount = 0;
            for (int i = 0; i < 5; i++)
            {
                int sum = grades[i, 0] + grades[i, 1] + grades[i, 2];
                double avg = sum / 3.0;

                if (avg >= 50)
                {
                    passCount++;
                }
            }
            Console.WriteLine($"3. Number of students who passed: {passCount} out of 5");





            #endregion






        }
    }
}
