namespace do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userchoice4 = string.Empty;
            do
            {
                Start:
                string userchoice2 = string.Empty;
                string userchoice3 = string.Empty;
                
                Console.WriteLine("say to printing the even numbers or odd numbers");
                string userchoice = Console.ReadLine().ToUpper();
                if (userchoice == "EVEN")
                {
                    do
                    {
                        int startingnumber = 0;
                        Console.Write("enter the final nummber = ");
                        int evennumbers = int.Parse(Console.ReadLine());
                        while (startingnumber <= evennumbers)
                        {
                            Console.Write(startingnumber + " ");
                            startingnumber += 2;
                        }
                        do
                        {
                            Console.WriteLine("\n DO YOU WANT TO CONTINUE EVEN NUMBERS yes or no ");
                            userchoice3 = Console.ReadLine().ToUpper();
                            if (userchoice3 != "YES" && userchoice3 != "NO")
                            {
                                Console.WriteLine("invalid choice try again say yes or no");
                            }
                        }
                        while (userchoice3 != "YES" && userchoice3 != "NO");
                    }
                    while (userchoice3 == "YES");

                }
                else if (userchoice == "ODD")
                {
                    do
                    {
                        int startingnumber2 = 1;
                        Console.Write("enter the final number = ");
                        int oddnumbers = int.Parse(Console.ReadLine());
                        while (startingnumber2 <= oddnumbers)
                        {

                            Console.Write(startingnumber2 + " ");
                            startingnumber2 += 2;
                        }
                        do
                        {
                            Console.WriteLine("\n DO YOU WANT TO CONTINUE ODD NUMBERS YES OR NO ");
                            userchoice2 = Console.ReadLine().ToUpper();
                            if (userchoice2 != "YES" && userchoice2 != "NO")
                            {
                                Console.WriteLine("invalid choice");
                            }
                        }
                        while (userchoice2 != "YES" && userchoice2 != "NO");
                    }
                    while (userchoice2 == "YES");
                }
                else
                {
                    Console.WriteLine("invalid Choice \n just type even or odd");
                    goto Start;
                }
                do
                {
                    Console.WriteLine("DO YOU WNAT TO RUN THIS PROGRAM AGAIN...YES OR NO");
                    userchoice4 = Console.ReadLine().ToUpper();
                    if (userchoice4 != "YES" && userchoice4 != "NO")
                    {
                        Console.WriteLine("invalid choice try again");
                    }
                } while (userchoice4 != "YES" && userchoice4 != "NO");
            } while (userchoice4 == "YES");

        }
    }
}
