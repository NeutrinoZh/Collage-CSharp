namespace Task2 {
    class ATMInfo {
        public string location { get; set; }
        public string managedby { get; set; }

        public ATMTransaction[] transaction { get; set; }

        public void identifies() { throw new NotImplementedException(); }
        public void transactions() { throw new NotImplementedException(); }
    }
}
