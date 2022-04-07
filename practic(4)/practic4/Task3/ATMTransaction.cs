namespace Task3 {
    class ATMTransaction {
        public string transactionid { set; get; }
        public string data { set; get; }
        public string type { set; get; }

        public ATMInfo info { set; get; }
        public Account account { set; get; }

        public void modifies() { 
            if (account.type == "blocked")
                throw new BlockedAccountException();
            throw new NotImplementedException();
        }
    }
}