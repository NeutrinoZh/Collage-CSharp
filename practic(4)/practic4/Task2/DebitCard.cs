namespace Task2 {
    class DebitCard {
        public string cardno { get; set; }
        public Account ownedby { get; set; }
        public Customer customer { get; set; }
        public Bank[] bank { get; set; }
        public void access() { throw new NotImplementedException(); }
    }
}
