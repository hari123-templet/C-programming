namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SWITCH CASE ON COFFE SHOP");
            float totalbill = 0.0f;
        Start:
            
            Console.WriteLine("ENTER THE COFFE WHAT YOU WANT \n 1-small ,2 - medium ,3-big ,4 - special ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("your choice is small coffe is 125rs");
                    totalbill += 125;
                    break;
                case 2:
                    Console.WriteLine("your chice is medium is 145rs");
                    totalbill += 145;
                    break;
                case 3:
                    Console.WriteLine("your choice is big is 175rs");
                    totalbill += 175;
                    break;
                case 4:
                    Console.WriteLine("your choice is special coffe is 215rs");
                    totalbill += 215;
                    break;
                default:
                    Console.WriteLine("SPRRY SIR! your choice is invalid please try again..");
                    goto Start;
            }
                Decide:
                    Console.WriteLine("do you want any other coffe \n say yes or no ");
                    string decision = Console.ReadLine().ToUpper();
                    switch(decision)
                    {
                        case "YES":
                            Console.WriteLine("SHORE SIR");
                            goto Start;
                        case "NO":
                            Console.WriteLine("shore sir ");
                            break;
                        default:
                            Console.WriteLine("your decision is invalid...\n please try again");
                            goto Decide;
                    }
            
            Console.WriteLine("your totalbill is ={0}", totalbill);
            Console.WriteLine("THANK YOU FOR SHOPPING WITH US SIR!");
        }
    }
}
