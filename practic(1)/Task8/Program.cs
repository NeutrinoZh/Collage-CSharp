using Task8;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Тип\tРазмер в байтах\t\tТип .Net\tМинимальное значение\tМаксимальное значение");
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "bool", sizeof(bool), typeof(bool), bool.FalseString, bool.TrueString);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "byte", sizeof(byte), typeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "sbyte", sizeof(sbyte), typeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "int", sizeof(int), typeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "char", sizeof(char), typeof(char), char.MinValue, char.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "short", sizeof(short), typeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "long", sizeof(long), typeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "decimal", sizeof(decimal), typeof(decimal), decimal.MinValue, decimal.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "uint", sizeof(uint), typeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "ulong", sizeof(ulong), typeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}{4}", "ushort", sizeof(ushort), typeof(ushort), ushort.MinValue, ushort.MaxValue);

        Console.WriteLine("{0, -15}{1, -15}{2, -18}{3, -30}{4}", "double", sizeof(double), typeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0, -15}{1, -15}{2, -18}{3, -30}{4}", "float", sizeof(float), typeof(float), float.MinValue, float.MaxValue);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}