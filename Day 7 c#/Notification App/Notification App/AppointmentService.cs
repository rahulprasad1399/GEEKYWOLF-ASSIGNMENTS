using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_App
{
    public class AppointmentService
    {
        public INotificationService NotificationService { get; set; }
        public AppointmentService(INotificationService notificationService) { 
            NotificationService = notificationService;
        }

        public void BookAppointment(string patientName)
        {
            NotificationService.Notify($"Booking confirmed for patient : {patientName}");
        }
    }
}
