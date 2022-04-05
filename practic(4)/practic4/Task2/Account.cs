namespace Task2 {
    class Account {
        public string type { set; get; }
        public string owner { set; get; }
        public DebitCard[] cards { set; get; }
        public ATMTransaction[] transactions { set; get; }
    }
}