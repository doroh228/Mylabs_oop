using System;
using System.Net;
using System.Net.Mail;
namespace Po4ta
{
    class Program
    {
        static void Main(string[] args)
        {
         
            


                MailAddress From = new MailAddress("abema.228@yandex.by", "Петя");

                // string to = Console.ReadLine();
                MailAddress To = new MailAddress("i_mashuk@mail.ru");

                MailMessage msg = new MailMessage(From, To);

                msg.Subject = "Тестовое письмо";

                // Console.WriteLine("Введите текст для письма");
                // string text = Console.ReadLine();

                msg.Body = "ВАНЯ АБЕМА";

                msg.IsBodyHtml = false;

                SmtpClient smpt = new SmtpClient("smtp.yandex.ru", 587);

                smpt.Credentials = new NetworkCredential("abema.228@yandex.by", "doroh2001");

                smpt.EnableSsl = true;
                
                smpt.Send(msg);
            

        }
    }
}
