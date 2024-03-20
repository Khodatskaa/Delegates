namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard("1234-5678-9012-3456", "John Doe", DateTime.Now.AddYears(3), "5864", 1000);

            card.RechargeEvent += RechargeEventHandler;
            card.ExpenditureEvent += ExpenditureEventHandler;
            card.CreditUtilizationEvent += CreditUtilizationEventHandler;
            card.LimitReachedEvent += LimitReachedEventHandler;
            card.PINChangedEvent += PINChangedEventHandler;

            card.Recharge(500); 
            card.Spend(200);    
            card.UtilizeCredit(800); 
            card.ChangePIN("9271");  
        }

        static void RechargeEventHandler(object sender, decimal amount)
        {
            Console.WriteLine($"Recharge of {amount:C} was successful.");
        }

        static void ExpenditureEventHandler(object sender, decimal amount)
        {
            Console.WriteLine($"Expenditure of {amount:C} was successful.");
        }

        static void CreditUtilizationEventHandler(object sender, decimal amount)
        {
            Console.WriteLine($"Credit utilization of {amount:C} was successful.");
        }

        static void LimitReachedEventHandler(object sender, decimal exceededAmount)
        {
            Console.WriteLine($"Limit reached. Exceeded amount: {exceededAmount:C}");
        }

        static void PINChangedEventHandler(object sender, string newPIN)
        {
            Console.WriteLine($"PIN changed successfully. New PIN: {newPIN}");
        }
    }
}
