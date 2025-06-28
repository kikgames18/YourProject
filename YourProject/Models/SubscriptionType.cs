using System.Collections.Generic;

namespace YourProject.Models
{
    public class SubscriptionType
    {
        public int SubscriptionTypeID { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }

        // Навигационное свойство для подписок
        public List<Subscription> Subscriptions { get; set; }
    }
}
