using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class LongMessage : Message
    {
        public LongMessage(IMessageSender messageSender) : base(messageSender) { }

        public override void Send()
        {
            _messageSender.SendMessage("This is a long message");
        }
    }
}

