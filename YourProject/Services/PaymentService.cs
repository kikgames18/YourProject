using System.Collections.Generic;
using YourProject.Data;
using YourProject.Models;

namespace YourProject.Services
{
    public class PaymentService
    {
        private readonly AppDbContext _context;

        public PaymentService()
        {
            _context = new AppDbContext();
        }

        public List<Payment> GetAllPayments()
        {
            return _context.GetAllPayments();
        }

        public List<Payment> GetPaymentsBySubscriptionId(int subscriptionId)
        {
            return _context.GetPaymentsBySubscriptionId(subscriptionId);
        }

        public void AddPayment(Payment payment)
        {
            _context.AddPayment(payment);
        }

        public void UpdatePayment(Payment payment)
        {
            _context.AddPayment(payment); // Update logic can be used directly in AppDbContext
        }

        public void DeletePayment(int paymentId)
        {
            _context.DeletePayment(paymentId);
        }

        public Payment GetPaymentById(int paymentId)
        {
            return _context.GetPaymentById(paymentId);  // Using the newly defined method
        }
    }
}
