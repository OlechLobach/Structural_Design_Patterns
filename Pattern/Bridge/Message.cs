using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Message
    {
        protected IMessageSender _messageSender;

        public Message(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public abstract void Send();
    }
}
