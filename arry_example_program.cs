namespace arrys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRYS");
            int number = 10;
            // normal intialitation //
            int[] number2 = new int[5];
            number2[0] = 1;
            number2[1] = 2;
            number2[2] = 3;
            number2[3] = 4;
            Console.WriteLine("number1 = {0} \n number2 = {1}, \n number3 = {2} \n number4 = {3}", number2[0], number2[1], number2[2], number2[3]);
            //arry can store different types of elements in a single variable number[0] is a array//

        }
    }
}
