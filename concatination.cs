namespace concate;

internal class Program
{
    static void Main()
    {
        Console.Write("Hello \n enter your First name = ");
        string firstname = Console.ReadLine();
        Console.Write("Enter your Last name = ");
        string lastname = Console.ReadLine();
        Console.WriteLine("Hello {0}  " ,firstname);
    }
}
