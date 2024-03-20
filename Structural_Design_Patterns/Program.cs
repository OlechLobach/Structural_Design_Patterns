using System;
using BridgePattern;
namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender emailSender = new EmailMessageSender();
            IMessageSender smsSender = new SMSMessageSender();

            Message shortEmailMessage = new ShortMessage(emailSender);
            Message longSMSMessage = new LongMessage(smsSender);

            shortEmailMessage.Send();
            longSMSMessage.Send();
        }
    }
}