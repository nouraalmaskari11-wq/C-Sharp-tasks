using System.Diagnostics;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region creating file ..adding info in  it ... show the file content 
            //File.Create("test01.txt");


            //string[] names =
            //{
            //    "huda",
            //    "nuor",
            //    "moza",
            //    "sumaia"
            //};


            //File.WriteAllLines("test01", names);



            //string[] mynames = File.ReadAllLines("test01");

            //for( int i =0; i<mynames.Length; i++) {
            //    Console.WriteLine(mynames[i]);
            //}

            #endregion



            #region
            try
            {
                string[] Exam = { "Exame01.txt", "Exame02.txt", "Exame03.txt", "Exame04.txt", "Exame05.txt" };


                foreach (string exam in Exam)
                {
                    using (File.Create(exam)) { }
                    File.WriteAllText(exam, $"This is {exam}");
                }

                Console.WriteLine("Choose the Exam you want >> (Exame01.txt, Exame02.txt, Exame03.txt, Exame04.txt, Exame05.txt)");

                string chose = Console.ReadLine();

                if (Array.Exists(Exam, exam => exam == chose))
                {
                    Console.WriteLine($"You selected: {chose}");
                    string content = File.ReadAllText(chose);
                    Console.WriteLine(content);


                    if (File.Exists(chose))
                    {

                        Process.Start(new ProcessStartInfo(chose) { UseShellExecute = true });
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion





            }
    }
}
