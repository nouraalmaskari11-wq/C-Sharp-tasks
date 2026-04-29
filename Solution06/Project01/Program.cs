namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Name = new string [5];

            for (int i=0; i < Name.Length; i++)
            {
                Console.WriteLine("Enter your Name");
                Name[i]= Convert.ToString(Console.ReadLine());
            }


            Console.WriteLine(" Name entered are >>>");

                foreach (string cup in Name)
            {
                Console.WriteLine(cup);
            }






        }
    }
}
