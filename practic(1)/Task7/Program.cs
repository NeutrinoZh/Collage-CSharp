using Task7;
class Program
{
    public static void Main()
    {
        int fx, fy, sx, sy;

        try
        {
            Console.WriteLine("Please enter first point:");
            fx = Convert.ToInt32(Console.ReadLine());
            fy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second point:");
            sx = Convert.ToInt32(Console.ReadLine());
            sy = Convert.ToInt32(Console.ReadLine());
        } catch (FormatException)
        {
            Console.WriteLine("Incorrect data!");
            return;
        }

        Console.WriteLine((sx + sy) % 2 == (fx + fy) % 2);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}