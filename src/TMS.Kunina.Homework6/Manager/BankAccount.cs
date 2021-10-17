using System;

namespace Manager
{
    public class BankAccount
    {
        public event EventHandler<bool> ProcessCompleted;

        private double money;
        private string name;

        public BankAccount(double money, string name)
        {
            this.money = money;
            this.name = name;
        }

        public void AddMoney(double money)
        {
            Console.WriteLine(name + " add " + money);
            this.money += money;
            OnProcessCompleted(true);

        }

        public void Subtract(double money)
        {
            if (this.money - money < 0)
            {
                Console.WriteLine("Insufficient funds on the account!");
                Console.WriteLine(this.name + "wants to spent " + money);
                getInfo();
                OnProcessCompleted(false);
            }
            else
            {
                this.money -= money;
                Console.WriteLine(name + " spent money =  " + money);
                OnProcessCompleted(true);
            }
        }

        public void getInfo()
        {
            Console.WriteLine("Balance of " + this.name + ": " + this.money);
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this.name, IsSuccessful);
        }
    }
}