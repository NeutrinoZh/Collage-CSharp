namespace Task2 {
    class QueryTransaction : ATMTransaction {
        public string query { get; set; }
        public string type { get; set; }

        public void queryprocessing() { throw new NotImplementedException(); }
    }
}
