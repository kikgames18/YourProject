using System;

namespace YourProject.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int SubscriptionID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        // Навигационное свойство для подписки
        public Subscription Subscription { get; set; }
    }
}
