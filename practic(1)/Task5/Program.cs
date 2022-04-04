using Task5;
class Program
{
    public static void Main()
    {
        DateTime birthday = new DateTime(2005, 2, 2);
        Console.WriteLine((DateTime.Now - birthday).Days + " Days");

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}