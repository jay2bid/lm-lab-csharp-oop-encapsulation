using System;
namespace Encapsulation.Models
{
    public class DodgyBankAccount
    {

        //These class properties are all public, these are sensitive information and should be private on.

        public string AccountNumber;
        public int AccountBalance;


        public int RewardAmount = 50;

        public DodgyBankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            AccountBalance = 0;
        }

        public void DepositAmount(int amount)
        {
            AccountBalance += amount;
            AddReward();
        }

        public void GetAccountBalanceDetails()
        {
            Console.WriteLine($"Your account balance is {AccountBalance}");
        }

        public void DebitAmount(int amount)
        {
            AccountBalance -= amount;
        }
        //Assuming rewards are based on deposits Add reward should only be able to be used in the deposit method and should also be private
        public void AddReward()
        {
            AccountBalance += RewardAmount;
        }
    }
}
