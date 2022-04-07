namespace Task3 {
    class WithdrawlTransaction : ATMTransaction {
        public int amount { set; get; }

        public void Withdrawl() { throw new NotImplementedException(); }
    }
}
