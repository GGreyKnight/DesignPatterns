using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInversion
{
    public class SmsNotification : INotificationSender
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"Sending sms notification to user : {user.Name}");
        }
    }
}
