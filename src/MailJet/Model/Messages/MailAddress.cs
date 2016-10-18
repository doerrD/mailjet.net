using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailJet.Model.Messages
{
    public class MailAddress
    {
        public MailAddress()
        {
        }

        public MailAddress(string email, string name = null)
        {
            if (!this.IsValidEmail(email))
            {
                throw new ArgumentException("Email not valid email address");
            }

            this.Email = email;
            this.Name = name;
        }

        public string Email { get; set; }
        public string Name { get; set; }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
