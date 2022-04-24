using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInversion
{
    public class AutenticationManager
    {
        private INotificationSender notificationSender;

        public AutenticationManager(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public void Authenticate(User user, string email, string password)
        {
            if(user.Email == email && user.Password == password)
            {
                notificationSender.SendNotification(user);
            }
        }
    }
}
