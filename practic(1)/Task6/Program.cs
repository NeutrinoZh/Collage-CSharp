using System.Text.RegularExpressions;
using Task6;

class Program {
    const int redMask = 0xFF0000,
              greenMask = 0x00FF00,
              blueMask = 0xFF;
    public static void Main() {
        string? hex = Console.ReadLine();
        
        if (hex == null || !Regex.IsMatch(hex, @"^[a-f0-9]{6}$", RegexOptions.IgnoreCase)) {
            Console.WriteLine("Incorrect data!");
            return;
        }
        
        int color = Convert.ToInt32(hex, 16);

        int r = (color & redMask) >> 16,
            g = (color & greenMask) >> 8,
            b = (color & blueMask);

        Console.WriteLine("R:" + r);
        Console.WriteLine("G:" + g);
        Console.WriteLine("B:" + b);

        Credits.PrintTimeStamp("Тертичний Евгений");
    } 
}