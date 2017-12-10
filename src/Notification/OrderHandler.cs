using System;
using Notification.Models;
using Notification.Notifications;

namespace Notification
{
    public class OrderHandler
    {
        private Action _action;

        public Order _order { get; }

        public OrderHandler(Order order)
        {
            _order = order;
        }

        public void Subscribe(INotification notifier)
        {
            _action += notifier.Send;
        }

        public void Complete()
        {
            // Charge for the money.

            //Call Notifications
            _action();
        }
    }
}
