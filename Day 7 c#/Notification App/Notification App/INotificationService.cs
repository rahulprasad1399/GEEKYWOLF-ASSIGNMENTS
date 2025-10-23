using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_App
{
    public interface INotificationService
    {
        void Notify(string message);
    }
}
