namespace Notification.Models
{
    public class Order
    {
        public int Price { get;  set; }
        public int UserId { get; set; }
        internal void Pay()
        {

        }
    }
}