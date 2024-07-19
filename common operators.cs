namespace common_operators
{
    internal class Program
    {
        static void Main()
        { Start:
            int num1, num2, num3,decision ;
            Console.Write("\"COMMON OPERATORS\" = \n assingment operators - '=' \n arthmetic operators - '+,-,*,%,/' \n comparision operators - '==,!=,>>,<< ,<,>' \n Conditional operators -' && ||'\n ASSIGNMENT OPERATORS - \n ENTER THE VALUE OF NUM1 = ");
            num1 = int.Parse(Console.ReadLine());
            // ' = ' is an assignment operator num1 value assigned //
            Console.Write("ENTER THE VALUE OF NUM2 = ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("num1 + num2 = {0} \n num1 - num2 ={1} \n num1 * num2 = {2} \n num1 / num2 = {3} \n num1 % num2 = {4} ", num1 + num2, num1 - num2, num1 * num2, num1 / num2, num1 % num2);
            Console.WriteLine("COMPARISION OPERATORS = ");
            if (num1 == num2)
            {
                Console.WriteLine("number 1 is equal to the number2");
            }
            else if (num2 != num1)
                // != it means number1 not equal to number2//
            {
                if (num1 < num2)
                // '>' it's an comparision operator ,it's compares the num1 and num2//
                {
                    Console.WriteLine("number1 is less than number2");
                }
                else if (num2 < num1)
                {
                    Console.WriteLine("number 2 is les than the number1");
                }
            }
            Console.Write("'CONDITIONAL OPERATORS ' Enter the value of number3 = ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 == num2 && num1 != num3)
            // && is a conditional operator like the both given conditions are should be accepts //
            {
                Console.WriteLine("num1 and num2  are same");
            }
            else if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("number 1 equals to number2 and  number3");
            }
            else if (num1 == num2 && num1 != num2) 
            {
                Console.WriteLine("num1 equals to num2");
            }
            else if (num1 == num3)
            {
                Console.WriteLine("num1 equals to num2");
            }
            else if (num2== num3)
            {
                Console.WriteLine("num2 equals number 3");
            }
            else { Console.WriteLine("THREE NUMBERS ARE DIFFERENT"); }
            Decision:
            Console.Write("DO YOU WANT TO RUN AGAIN THIS PROGRAM  with different values - 1  means yes OR 0 means no \n decision = ");
            decision = int.Parse( Console.ReadLine());
            if (decision == 1)
            {
                goto Start;
            }
            else if(decision == 0)
            {
                Console.WriteLine("ok sir");
            }
            else
               {
                    Console.WriteLine("PLEASE TYPE JUST 1 OR 0 ");
                goto Decision;
               }
            

        }
    }
}
