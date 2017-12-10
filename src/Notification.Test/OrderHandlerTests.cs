using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notification.Models;
using Notification.Notifications.Implementations;

namespace Notification.Test
{
    [TestClass]
    public class OrderHandlerTests
    {
        [TestMethod]
        public void Run()
        {
            Order order = new Order();

            order.Price = 100;
            order.UserId = 123456789;

            OrderHandler orderHandler = new OrderHandler(order);

            //Only Email & Push. Not by SMS
            orderHandler.Subscribe(new EmailNotification());
            orderHandler.Subscribe(new PushNotification());

            orderHandler.Complete();
        }
    }
}
