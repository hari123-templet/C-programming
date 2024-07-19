namespace built_in_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUILT IN TYPES \n");
            int a = 0; uint b = 0; float c = 0; double d = 0.0; byte e = 0; sbyte f = 0; char g;
            Console.WriteLine("integer \nMIN value = {0} \n MAX value = {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint \nMIN value = {0} \n MAX value = {1}", uint.MinValue, uint.MaxValue); 
            Console.WriteLine("float \n MIN value = {0} \n MAX value = {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double \n MIN value = {0} \n MAX value = {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("byte\n  MIN value = {0} \n MAX value = {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte \n MIN value = {0} \n MAX value = {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("char \n MIN value = {0} \n MAX value = {1}", char.MinValue, char.MaxValue);
        }
    }
}
