using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class CreditCard
    {
        public string CardNumber { get; private set; }
        public string OwnerName { get; private set; }
        public DateTime Validity { get; private set; }
        public string PIN { get; private set; }
        public decimal CreditLimit { get; private set; }
        public decimal AvailableFunds { get; private set; }

        public event EventHandler<decimal> RechargeEvent;
        public event EventHandler<decimal> ExpenditureEvent;
        public event EventHandler<decimal> CreditUtilizationEvent;
        public event EventHandler<decimal> LimitReachedEvent;
        public event EventHandler<string> PINChangedEvent;

        public CreditCard(string cardNumber, string ownerName, DateTime validity, string pin, decimal creditLimit)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            Validity = validity;
            PIN = pin;
            CreditLimit = creditLimit;
            AvailableFunds = 0; 
        }

        public void Recharge(decimal amount)
        {
            AvailableFunds += amount;
            OnRechargeEvent(amount);
        }

        public void Spend(decimal amount)
        {
            if (AvailableFunds >= amount)
            {
                AvailableFunds -= amount;
                OnExpenditureEvent(amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }

        public void UtilizeCredit(decimal amount)
        {
            if (AvailableFunds + amount <= CreditLimit)
            {
                AvailableFunds += amount;
                OnCreditUtilizationEvent(amount);
            }
            else
            {
                OnLimitReachedEvent(CreditLimit - AvailableFunds);
            }
        }

        public void ChangePIN(string newPIN)
        {
            PIN = newPIN;
            OnPINChangedEvent(newPIN);
        }

        protected virtual void OnRechargeEvent(decimal amount)
        {
            RechargeEvent?.Invoke(this, amount);
        }

        protected virtual void OnExpenditureEvent(decimal amount)
        {
            ExpenditureEvent?.Invoke(this, amount);
        }

        protected virtual void OnCreditUtilizationEvent(decimal amount)
        {
            CreditUtilizationEvent?.Invoke(this, amount);
        }

        protected virtual void OnLimitReachedEvent(decimal exceededAmount)
        {
            LimitReachedEvent?.Invoke(this, exceededAmount);
        }

        protected virtual void OnPINChangedEvent(string newPIN)
        {
            PINChangedEvent?.Invoke(this, newPIN);
        }
    }

}
