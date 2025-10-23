namespace Notification_App
{
    public class Notification
    {
        static void Main(string[] args)
        {
            AppointmentService appointmentService = new AppointmentService(new EmailNotifier());
            appointmentService.BookAppointment("Rahul");
        }
    }
}
