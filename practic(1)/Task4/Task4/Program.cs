using Task4;
class Program
{
    private const double PRICE_ONE = 8.5;
    private const double DISCOUNT = 0.6;
    
    public static void Main()
    {
        double num;

        try
        {
            Console.Write("Сколько вчерашних буханок хлеба вы хотите купить? ");
            num = Convert.ToDouble(Console.ReadLine());
        } catch(FormatException)
        {
            Console.WriteLine("Incorrect data!");
            return;
        }

        double price = Math.Round(num * PRICE_ONE, 2);
        double sum = Math.Round(price * (1 - DISCOUNT), 2);

        Console.WriteLine("Цена:" + price);
        Console.WriteLine("Скидка:" + Math.Round(price * DISCOUNT, 2));
        Console.WriteLine("Итого:" + sum);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}