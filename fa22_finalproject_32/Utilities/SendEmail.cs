using System;
using System.Net.Mail;
using System.Net;

namespace SendMail
{
    public static class EmailMessaging
    {
        public static void SendEmail(String toEmailAddress, String emailSubject, String emailBody)
        {
          

            String strFromEmailAddress = "fa22team32@gmail.com";


            String strPassword = "Password32!";


            String strCompanyName = "MIS 333K Final Project";
            
            
            //Create an email client to send the emails
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                //This is the SENDING email address and password
                Credentials = new NetworkCredential(strFromEmailAddress, strPassword),
                EnableSsl = true
            };



            MailAddress senderEmail = new MailAddress(strFromEmailAddress, strCompanyName);

            //Create a new mail message
            MailMessage mm = new MailMessage();

            mm.Subject = "Team 22 - " + emailSubject;

            //Set the sender address
            mm.Sender = senderEmail;

            //Set the from address
            mm.From = senderEmail;

            //Add the recipient (passed in as a parameter) to the list of people receiving the email
            mm.To.Add(new MailAddress(toEmailAddress));

            //send the message!
            client.Send(mm);
        }
    }
}