namespace implicipt_and_explicipt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPLICIPT AND EXPLICIPT CONVERSIONS");
            int number = 143;
            float conversionnumber = number;
            //Implicipt conversion is can directly convert into small data type to bigger data type //
            // int is small data type then the float data type ,So we can easily convert//
            Console.WriteLine("converted number = {0}", conversionnumber);
            float number2 = 14248243.34f;
            int conversionnumber2 = (int)number2;
            // we will loss the after the decimal values //
            //also we can use Convert.ToInt32(number2)explicipt conversion ,it is second methood to the //
            Console.WriteLine("Conversion number2 = {0}", conversionnumber2);
            string number3 = "100";
            int conversion = COnvert.ToInt (number3);
            // using TryParse(givennumber , out coversionnumber) this is a tryparse method //
            
            Console.WriteLine("Conversion number3 = {0}", conversion);

            
            
        }
    }
}
