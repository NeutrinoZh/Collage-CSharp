namespace Task3 {
    class BlockedAccountException : System.Exception {
        private static readonly string DefaultMessage = "The transaction cannot be performed on a blocked account";

        public string AccountName { get; set; }
        public string TransactionType { get; set; }

        public BlockedAccountException() : base(DefaultMessage) { }
        public BlockedAccountException(string message) : base(message) { }

        public BlockedAccountException(string accountName, string transactionType)
        : base(DefaultMessage)
        {
            AccountName = accountName;
            TransactionType = transactionType;
        }
    }
}
