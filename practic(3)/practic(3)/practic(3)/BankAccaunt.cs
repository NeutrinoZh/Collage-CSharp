namespace Task1 {
    enum Currencies {
        UAH,
        USD,
        EUR
    }
    class BankAccaunt {
        private int id;
        private decimal balance;
        private Currencies currency;

        public int Id() { return id; }
        public decimal Balance() { return balance; }
        public Currencies Currency() { return currency; }

        private static int i = 1;

        public BankAccaunt() {
            this.id = i++;
            this.balance = 0;
            this.currency = Currencies.UAH;
        }

        public void Deposit(decimal amount) {
            this.balance += amount;

            if ((currency == Currencies.UAH && this.balance >= 50000)  ||
                (currency == Currencies.USD && this.balance >= 2000) ||
                (currency == Currencies.EUR && this.balance >= 2000)
            ) {
                Console.WriteLine("Інформація про дану транзакцію буде передана в податкову службу");
            }
        }

        public void Withdraw(decimal amount) {
            if (this.balance < amount) {
                Console.WriteLine("Недостатньо коштів");
                return;
            }
            this.balance -= amount;
        } 

        public void ShowInfo() {
            Console.WriteLine("Рахунок:" + this.balance);
        }
    }
}