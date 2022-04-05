namespace Task2 {
    class ATMTransaction {
        public string transactionid { set; get; }
        public string data { set; get; }
        public string type { set; get; }

        public ATMInfo info { set; get; }

        public void modifies() { throw new NotImplementedException(); }
    }
}