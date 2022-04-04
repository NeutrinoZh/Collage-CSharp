using Task7;
class Program {
    private const int fix_deposit = 20;

    public static void Main() {
        double water, cash = fix_deposit,
            first, second, third, fourth;

        try {
            water = Convert.ToDouble(Console.ReadLine());
        } catch (FormatException) {
            Console.WriteLine("Incorrect data!");
            return;
        }

        first = water > 30 ? 30 : water;
        water -= 30;
             
        second = water > 20 ? 20 : (water < 0 ? 0 : water);
        water -= 20;

        third = water > 10 ? 10 : (water < 0 ? 0 : water);
        water -= 10;

        fourth = (water < 0 ? 0 : water);

        cash += 11.77 * first;
        cash += 13.22 * second;
        cash += 15.06 * third; 
        cash += 18.89 * fourth;

        Console.WriteLine(cash);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}