using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ShortMessage : Message
    {
        public ShortMessage(IMessageSender messageSender) : base(messageSender) { }

        public override void Send()
        {
            _messageSender.SendMessage("This is a short message");
        }
    }
}

