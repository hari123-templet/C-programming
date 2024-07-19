namespace place_holder_syntax
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your First name = ");
            string firstname = Console.ReadLine();
            Console.Write("Enter your Lastname = ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}",firstname,lastname);
        }
    }
}
