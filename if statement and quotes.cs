namespace quotes_and_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("single quotes and double quotes");
            // its's a single quotes
            /* it's a multi line quotes
             * and*/
            /// it's a xmp document comment////
            Console.WriteLine("IF STATEMENT AND ALSO IF ELSE STATEMENT");
            Console.WriteLine("ENTER TOUR AGE?");
            int age = int.Parse(Console.ReadLine());
            if(age >0 && age<10)
            {
                Console.WriteLine("your age is {0} \n So your BABY", age);
            }
            else if (age >10 && age <20)
            {
                Console.WriteLine("your age is {0} \n So your TOO YOUNG", age);
            }
            else if (age >20 && age <30)
            {
                Console.WriteLine("your age is {0} \n So your ready to marry", age);
            }
            else if (age > 30 && age <100 )
            {
                Console.WriteLine("your age greater than 30 \n so your aged");
            }
            else
            {
                Console.WriteLine("please enter your specipic age");
            }
        }
    }
}
