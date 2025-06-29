using System;

namespace YourProject.Forms
{
    partial class AddSubscriptionForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtClientID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubscriptionType;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private MaterialSkin.Controls.MaterialLabel labelClientID;
        private MaterialSkin.Controls.MaterialLabel labelSubscriptionType;
        private MaterialSkin.Controls.MaterialLabel labelStatusText;
        private MaterialSkin.Controls.MaterialLabel labelStartDateText;
        private MaterialSkin.Controls.MaterialLabel labelEndDateText;

        private void InitializeComponent()
        {
            this.txtClientID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSubscriptionType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelClientID = new MaterialSkin.Controls.MaterialLabel();
            this.labelSubscriptionType = new MaterialSkin.Controls.MaterialLabel();
            this.labelStatusText = new MaterialSkin.Controls.MaterialLabel();
            this.labelStartDateText = new MaterialSkin.Controls.MaterialLabel();
            this.labelEndDateText = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();

            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(30, 20);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(100, 19);
            this.labelClientID.TabIndex = 0;
            this.labelClientID.Text = "Идентификатор клиента:";

            // 
            // labelSubscriptionType
            // 
            this.labelSubscriptionType.AutoSize = true;
            this.labelSubscriptionType.Location = new System.Drawing.Point(30, 50);
            this.labelSubscriptionType.Name = "labelSubscriptionType";
            this.labelSubscriptionType.Size = new System.Drawing.Size(100, 19);
            this.labelSubscriptionType.TabIndex = 1;
            this.labelSubscriptionType.Text = "Тип подписки:";

            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Location = new System.Drawing.Point(30, 80);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(100, 19);
            this.labelStatusText.TabIndex = 2;
            this.labelStatusText.Text = "Статус подписки:";

            // 
            // labelStartDateText
            // 
            this.labelStartDateText.AutoSize = true;
            this.labelStartDateText.Location = new System.Drawing.Point(30, 110);
            this.labelStartDateText.Name = "labelStartDateText";
            this.labelStartDateText.Size = new System.Drawing.Size(100, 19);
            this.labelStartDateText.TabIndex = 3;
            this.labelStartDateText.Text = "Дата начала:";

            // 
            // labelEndDateText
            // 
            this.labelEndDateText.AutoSize = true;
            this.labelEndDateText.Location = new System.Drawing.Point(30, 140);
            this.labelEndDateText.Name = "labelEndDateText";
            this.labelEndDateText.Size = new System.Drawing.Size(100, 19);
            this.labelEndDateText.TabIndex = 4;
            this.labelEndDateText.Text = "Дата окончания:";

            // 
            // txtClientID
            // 
            this.txtClientID.Depth = 0;
            this.txtClientID.Hint = "Идентификатор клиента";  // Переводим на русский
            this.txtClientID.Location = new System.Drawing.Point(140, 20);
            this.txtClientID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.PasswordChar = '\0';
            this.txtClientID.SelectedText = "";
            this.txtClientID.SelectionLength = 0;
            this.txtClientID.SelectionStart = 0;
            this.txtClientID.Size = new System.Drawing.Size(200, 23);
            this.txtClientID.TabIndex = 0;

            // 
            // txtSubscriptionType
            // 
            this.txtSubscriptionType.Depth = 0;
            this.txtSubscriptionType.Hint = "Тип подписки";  // Переводим на русский
            this.txtSubscriptionType.Location = new System.Drawing.Point(140, 50);
            this.txtSubscriptionType.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubscriptionType.Name = "txtSubscriptionType";
            this.txtSubscriptionType.PasswordChar = '\0';
            this.txtSubscriptionType.SelectedText = "";
            this.txtSubscriptionType.SelectionLength = 0;
            this.txtSubscriptionType.SelectionStart = 0;
            this.txtSubscriptionType.Size = new System.Drawing.Size(200, 23);
            this.txtSubscriptionType.TabIndex = 1;


            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Активен",
            "Неактивен"});
            this.comboBoxStatus.Location = new System.Drawing.Point(140, 80);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 2;

            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(140, 110);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 3;

            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(140, 140);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 4;

            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(140, 170);
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
            this.btnCancel.Location = new System.Drawing.Point(225, 170);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // AddSubscriptionForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtSubscriptionType);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.labelSubscriptionType);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.labelStartDateText);
            this.Controls.Add(this.labelEndDateText);
            this.Name = "AddSubscriptionForm";
            this.Text = "Меню подписки";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Обработчик для ограничения символов в поле ClientID
        private void TxtClientID_TextChanged(object sender, EventArgs e)
        {
            if (txtClientID.Text.Length > 50)
            {
                txtClientID.Text = txtClientID.Text.Substring(0, 50);
            }
        }

        // Обработчик для ограничения символов в поле SubscriptionType
        private void TxtSubscriptionType_TextChanged(object sender, EventArgs e)
        {
            if (txtSubscriptionType.Text.Length > 50)
            {
                txtSubscriptionType.Text = txtSubscriptionType.Text.Substring(0, 50);
            }
        }
    }
}
