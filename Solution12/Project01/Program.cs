namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<string> names = new Stack<string>();
            names.Push("Khalid");
            names.Push("Noura");
            names.Push("Talid");
            names.Push("Abdullah");
            names.Push("Alameer");

            while (true)
            {
                Console.WriteLine("\nChoose your Action please.");
                Console.WriteLine("1. Add Name");
                Console.WriteLine("2. Print Last Name added"); 
                Console.WriteLine("3. Delete last name");
                Console.WriteLine("4. Show all elements");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name to add: ");
                        string name = Console.ReadLine();
                        names.Push(name);
                        Console.WriteLine($"Name added: {name}");
                        break;

                    case 2:
                        if (names.Count > 0)
                        {
                            Console.WriteLine($"Top name is: {names.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty!");
                        }
                        break;

                    case 3:
                        if (names.Count > 0)
                        {
                            string removeName = names.Pop();
                            Console.WriteLine($"Deleted last name: {removeName}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty! Nothing to delete.");
                        }
                        break;

                    case 4:
                        if (names.Count > 0)
                        {
                            Console.WriteLine("\nAll names in stack (top to bottom):");
                            foreach (string n in names)
                            {
                                Console.WriteLine(n);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty!");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 5");
                        break;
                }
            }
        }
    }
}