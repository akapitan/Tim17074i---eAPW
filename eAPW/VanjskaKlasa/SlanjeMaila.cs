using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace VanjskaKlasa
{
    public class SlanjeMaila
    {

        public bool posaljiMail(string primateljEmail, string mailBody)
        {
            MailMessage mail = new MailMessage("akapitan@foi.hr", primateljEmail);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "mail.foi.hr";
            client.Credentials = new System.Net.NetworkCredential("akapitan", "foi-OranGisi13");
            mail.Subject = "Stigli su Vaši naručeni proizvodi";

            mail.Body = mailBody;
            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
    }
}
