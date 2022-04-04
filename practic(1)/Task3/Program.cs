using Task3;
class Program
{
    private const double R = 6371.01;

    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    private static double toRadians(double angle) {
        return (Math.PI / 180) * angle;
    }

    private static double Dist(Point A, Point B)
    {
        return R * Math.Acos(
            Math.Sin(A.x) * Math.Sin(B.x) + 
            Math.Cos(A.x) * Math.Cos(B.x) *
            Math.Cos(A.y - B.y)
        );
    }

    private static double S(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public static void Main()
    {
        Point A, B, C, D;
        
        try
        {
            Console.WriteLine("Please enter point A:");
            A = new Point(
                toRadians(Convert.ToDouble(Console.ReadLine())),
                toRadians(Convert.ToDouble(Console.ReadLine()))
            );

            Console.WriteLine("Please enter point B:");
            B = new Point(
                toRadians(Convert.ToDouble(Console.ReadLine())),
                toRadians(Convert.ToDouble(Console.ReadLine()))
            );

            Console.WriteLine("Please enter point C:");
            C = new Point(
                toRadians(Convert.ToDouble(Console.ReadLine())),
                toRadians(Convert.ToDouble(Console.ReadLine()))
            );

            Console.WriteLine("Please enter point D:");
            D = new Point(
                toRadians(Convert.ToDouble(Console.ReadLine())),
                toRadians(Convert.ToDouble(Console.ReadLine()))
            );
        } catch (FormatException) {
            Console.WriteLine("Incorrect data!");
            return;
        }

        double AB, AD, BD, CB, CD;

        AB = Dist(A, B);
        AD = Dist(A, D);
        BD = Dist(B, D); 
        CB = Dist(C, B);
        CD = Dist(C, D);

        double ABD = S(AB, AD, BD);
        double BCD = S(CB, BD, CD);

        Console.Write("Result: ");
        Console.WriteLine(ABD + BCD);

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}