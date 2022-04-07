namespace Task3 {
    class CurrentAccount : Account {
        public string accountno { set; get; }
        public string balance { set; get; }

        public void debit() { throw new NotImplementedException(); }
        public string credit() { throw new NotImplementedException(); }
    }
}