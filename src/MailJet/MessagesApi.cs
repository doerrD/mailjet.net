using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailJet.Model.Messages;

namespace MailJet
{
    public class MessagesApi : IMessagesApi
    {
        private readonly MailJetApi mailJetApi;

        public MessagesApi(MailJetApi mailJetApi)
        {
            if (mailJetApi == null)
            {
                throw new ArgumentNullException(nameof(mailJetApi));
            }

            this.mailJetApi = mailJetApi;
        }

        public Task SendAsync(MailJetMessage message)
        {

        }
    }
}
