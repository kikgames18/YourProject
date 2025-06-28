using System;
using System.Collections.Generic;

namespace YourProject.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public int ClientID { get; set; }
        public string SubscriptionType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }

        // Навигационное свойство для клиента
        public Client Client { get; set; }

        // Навигационное свойство для платежей
        public List<Payment> Payments { get; set; }
    }
}
