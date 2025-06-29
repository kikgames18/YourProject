using System;

namespace YourProject.Forms
{
    partial class AddPaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubscriptionID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAmount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPaymentMethod;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialLabel labelSubscriptionID;
        private MaterialSkin.Controls.MaterialLabel labelAmount;
        private MaterialSkin.Controls.MaterialLabel labelPaymentDate;
        private MaterialSkin.Controls.MaterialLabel labelPaymentMethod;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;

        private void InitializeComponent()
        {
            this.txtSubscriptionID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPaymentMethod = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelSubscriptionID = new MaterialSkin.Controls.MaterialLabel();
            this.labelAmount = new MaterialSkin.Controls.MaterialLabel();
            this.labelPaymentDate = new MaterialSkin.Controls.MaterialLabel();
            this.labelPaymentMethod = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtSubscriptionID
            // 
            this.txtSubscriptionID.Depth = 0;
            this.txtSubscriptionID.Hint = "Введите идентификатор подписки";
            this.txtSubscriptionID.Location = new System.Drawing.Point(170, 80);
            this.txtSubscriptionID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubscriptionID.Name = "txtSubscriptionID";
            this.txtSubscriptionID.PasswordChar = '\0';
            this.txtSubscriptionID.SelectedText = "";
            this.txtSubscriptionID.SelectionLength = 0;
            this.txtSubscriptionID.SelectionStart = 0;
            this.txtSubscriptionID.Size = new System.Drawing.Size(200, 23);
            this.txtSubscriptionID.TabIndex = 1;
            this.txtSubscriptionID.TabStop = false;
            this.txtSubscriptionID.UseSystemPasswordChar = false;
            this.txtSubscriptionID.TextChanged += new System.EventHandler(this.TxtSubscriptionID_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Depth = 0;
            this.txtAmount.Hint = "Введите сумму";
            this.txtAmount.Location = new System.Drawing.Point(170, 120);
            this.txtAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.Size = new System.Drawing.Size(200, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TabStop = false;
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Depth = 0;
            this.txtPaymentMethod.Hint = "Введите метод платежа";
            this.txtPaymentMethod.Location = new System.Drawing.Point(170, 200);
            this.txtPaymentMethod.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.PasswordChar = '\0';
            this.txtPaymentMethod.SelectedText = "";
            this.txtPaymentMethod.SelectionLength = 0;
            this.txtPaymentMethod.SelectionStart = 0;
            this.txtPaymentMethod.Size = new System.Drawing.Size(200, 23);
            this.txtPaymentMethod.TabIndex = 7;
            this.txtPaymentMethod.TabStop = false;
            this.txtPaymentMethod.UseSystemPasswordChar = false;
            this.txtPaymentMethod.TextChanged += new System.EventHandler(this.TxtPaymentMethod_TextChanged);
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(170, 160);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPaymentDate.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(170, 240);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(265, 240);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelSubscriptionID
            // 
            this.labelSubscriptionID.AutoSize = true;
            this.labelSubscriptionID.Depth = 0;
            this.labelSubscriptionID.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSubscriptionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSubscriptionID.Location = new System.Drawing.Point(30, 80);
            this.labelSubscriptionID.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSubscriptionID.Name = "labelSubscriptionID";
            this.labelSubscriptionID.Size = new System.Drawing.Size(134, 19);
            this.labelSubscriptionID.TabIndex = 0;
            this.labelSubscriptionID.Text = "Номер подписки:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Depth = 0;
            this.labelAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAmount.Location = new System.Drawing.Point(30, 120);
            this.labelAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(69, 19);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Сумма:";
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Depth = 0;
            this.labelPaymentDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPaymentDate.Location = new System.Drawing.Point(30, 160);
            this.labelPaymentDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(126, 19);
            this.labelPaymentDate.TabIndex = 4;
            this.labelPaymentDate.Text = "Дата платежа:";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Depth = 0;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPaymentMethod.Location = new System.Drawing.Point(30, 200);
            this.labelPaymentMethod.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(125, 19);
            this.labelPaymentMethod.TabIndex = 6;
            this.labelPaymentMethod.Text = "Метод платежа:";
            // 
            // AddPaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.labelSubscriptionID);
            this.Controls.Add(this.txtSubscriptionID);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labelPaymentDate);
            this.Controls.Add(this.dateTimePickerPaymentDate);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddPaymentForm";
            this.Text = "Меню платежа";
            this.Load += new System.EventHandler(this.AddPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Ограничение на количество символов
        private void TxtSubscriptionID_TextChanged(object sender, EventArgs e)
        {
            if (txtSubscriptionID.Text.Length > 10)
                txtSubscriptionID.Text = txtSubscriptionID.Text.Substring(0, 10);
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length > 10)
                txtAmount.Text = txtAmount.Text.Substring(0, 10);
        }

        private void TxtPaymentMethod_TextChanged(object sender, EventArgs e)
        {
            if (txtPaymentMethod.Text.Length > 50)
                txtPaymentMethod.Text = txtPaymentMethod.Text.Substring(0, 50);
        }
    }
}
