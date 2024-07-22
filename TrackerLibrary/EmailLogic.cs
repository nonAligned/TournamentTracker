using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using FluentEmail.Smtp;
using FluentEmail.Core;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static async void SendEmail(string sender, string recipientAddress, string recipientName, string subject, string body)
        {
            var client = new SmtpSender(() => new SmtpClient(host: "localhost")
            {
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Port = 25
            });

            Email.DefaultSender = client;

            var mail = await Email
                .From(emailAddress: sender)
                .To(emailAddress: recipientAddress, name: recipientName)
                .Subject(subject)
                .Body(body)
                .SendAsync();
        }
    }
}
