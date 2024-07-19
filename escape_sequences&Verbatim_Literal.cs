namespace escpae_sequences
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escape sequences");
            string name = "\"HARI\"";
            // above code decades Escape sequences//
            Console.WriteLine(name);
            string name2 = "HARI\\hari";
            Console.WriteLine(name2);
            //if you want to print double slash in the console screen use  (Verbatim Literal = @ )//
            string name3 = @"hari \\ Hari || hari";
            Console.WriteLine(name3);


        }
    }
}
