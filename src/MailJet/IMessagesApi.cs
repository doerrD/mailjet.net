using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailJet.Model.Messages;

namespace MailJet
{
    public interface IMessagesApi
    {
        Task SendAsync(MailJetMessage message);
    }
}
