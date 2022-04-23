﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EmailSender
    {
        private void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to smtp server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inserting credentials");
        }

        public void SendEmail(string to, string title, string body)
        {
            ConnectToSmtpServer();
            InsertCredentials();

            Console.WriteLine($"Sendint email to: {to}, {title}, {body}");

            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnected from the server");
        }
    }
}
