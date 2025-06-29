using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using YourProject.Data;
using YourProject.Models;

namespace YourProject.Forms
{
    public partial class AddSubscriptionForm : MaterialForm
    {
        private readonly AppDbContext _context;
        private Subscription _subscription;

        public AddSubscriptionForm()
        {
            InitializeComponent();
            _context = new AppDbContext(); // Инициализируем контекст базы данных
            InitializeMaterialDesign();
        }

        // Конструктор для редактирования существующей подписки
        public AddSubscriptionForm(Subscription subscription) : this()
        {
            _subscription = subscription;
            txtClientID.Text = subscription.ClientID.ToString();
            txtSubscriptionType.Text = subscription.SubscriptionType;
            dateTimePickerStartDate.Value = subscription.StartDate;
            dateTimePickerEndDate.Value = subscription.EndDate ?? DateTime.Now;
            comboBoxStatus.SelectedItem = subscription.Status;
            btnSave.Text = "Update"; // Меняем текст кнопки для редактирования
        }

        private void InitializeMaterialDesign()
        {
            // Применяем MaterialSkinManager и цветовую схему
            MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue500, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE
            );

            // Настроим ComboBox для статуса
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive" });

            // Настроим TextBox подсказки
            txtClientID.Hint = "Идентификатор клиента";
            txtSubscriptionType.Hint = "Тип подписки";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Логика сохранения
            if (string.IsNullOrWhiteSpace(txtClientID.Text) || string.IsNullOrWhiteSpace(txtSubscriptionType.Text) || comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            try
            {
                var subscription = new Subscription
                {
                    ClientID = Convert.ToInt32(txtClientID.Text),
                    SubscriptionType = txtSubscriptionType.Text,
                    StartDate = dateTimePickerStartDate.Value,
                    EndDate = dateTimePickerEndDate.Value,
                    Status = comboBoxStatus.SelectedItem.ToString()
                };

                if (_subscription == null)
                {
                    _context.AddSubscription(subscription);
                }
                else
                {
                    _subscription.SubscriptionType = subscription.SubscriptionType;
                    _subscription.StartDate = subscription.StartDate;
                    _subscription.EndDate = subscription.EndDate;
                    _subscription.Status = subscription.Status;
                    _context.UpdateSubscription(_subscription);
                }

                MessageBox.Show("Subscription saved successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving subscription: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }
    }
}
