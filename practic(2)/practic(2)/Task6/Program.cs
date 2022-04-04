using Task6;
class Program {
    public static void Main() {
        int num;
        try {
            num = Convert.ToInt32(Console.ReadLine());
        } catch (FormatException) {
            Console.WriteLine("Incorrect data!");
            return;
        }

        string bin = "";
        while (num != 1) {
            bin = bin.Insert(0, Convert.ToString(num % 2));
            num /= 2;
        }

        Console.WriteLine(bin);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}