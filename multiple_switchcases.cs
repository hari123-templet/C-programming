namespace switch_case_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch case");
            Start:
            Console.WriteLine("enter any one number in this numbers\n 10 ,20 ,30");
            int number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("your number is {0}", number);
                    break;
                // we can invite multiple statements in single case//
                default:
                    Console.WriteLine("your number is invalid \n please try again");
                    goto Start;
            }
        }
    }
}
