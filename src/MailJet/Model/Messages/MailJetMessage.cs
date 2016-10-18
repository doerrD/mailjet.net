using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailJet.Model.Messages
{
    public class MailJetMessage
    {
        public MailAddress From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public IEnumerable<MailAddress> Recipients { get; set; }
        public IEnumerable<MailAddress> Cc { get; set; }
        public IEnumerable<MailAddress> Bcc { get; set; }
        public int TemplateId { get; set; }
        public IEnumerable<string> TemplateProperties { get; set; }
    }
}
