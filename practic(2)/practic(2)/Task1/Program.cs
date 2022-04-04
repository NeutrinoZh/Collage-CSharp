using Task1;
class Program
{
    public static void Main()
    {
        List<double> numbers = new List<double>();
        while (true)
        {
            try
            {
                string? input = Console.ReadLine();
                if (input != "")
                {
                    numbers.Add(Convert.ToDouble(input));
                }
                else
                {
                    break;
                }
            } catch (FormatException)
            {
                Console.WriteLine("Incorrect data!");
            }
        }

        double sum = 0;
        foreach(double el in numbers)
        {
            sum += el;
        }

        Console.WriteLine(sum);
        Console.WriteLine(Math.Round(sum, 1));

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}