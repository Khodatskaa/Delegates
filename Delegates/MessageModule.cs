using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MessageDisplayDelegate(string message);

    public class MessageModule
    {
        public event MessageDisplayDelegate MessageDisplayed;

        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message displayed: " + message);
            MessageDisplayed?.Invoke(message);     //.Invoke() - to call the delegate
        }
    }
}
