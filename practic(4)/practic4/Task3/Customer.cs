namespace Task3 {
    class Customer {
        public string name { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public Bank bank { get; set; }
        public DebitCard[] cards { get; set; }

        public void owns() { throw new NotImplementedException(); }
    }
}