using Task4;
class Program {
    static int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
    public static void Main() {
        Random random = new Random();
        int number = random.Next() % 37;

        if (number == 0) Console.WriteLine("Выплатить 0");
        else if (number == 1) Console.WriteLine("Выплатить 00");
        else {
            number -= 1;

            Console.WriteLine("Выпало: " + number);
            Console.WriteLine("Выплатить " + number);

            if (red.Contains(number)) Console.WriteLine("Выплатить Red");
            else Console.WriteLine("Выплатить Black");

            if (Convert.ToBoolean(number & 1)) Console.WriteLine("Выплатить Odd");
            else Console.WriteLine("Выплатить Even");

            if (number <= 18) Console.WriteLine("Выплатить от 1 до 18");
            else Console.WriteLine("Выплатить от 19 до 36");
        }

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}