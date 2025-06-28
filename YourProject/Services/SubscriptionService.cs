using System.Collections.Generic;
using YourProject.Data;
using YourProject.Models;

namespace YourProject.Services
{
    public class SubscriptionService
    {
        private readonly AppDbContext _context;

        public SubscriptionService()
        {
            _context = new AppDbContext();
        }

        public List<Subscription> GetAllSubscriptions()
        {
            return _context.GetAllSubscriptions();
        }

        public void AddSubscription(Subscription subscription)
        {
            _context.AddSubscription(subscription);
        }

        public void UpdateSubscription(Subscription subscription)
        {
            _context.AddSubscription(subscription); // Update method can be used in AppDbContext
        }

        public void DeleteSubscription(int subscriptionId)
        {
            _context.DeleteSubscription(subscriptionId);
        }
    }
}
