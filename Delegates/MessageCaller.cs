using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MessageCaller
    {
        public static void DirectCall(MessageModule module, string message)
        {
            module.DisplayMessage(message);
        }

        public static void DelegateCall(MessageDisplayDelegate displayDelegate, string message)
        {
            displayDelegate(message);
        }

        public static void EventSubscription(MessageModule module)
        {
            module.MessageDisplayed += HandleMessage;
        }

        public static void HandleMessage(string message)
        {
            Console.WriteLine("Received message: " + message);
        }
    }
}
