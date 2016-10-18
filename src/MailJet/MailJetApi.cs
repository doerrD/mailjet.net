using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailJet
{
    public class MailJetApi
    {
        private IMessagesApi messages;

        public IMessagesApi Messages => this.messages ?? (this.messages = new MessagesApi(this));
    }
}
