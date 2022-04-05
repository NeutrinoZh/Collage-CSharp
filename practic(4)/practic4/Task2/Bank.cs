namespace Task2 {
    class Bank {
        public int code { get; set; }
        public string address { get; set; }

        public DebitCard card { get; set; }
        public Customer customer { get; set; }

        public void manages() { throw new NotImplementedException(); }
        public void maintains() { throw new NotImplementedException(); }
    }
}