using Npgsql;
using System;
using System.Collections.Generic;
using YourProject.Models;

namespace YourProject.Data
{
    public class AppDbContext
    {
        private readonly string _connectionString;

        public AppDbContext()
        {
            // Строка подключения к базе данных PostgreSQL
            _connectionString = "Host=localhost;Port=5432;Database=most_tv;Username=postgres;Password=123";
        }

        // Получение всех клиентов
        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("SELECT * FROM Clients", conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ClientID = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            PhoneNumber = reader.GetString(3),
                            Email = reader.GetString(4),
                            Address = reader.GetString(5)
                        });
                    }
                }
            }

            return clients;
        }

        // Получение всех подписок
        public List<Subscription> GetAllSubscriptions()
        {
            var subscriptions = new List<Subscription>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("SELECT * FROM Subscriptions", conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subscriptions.Add(new Subscription
                        {
                            SubscriptionID = reader.GetInt32(0),
                            ClientID = reader.GetInt32(1),
                            SubscriptionType = reader.GetString(2),
                            StartDate = reader.GetDateTime(3),
                            EndDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                            Status = reader.GetString(5)
                        });
                    }
                }
            }

            return subscriptions;
        }

        // Получение всех платежей
        public List<Payment> GetAllPayments()
        {
            var payments = new List<Payment>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("SELECT * FROM Payments", conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new Payment
                        {
                            PaymentID = reader.GetInt32(0),
                            SubscriptionID = reader.GetInt32(1),
                            Amount = reader.GetDecimal(2),
                            PaymentDate = reader.GetDateTime(3),
                            PaymentMethod = reader.GetString(4)
                        });
                    }
                }
            }

            return payments;
        }

        // Метод для получения платежей по SubscriptionID
        public List<Payment> GetPaymentsBySubscriptionId(int subscriptionId)
        {
            var payments = new List<Payment>();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("SELECT * FROM Payments WHERE SubscriptionID = @SubscriptionID", conn);
                command.Parameters.AddWithValue("SubscriptionID", subscriptionId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new Payment
                        {
                            PaymentID = reader.GetInt32(0),
                            SubscriptionID = reader.GetInt32(1),
                            Amount = reader.GetDecimal(2),
                            PaymentDate = reader.GetDateTime(3),
                            PaymentMethod = reader.GetString(4)
                        });
                    }
                }
            }

            return payments;
        }

        // Метод для добавления клиента
        public void AddClient(Client client)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("INSERT INTO Clients (FirstName, LastName, PhoneNumber, Email, Address) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address)", conn);
                command.Parameters.AddWithValue("FirstName", client.FirstName);
                command.Parameters.AddWithValue("LastName", client.LastName);
                command.Parameters.AddWithValue("PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("Email", client.Email);
                command.Parameters.AddWithValue("Address", client.Address);

                command.ExecuteNonQuery();
            }
        }

        // Метод для добавления подписки
        public void AddSubscription(Subscription subscription)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("INSERT INTO Subscriptions (ClientID, SubscriptionType, StartDate, EndDate, Status) VALUES (@ClientID, @SubscriptionType, @StartDate, @EndDate, @Status)", conn);
                command.Parameters.AddWithValue("ClientID", subscription.ClientID);
                command.Parameters.AddWithValue("SubscriptionType", subscription.SubscriptionType);
                command.Parameters.AddWithValue("StartDate", subscription.StartDate);
                command.Parameters.AddWithValue("EndDate", subscription.EndDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("Status", subscription.Status);

                command.ExecuteNonQuery();
            }
        }

        // Метод для обновления подписки
        public void UpdateSubscription(Subscription subscription)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("UPDATE Subscriptions SET SubscriptionType = @SubscriptionType, StartDate = @StartDate, EndDate = @EndDate, Status = @Status WHERE SubscriptionID = @SubscriptionID", conn);
                command.Parameters.AddWithValue("SubscriptionID", subscription.SubscriptionID);
                command.Parameters.AddWithValue("SubscriptionType", subscription.SubscriptionType);
                command.Parameters.AddWithValue("StartDate", subscription.StartDate);
                command.Parameters.AddWithValue("EndDate", subscription.EndDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("Status", subscription.Status);

                command.ExecuteNonQuery();
            }
        }

        // Метод для обновления клиента
        public void UpdateClient(Client client)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("UPDATE Clients SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address WHERE ClientID = @ClientID", conn);
                command.Parameters.AddWithValue("ClientID", client.ClientID);
                command.Parameters.AddWithValue("FirstName", client.FirstName);
                command.Parameters.AddWithValue("LastName", client.LastName);
                command.Parameters.AddWithValue("PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("Email", client.Email);
                command.Parameters.AddWithValue("Address", client.Address);

                command.ExecuteNonQuery();
            }
        }

        // Метод для обновления платежа
        public void UpdatePayment(Payment payment)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("UPDATE Payments SET Amount = @Amount, PaymentDate = @PaymentDate, PaymentMethod = @PaymentMethod WHERE PaymentID = @PaymentID", conn);
                command.Parameters.AddWithValue("PaymentID", payment.PaymentID);
                command.Parameters.AddWithValue("Amount", payment.Amount);
                command.Parameters.AddWithValue("PaymentDate", payment.PaymentDate);
                command.Parameters.AddWithValue("PaymentMethod", payment.PaymentMethod);

                command.ExecuteNonQuery();
            }
        }

        // Метод для добавления платежа
        public void AddPayment(Payment payment)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("INSERT INTO Payments (SubscriptionID, Amount, PaymentDate, PaymentMethod) VALUES (@SubscriptionID, @Amount, @PaymentDate, @PaymentMethod)", conn);
                command.Parameters.AddWithValue("SubscriptionID", payment.SubscriptionID);
                command.Parameters.AddWithValue("Amount", payment.Amount);
                command.Parameters.AddWithValue("PaymentDate", payment.PaymentDate);
                command.Parameters.AddWithValue("PaymentMethod", payment.PaymentMethod);

                command.ExecuteNonQuery();
            }
        }

        // Метод для удаления клиента
        public void DeleteClient(int clientId)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("DELETE FROM Clients WHERE ClientID = @ClientID", conn);
                command.Parameters.AddWithValue("ClientID", clientId);
                command.ExecuteNonQuery();
            }
        }

        // Метод для удаления подписки
        public void DeleteSubscription(int subscriptionId)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("DELETE FROM Subscriptions WHERE SubscriptionID = @SubscriptionID", conn);
                command.Parameters.AddWithValue("SubscriptionID", subscriptionId);
                command.ExecuteNonQuery();
            }
        }

        // Метод для удаления платежа
        public void DeletePayment(int paymentId)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("DELETE FROM Payments WHERE PaymentID = @PaymentID", conn);
                command.Parameters.AddWithValue("PaymentID", paymentId);
                command.ExecuteNonQuery();
            }
        }

        // Метод для получения платежа по его ID
        public Payment GetPaymentById(int paymentId)
        {
            var payment = new Payment();

            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var command = new NpgsqlCommand("SELECT * FROM Payments WHERE PaymentID = @PaymentID", conn);
                command.Parameters.AddWithValue("PaymentID", paymentId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        payment.PaymentID = reader.GetInt32(0);
                        payment.SubscriptionID = reader.GetInt32(1);
                        payment.Amount = reader.GetDecimal(2);
                        payment.PaymentDate = reader.GetDateTime(3);
                        payment.PaymentMethod = reader.GetString(4);
                    }
                }
            }

            return payment;
        }
    }
}
