using System;
using System.Windows.Forms;
using YourProject.Models;
using YourProject.Data;
using MaterialSkin.Controls;

namespace YourProject.Forms
{
    public partial class AddPaymentForm : MaterialForm
    {
        private readonly AppDbContext _context;
        private Payment _payment;

        public AddPaymentForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        // Constructor for editing an existing payment
        public AddPaymentForm(Payment payment) : this()
        {
            _payment = payment;
            txtSubscriptionID.Text = payment.SubscriptionID.ToString();
            txtAmount.Text = payment.Amount.ToString();
            dateTimePickerPaymentDate.Value = payment.PaymentDate;
            txtPaymentMethod.Text = payment.PaymentMethod;
            btnSave.Text = "Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation to ensure all required fields are filled
            if (string.IsNullOrWhiteSpace(txtSubscriptionID.Text) || string.IsNullOrWhiteSpace(txtAmount.Text) ||
                string.IsNullOrWhiteSpace(txtPaymentMethod.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            try
            {
                var payment = new Payment
                {
                    SubscriptionID = Convert.ToInt32(txtSubscriptionID.Text),
                    Amount = Convert.ToDecimal(txtAmount.Text),
                    PaymentDate = dateTimePickerPaymentDate.Value,
                    PaymentMethod = txtPaymentMethod.Text
                };

                if (_payment == null)
                {
                    _context.AddPayment(payment);
                }
                else
                {
                    _payment.Amount = payment.Amount;
                    _payment.PaymentDate = payment.PaymentDate;
                    _payment.PaymentMethod = payment.PaymentMethod;
                    _context.UpdatePayment(_payment);
                }

                MessageBox.Show("Payment saved successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving payment: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubscriptionID_TextChanged(object sender, EventArgs e)
        {
            if (txtSubscriptionID.Text.Length > 10) // Limit to 10 characters
            {
                txtSubscriptionID.Text = txtSubscriptionID.Text.Substring(0, 10);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length > 10) // Limit to 10 characters
            {
                txtAmount.Text = txtAmount.Text.Substring(0, 10);
            }
        }

        private void txtPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            if (txtPaymentMethod.Text.Length > 20) // Limit to 20 characters
            {
                txtPaymentMethod.Text = txtPaymentMethod.Text.Substring(0, 20);
            }
        }
    }
}
