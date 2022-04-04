using System.Text.RegularExpressions;
using Task5;
class Program {
    private static double[] frequency = {
        440.00, 493.88, 261.63,
        293.66, 329.63, 349.23,
        392.00,
        
        220.00, 246.94, 130.81,
        146.83, 164.81, 174.61,
        196.00,
        
        110.00, 123.47, 65.407,
        73.415, 82.407, 87.307,
        98.000,

        55.000, 61.735, 32.703,
        36.707, 41.203, 43.653,
        49.000 
    };

    public static void Main() {
        Console.WriteLine("Для перехода к получению частоты из ноты введите 1");
        Console.WriteLine("Для перехода к получению ноты из частоты введите 2");

        int mode;
        try {
            mode = Convert.ToInt32(Console.ReadLine());
            if (mode != 1 && mode != 2)
                throw new FormatException();
        } catch(FormatException) {
            Console.WriteLine("Некорректный ввод!");
            return;
        }

        if (mode == 1) {
            Console.WriteLine("Введите ноту:");
            string? note = Console.ReadLine();
            if (note != null && Regex.IsMatch(note, @"[a-g]\d")) {
                double frequency4 = frequency[note[0] - 'a'];
                Console.WriteLine(frequency4 / Math.Pow(2, 4 - (note[1] - 48)));
            } else {
                Console.WriteLine("Некорректный ввод!");
            }
        } else {
            Console.WriteLine("Введите частоту:");
            
            double freq;
            try {
                freq = Convert.ToDouble(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Некорректный ввод!");
                return;
            }

            int index = Array.IndexOf(frequency, freq);

            if (index != -1) {
                char c = Convert.ToChar('a' + (index % 7));
                int num = 4 - (int)index / 7;
                Console.WriteLine(c + "" + num);
            } else {
                Console.WriteLine("Ноты с такой частотой не существует!");
            }
        }

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}