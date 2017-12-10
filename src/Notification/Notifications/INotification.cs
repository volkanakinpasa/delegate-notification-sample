using Notification.Models;

namespace Notification.Notifications
{
    public interface INotification
    {
        void Send(NotificationMessage message);
    }
}