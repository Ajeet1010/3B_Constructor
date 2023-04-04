namespace Interface_Access_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  1. Constructor  2. Interfaces  3. AccessModifiers  *****");
            Console.Write("Enter ur choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Constructor");
                    Constructor constructor = new Constructor(1, "Aman");
                    Console.WriteLine(constructor.ID + "  " + constructor.Name);
                    break;
            }
        }
    }
}