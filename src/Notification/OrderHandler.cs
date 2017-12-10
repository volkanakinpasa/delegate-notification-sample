using Notification.Models;
using Notification.Notifications.Implementations;

namespace Notification
{
    public class OrderHandler
    {
        public Order _order { get; }

        private NotificationHandler _donno;

        public OrderHandler(Order order)
        {
            _order = order;

            _donno = new NotificationHandler();

            _donno.Subscribe(new EmailNotification());
            _donno.Subscribe(new SmsNotification());
            _donno.Subscribe(new PushNotification());
        }

        public void Complete()
        {
            _order.Pay();

            _donno.Run(new NotificationMessage() { Message = "Done" });
        }
    }
}
