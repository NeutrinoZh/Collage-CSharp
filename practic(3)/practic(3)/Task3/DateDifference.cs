namespace Task3 {
    class DateDifference {
        private uint difference;
        
        public uint Difference {
            get { return difference; }
        }

        public DateDifference(string first, string second) {
            if (
                DateTime.TryParse(first, out DateTime first_date) &&
                DateTime.TryParse(second, out DateTime second_date)
            ) {
                difference = (uint)Math.Abs((first_date - second_date).Days);
            } else {
                Console.WriteLine("Incorrect data!");
            }
        }
    }
}