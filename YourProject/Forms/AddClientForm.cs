using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using YourProject.Models;
using YourProject.Data;

namespace YourProject.Forms
{
    public partial class AddClientForm : MaterialForm
    {
        private readonly AppDbContext _context;
        private Client _client;

        public AddClientForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
        }

        // Конструктор для редактирования существующего клиента
        public AddClientForm(Client client) : this()
        {
            _client = client;
            txtFirstName.Text = client.FirstName;
            txtLastName.Text = client.LastName;
            txtPhoneNumber.Text = client.PhoneNumber;
            txtEmail.Text = client.Email;
            txtAddress.Text = client.Address;
            btnSave.Text = "Update"; // Меняем текст кнопки для редактирования
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            try
            {
                var client = new Client
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text
                };

                if (_client == null)
                {
                    _context.AddClient(client);
                }
                else
                {
                    _client.FirstName = client.FirstName;
                    _client.LastName = client.LastName;
                    _client.PhoneNumber = client.PhoneNumber;
                    _client.Email = client.Email;
                    _client.Address = client.Address;
                    _context.UpdateClient(_client);
                }

                MessageBox.Show("Client saved successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving client: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
