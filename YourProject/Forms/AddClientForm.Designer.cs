using System;

namespace YourProject.Forms
{
    partial class AddClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhoneNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel labelFirstName;
        private MaterialSkin.Controls.MaterialLabel labelLastName;
        private MaterialSkin.Controls.MaterialLabel labelPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel labelEmail;
        private MaterialSkin.Controls.MaterialLabel labelAddress;

        private void InitializeComponent()
        {
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPhoneNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelFirstName = new MaterialSkin.Controls.MaterialLabel();
            this.labelLastName = new MaterialSkin.Controls.MaterialLabel();
            this.labelPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.labelAddress = new MaterialSkin.Controls.MaterialLabel();

            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(30, 20);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 19);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Имя:";

            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(30, 60);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 19);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Фамилия:";

            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(30, 100);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(87, 19);
            this.labelPhoneNumber.TabIndex = 2;
            this.labelPhoneNumber.Text = "Номер:";

            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 140);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 19);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Почта:";

            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(30, 180);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 19);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Адрес:";

            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "Введите имя";
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);

            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Hint = "Введите фамилию";
            this.txtLastName.Location = new System.Drawing.Point(120, 60);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 1;

            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Hint = "Введите номер телефона";
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 100);
            this.txtPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.txtPhoneNumber.TabIndex = 2;

            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Введите электронную почту";
            this.txtEmail.Location = new System.Drawing.Point(120, 140);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 3;

            // 
            // txtAddress
            // 
            this.txtAddress.Depth = 0;
            this.txtAddress.Hint = "Введите адрес";
            this.txtAddress.Location = new System.Drawing.Point(120, 180);
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(200, 23);
            this.txtAddress.TabIndex = 4;

            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(120, 220);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(205, 220);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // AddClientForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddClientForm";
            this.Text = "Меню клиента";
        }

        // Обработчик для ограничения длины текста
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 50) // Ограничение на 50 символов
            {
                txtFirstName.Text = txtFirstName.Text.Substring(0, 50);
            }
        }
    }
}
