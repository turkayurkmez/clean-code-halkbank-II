// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Büyük sistemler, küçüklere değil
 * küçük nesneler, büyüklere bağımlı olsun.
 * 
 * Başka bir deyişle bağımlılık dışarıdan yönetilsin!
 */

MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
SlackSender slackSender = new SlackSender();


ReportSender reportSender = new ReportSender(mailSender);
ReportSender report2 = new ReportSender(slackSender);
ReportSender report3 = new ReportSender(whatsAppSender);


//reportSender.MailSender = mailSender;

//MailSender mailSender2 = new MailSender();
//reportSender.MailSender = mailSender2;,
reportSender.Send();
report2.Send();
report3.Send();

