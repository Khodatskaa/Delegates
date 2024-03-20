namespace Delegates
{
    internal class Program
    {
        static void Main()
        {
            MessageModule module = new MessageModule();

            MessageCaller.DirectCall(module, "This is a direct call.");

            MessageDisplayDelegate displayDelegate = new MessageDisplayDelegate(MessageCaller.HandleMessage);
            MessageCaller.DelegateCall(displayDelegate, "This is a delegate call.");

            MessageCaller.EventSubscription(module);
            module.DisplayMessage("This is a message with event subscription.");
        }
    }
}
