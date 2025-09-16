using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{

    public interface ISender
    {
        void Send();
    }
    public class ReportSender
    {

        private readonly ISender sender;

        public ReportSender(ISender sender)
        {
            this.sender = sender;    
        }

        //public MailSender MailSender { get; set; }
        public void Send()
        {
            //mailSender instance'ını burada aldığım için; Büyük nesne (ReportSender) çok kullanılacak alt nesneye (MailSender) bağımlı...
            //MailSender mailSender = new MailSender();

            //İşte bağımlılığı gösteren satır:
            sender.Send();
        }
    }

    public class MailSender : ISender
    {
        public void Send() {
            Console.WriteLine("Mail ile gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }

    public class SlackSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Slack ...");
        }
    }
}
