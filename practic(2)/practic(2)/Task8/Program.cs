using System.Diagnostics;
using System.Text;

class Program {
    public static void AppendLineWithStringBullider() {
        var sb = new StringBuilder();
        for (int i = 0; i < 1_000_000; i++) {
            sb.Append((char)i);
        }
    }
    public static void AppendLineWithString() {
        string sb = "";
        for (int i = 0; i < 1_000_000; i++) {
            sb.Append((char)i);
        }
    }
    static void Main() {
        Stopwatch sw = new Stopwatch();

        sw.Start();
        AppendLineWithStringBullider();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);


        sw = new Stopwatch();

        sw.Start();
        AppendLineWithString();
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}