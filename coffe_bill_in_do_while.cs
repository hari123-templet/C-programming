namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffe Bill program");
            float bill = 0;
            string decision = string.Empty;
            string decision2 = string.Empty;
          do 
          { 
            do
            {
                Console.WriteLine("ENTER THE COFFE NAME \n 1)small \n 2)medium \n 3)large \n 4)extra large ");
                Console.Write("Enter the choice = ");
                decision = Console.ReadLine().ToUpper();
                switch (decision)
                {

                    case "SMALL":
                        Console.WriteLine("your choice is small = 120$");
                        bill += 120;
                        break;
                    case "MEDIUM":
                        Console.WriteLine("your choice is medium = 150$");
                        bill += 150;
                        break;
                    case "LARGE":
                        Console.WriteLine("your choice is large = 170$");
                        bill += 170;
                        break;
                    case "EXTRALARGE":
                        Console.WriteLine("your choice is extra large = 210$");
                        bill += 210;
                        break;
                    default:
                        Console.WriteLine("your choice is invalid");
                        break;
                }
            } while (decision != "SMALL" && decision != "MEDIUM" && decision != "LARGE" && decision != "EXTRA LARGE");
                do
                {
                    Console.Write("DO YO WANT ANY OTHER COFFEE =  ");
                    decision2 = Console.ReadLine().ToUpper();
                     if(decision2 == "NO")
                    {
                        Console.WriteLine("THANK YOU sir........\n YOUR TOTAL BILL = {0}", bill);
                    }
                    else if (decision2 != "YES" && decision2 != "NO")
                    {
                        Console.WriteLine("YOUR CHOICE IS INVALID \n CHOOSE YES OR NO ");
                    }
                } while (decision2 != "YES" && decision2 != "NO");
           }while(decision2  == "YES");

           
        }
    }
}
