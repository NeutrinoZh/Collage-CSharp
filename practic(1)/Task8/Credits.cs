namespace Task8 {
    internal class Credits {
        public static void PrintTimeStamp(string author) {
            Console.WriteLine("Дата и время компиляции: " + DateTime.Now);
            Console.WriteLine("Автор: " + author);
        }
    }
}