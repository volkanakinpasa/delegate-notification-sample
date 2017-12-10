using System;
using Notification.Notifications;
using Notification.Models;

namespace Notification
{
    public class NotificationHandler
    {
        private event Action<NotificationMessage> _action;

        public void Subscribe(INotification notifier)
        {
            _action += notifier.Send;
        }

        public void Run(NotificationMessage notificationMessage)
        {
            _action(notificationMessage);
        }
    }
}
