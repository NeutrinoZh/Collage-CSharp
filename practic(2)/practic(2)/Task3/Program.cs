using System.Text.RegularExpressions;
using Task3;
class Program {
    static void Main() {
        string? email;

        Console.WriteLine("Please enter email:");
        email = Console.ReadLine();

        if (email != null) {
            Console.WriteLine(
                Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase)
            );
        } else {
            Console.WriteLine("Incorrect!");
        }

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}