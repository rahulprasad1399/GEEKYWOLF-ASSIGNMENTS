using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_App
{
    public class SMSNotifier : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS : {message}");
        }
    }

    public class EmailNotifier : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email : {message}");
        }
    }

    public class PushNotifier : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Push Notification : {message}");
        }
    }
}
