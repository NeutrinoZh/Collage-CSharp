using Task3;

class Program {
    public static void Main() {
        DateDifference date = new DateDifference(DateTime.Now.ToString(), "02 02 2023");
        Console.WriteLine(date.Difference);
        Console.ReadKey();
    }
}