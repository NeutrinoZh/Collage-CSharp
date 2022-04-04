using Practic2;
class Program
{
    private static double R = 8.314;
    private static double KELVIN = 273.15;

    public static void Main()
    {
        double P, V, T;

        Console.Write("Please enter P:");
        P = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter V:");
        V = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter T:");
        T = Convert.ToDouble(Console.ReadLine()) + KELVIN;

        double result = P * V / (R * T) / 1000;
        Console.WriteLine("n = PV/RT = " + result);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}