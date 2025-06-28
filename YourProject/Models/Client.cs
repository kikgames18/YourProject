using System.Collections.Generic;

namespace YourProject.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Навигационное свойство для подписок
        public List<Subscription> Subscriptions { get; set; }
    }
}
