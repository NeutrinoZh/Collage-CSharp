using Practic1;
public class Program
{
    private class Course
    {
        private string firstСurrency = "";
        private string secondCurrency = "";

        private double toFirst = 0.0;
        private double toSecond = 0.0;

        public Course(string firstСurrency, string secondСurrency, double toFirst, double toSecond)
        {
            this.firstСurrency = firstСurrency;
            this.secondCurrency = secondСurrency;
            this.toFirst = toFirst;
            this.toSecond = toSecond;
        }

        private static Course[] courses =  {
            new Course("USD", "UAH", 28.55, 28.95),
            new Course("EUR", "UAH", 32.05, 32.65),
            new Course("RUB", "UAH", 0.352, 0.382)
        };

        public static double Convert(string firstCurrency, string secondCurrency, double value)
        {
            foreach(Course course in courses) {
                if (course.firstСurrency == firstCurrency &&
                    course.secondCurrency == secondCurrency)
                {
                    return value / course.toSecond;
                }
                
                if (course.firstСurrency == secondCurrency &&
                    course.secondCurrency == firstCurrency)
                {
                    return value / course.toFirst;
                }
            }

            return 0;
        }
    }

    public static void Main()
    {
        Console.Write("Please enter cash:");
        double cash = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("From USD to UAH: " + Course.Convert("USD", "UAH", cash));
        Console.WriteLine("From EUR to UAH: " + Course.Convert("EUR", "UAH", cash));
        Console.WriteLine("From RUB to UAH: " + Course.Convert("RUB", "UAH", cash));

        Console.WriteLine("From UAH to USD: " + Course.Convert("UAH", "USD", cash));
        Console.WriteLine("From UAH to EUR: " + Course.Convert("UAH", "EUR", cash));
        Console.WriteLine("From UAH to RUB: " + Course.Convert("UAH", "RUB", cash));

        Credits.PrintTimeStamp("Тертичний Евгений");
    }
}