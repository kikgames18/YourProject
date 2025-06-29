using System;
using System.Linq;
using System.Windows.Forms;
using YourProject.Models;
using YourProject.Services;
using MaterialSkin.Controls;

namespace YourProject.Forms
{
    public partial class MainForm : MaterialForm
    {
        private readonly ClientService _clientService;
        private readonly SubscriptionService _subscriptionService;
        private readonly PaymentService _paymentService;

        public MainForm()
        {
            InitializeComponent();
            _clientService = new ClientService();
            _subscriptionService = new SubscriptionService();
            _paymentService = new PaymentService();

            // Настройка интерфейса
            InitializeCustomStyles();
        }

        private MaterialSkin.Controls.MaterialRaisedButton btnHelp;

        private void InitializeCustomStyles()
        {

            // Настройка фона
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Настройка DataGridView
            dataGridViewClients.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12);
            dataGridViewSubscriptions.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12);
            dataGridViewPayments.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12);

            // Настройка авторазмера столбцов
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Настройка высоты строк
            dataGridViewClients.RowTemplate.Height = 40;
            dataGridViewSubscriptions.RowTemplate.Height = 40;
            dataGridViewPayments.RowTemplate.Height = 40;

            // Настройка цвета строк
            dataGridViewClients.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewSubscriptions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewPayments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            // Убираем чередование фона строк, делаем все строки белыми
            dataGridViewClients.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridViewSubscriptions.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridViewPayments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

            // Настройка кнопок
            var buttonColor = System.Drawing.Color.FromArgb(72, 202, 228);
            var buttonHoverColor = System.Drawing.Color.FromArgb(0, 150, 136);

            btnAddClient.BackColor = buttonColor;
            btnEditClient.BackColor = buttonColor;
            btnDeleteClient.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);

            btnAddPayment.BackColor = buttonColor;
            btnEditPayment.BackColor = buttonColor;
            btnDeletePayment.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);

            btnAddSubscription.BackColor = buttonColor;
            btnEditSubscription.BackColor = buttonColor;
            btnDeleteSubscription.BackColor = System.Drawing.Color.FromArgb(255, 99, 71);

            // Добавление эффекта при наведении на кнопки
            btnAddClient.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);
            btnEditClient.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);
            btnDeleteClient.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);

            btnAddPayment.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);
            btnEditPayment.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);
            btnDeletePayment.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);

            btnAddSubscription.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);
            btnEditSubscription.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);
            btnDeleteSubscription.MouseEnter += (sender, e) => button_MouseEnter(sender, e, buttonHoverColor);

            btnAddClient.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);
            btnEditClient.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);
            btnDeleteClient.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);

            btnAddPayment.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);
            btnEditPayment.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);
            btnDeletePayment.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);

            btnAddSubscription.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);
            btnEditSubscription.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);
            btnDeleteSubscription.MouseLeave += (sender, e) => button_MouseLeave(sender, e, buttonColor);

            this.btnHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();

            // 
            // btnHelp
            // 
            this.btnHelp.Depth = 0;
            this.btnHelp.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 25); // Позиция кнопки в правом верхнем углу
            this.btnHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Primary = true;
            this.btnHelp.Size = new System.Drawing.Size(100, 36);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);  // Привязываем обработчик клика
            this.Controls.Add(this.btnHelp); // Добавляем кнопку на форму

            this.ResumeLayout(false);
        }






        private void button_MouseEnter(object sender, EventArgs e, System.Drawing.Color color)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.BackColor = color; // Цвет при наведении
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Открытие формы справочного отдела
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();  // Покажем справочный отдел как модальное окно
        }


        private void button_MouseLeave(object sender, EventArgs e, System.Drawing.Color color)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.BackColor = color; // Обычный цвет кнопки
            }
        }

        // Загрузка данных при старте формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadSubscriptions();
            LoadPayments();
        }

        // Загрузка клиентов
        private void LoadClients()
        {
            var clients = _clientService.GetAllClients();
            dataGridViewClients.DataSource = clients;

            // Убираем колонки "Subscription" и "Client"
            if (dataGridViewClients.Columns.Contains("Subscription"))
                dataGridViewClients.Columns.Remove("Subscription");
            if (dataGridViewClients.Columns.Contains("Client"))
                dataGridViewClients.Columns.Remove("Client");

            // Устанавливаем заголовки столбцов на русском
            dataGridViewClients.Columns["ClientID"].HeaderText = "Идентификатор клиента";
            dataGridViewClients.Columns["FirstName"].HeaderText = "Имя";
            dataGridViewClients.Columns["LastName"].HeaderText = "Фамилия";
            dataGridViewClients.Columns["PhoneNumber"].HeaderText = "Номер телефона";
            dataGridViewClients.Columns["Email"].HeaderText = "Электронная почта";
            dataGridViewClients.Columns["Address"].HeaderText = "Адрес";
        }

        private void LoadSubscriptions()
        {
            var subscriptions = _subscriptionService.GetAllSubscriptions();
            dataGridViewSubscriptions.DataSource = subscriptions;

            // Убираем колонки "Subscription" и "Client"
            if (dataGridViewSubscriptions.Columns.Contains("Subscription"))
                dataGridViewSubscriptions.Columns.Remove("Subscription");
            if (dataGridViewSubscriptions.Columns.Contains("Client"))
                dataGridViewSubscriptions.Columns.Remove("Client");

            // Устанавливаем заголовки столбцов на русском
            dataGridViewSubscriptions.Columns["SubscriptionID"].HeaderText = "Идентификатор подписки";
            dataGridViewSubscriptions.Columns["ClientID"].HeaderText = "Идентификатор клиента";
            dataGridViewSubscriptions.Columns["SubscriptionType"].HeaderText = "Тип подписки";
            dataGridViewSubscriptions.Columns["StartDate"].HeaderText = "Дата начала";
            dataGridViewSubscriptions.Columns["EndDate"].HeaderText = "Дата окончания";
            dataGridViewSubscriptions.Columns["Status"].HeaderText = "Статус";
        }

        private void LoadPayments()
        {
            var payments = _paymentService.GetAllPayments();
            dataGridViewPayments.DataSource = payments;

            // Убираем колонки "Subscription" и "Client"
            if (dataGridViewPayments.Columns.Contains("Subscription"))
                dataGridViewPayments.Columns.Remove("Subscription");
            if (dataGridViewPayments.Columns.Contains("Client"))
                dataGridViewPayments.Columns.Remove("Client");

            // Устанавливаем заголовки столбцов на русском
            dataGridViewPayments.Columns["PaymentID"].HeaderText = "Идентификатор платежа";
            dataGridViewPayments.Columns["SubscriptionID"].HeaderText = "Идентификатор подписки";
            dataGridViewPayments.Columns["Amount"].HeaderText = "Сумма";
            dataGridViewPayments.Columns["PaymentDate"].HeaderText = "Дата платежа";
            dataGridViewPayments.Columns["PaymentMethod"].HeaderText = "Метод платежа";
        }



        // Закрытие формы
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Минимизация формы
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Добавление нового клиента
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            LoadClients();
        }

        // Редактирование выбранного клиента
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                // Получаем ID выбранного клиента
                var clientId = (int)dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value;
                var client = _clientService.GetAllClients().FirstOrDefault(c => c.ClientID == clientId);

                // Если клиент найден, открываем форму для редактирования
                if (client != null)
                {
                    var addClientForm = new AddClientForm(client);
                    addClientForm.ShowDialog();
                    LoadClients(); // Перезагружаем список клиентов
                }
                else
                {
                    MessageBox.Show("Клиент не найден.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для редактирования.");
            }
        }

        // Удаление выбранного клиента
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                var clientId = (int)dataGridViewClients.SelectedRows[0].Cells["ClientID"].Value;

                // Подтверждаем удаление
                var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить этого клиента?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _clientService.DeleteClient(clientId); // Удаляем клиента
                    LoadClients(); // Перезагружаем список клиентов
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.");
            }
        }


        // Добавление новой подписки
        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            var addSubscriptionForm = new AddSubscriptionForm();
            addSubscriptionForm.ShowDialog();
            LoadSubscriptions();
        }

        // Редактирование выбранной подписки
        private void btnEditSubscription_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubscriptions.SelectedRows.Count > 0)
            {
                var subscriptionId = (int)dataGridViewSubscriptions.SelectedRows[0].Cells["SubscriptionID"].Value;
                var subscription = _subscriptionService.GetAllSubscriptions().FirstOrDefault(s => s.SubscriptionID == subscriptionId);
                var addSubscriptionForm = new AddSubscriptionForm(subscription);
                addSubscriptionForm.ShowDialog();
                LoadSubscriptions();
            }
        }

        // Удаление выбранной подписки
        private void btnDeleteSubscription_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubscriptions.SelectedRows.Count > 0)
            {
                var subscriptionId = (int)dataGridViewSubscriptions.SelectedRows[0].Cells["SubscriptionID"].Value;
                _subscriptionService.DeleteSubscription(subscriptionId);
                LoadSubscriptions();
            }
        }

        // Добавление нового платежа
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            var addPaymentForm = new AddPaymentForm();
            addPaymentForm.ShowDialog();
            LoadPayments();
        }

        // Редактирование выбранного платежа
        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var paymentId = (int)dataGridViewPayments.SelectedRows[0].Cells["PaymentID"].Value;
                var payment = _paymentService.GetPaymentById(paymentId);
                var addPaymentForm = new AddPaymentForm(payment);
                addPaymentForm.ShowDialog();
                LoadPayments();
            }
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        // Удаление выбранного платежа
        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if (dataGridViewPayments.SelectedRows.Count > 0)
            {
                var paymentId = (int)dataGridViewPayments.SelectedRows[0].Cells["PaymentID"].Value;
                _paymentService.DeletePayment(paymentId);
                LoadPayments();
            }
        }
    }
}
