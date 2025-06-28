namespace YourProject.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteClient;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddPayment;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditPayment;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeletePayment;
        private System.Windows.Forms.DataGridView dataGridViewSubscriptions;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddSubscription;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditSubscription;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeleteSubscription;
        private System.Windows.Forms.Panel panelTop;
        private MaterialSkin.Controls.MaterialRaisedButton btnMinimize;
        private MaterialSkin.Controls.MaterialRaisedButton btnClose;

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeleteClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.btnAddPayment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditPayment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeletePayment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridViewSubscriptions = new System.Windows.Forms.DataGridView();
            this.btnAddSubscription = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditSubscription = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeleteSubscription = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscriptions)).BeginInit();
            this.SuspendLayout();

            // Minimize Button
            this.btnMinimize.Text = "_";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.Location = new System.Drawing.Point(this.ClientSize.Width - 80, 10);
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.panelTop.Controls.Add(this.btnMinimize);

            // Close Button
            this.btnClose.Text = "X";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.Location = new System.Drawing.Point(this.ClientSize.Width - 40, 10);
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.panelTop.Controls.Add(this.btnClose);

            // dataGridViewClients
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(776, 126);
            this.dataGridViewClients.TabIndex = 0;

            // btnAddClient
            this.btnAddClient.Depth = 0;
            this.btnAddClient.Location = new System.Drawing.Point(12, 212);
            this.btnAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Primary = true;
            this.btnAddClient.Size = new System.Drawing.Size(150, 40);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);

            // btnEditClient
            this.btnEditClient.Depth = 0;
            this.btnEditClient.Location = new System.Drawing.Point(170, 212);
            this.btnEditClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Primary = true;
            this.btnEditClient.Size = new System.Drawing.Size(150, 40);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Редактировать";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);

            // btnDeleteClient
            this.btnDeleteClient.Depth = 0;
            this.btnDeleteClient.Location = new System.Drawing.Point(330, 212);
            this.btnDeleteClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Primary = true;
            this.btnDeleteClient.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);

            // dataGridViewPayments
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(12, 258);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.Size = new System.Drawing.Size(776, 126);
            this.dataGridViewPayments.TabIndex = 4;

            // btnAddPayment
            this.btnAddPayment.Depth = 0;
            this.btnAddPayment.Location = new System.Drawing.Point(12, 392);
            this.btnAddPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Primary = true;
            this.btnAddPayment.Size = new System.Drawing.Size(150, 40);
            this.btnAddPayment.TabIndex = 5;
            this.btnAddPayment.Text = "Добавить платеж";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);

            // btnEditPayment
            this.btnEditPayment.Depth = 0;
            this.btnEditPayment.Location = new System.Drawing.Point(170, 392);
            this.btnEditPayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditPayment.Name = "btnEditPayment";
            this.btnEditPayment.Primary = true;
            this.btnEditPayment.Size = new System.Drawing.Size(150, 40);
            this.btnEditPayment.TabIndex = 6;
            this.btnEditPayment.Text = "Редактировать";
            this.btnEditPayment.UseVisualStyleBackColor = true;
            this.btnEditPayment.Click += new System.EventHandler(this.btnEditPayment_Click);

            // btnDeletePayment
            this.btnDeletePayment.Depth = 0;
            this.btnDeletePayment.Location = new System.Drawing.Point(330, 392);
            this.btnDeletePayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Primary = true;
            this.btnDeletePayment.Size = new System.Drawing.Size(150, 40);
            this.btnDeletePayment.TabIndex = 7;
            this.btnDeletePayment.Text = "Удалить";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);

            // dataGridViewSubscriptions
            this.dataGridViewSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubscriptions.Location = new System.Drawing.Point(12, 450);
            this.dataGridViewSubscriptions.Name = "dataGridViewSubscriptions";
            this.dataGridViewSubscriptions.Size = new System.Drawing.Size(776, 126);
            this.dataGridViewSubscriptions.TabIndex = 8;

            // btnAddSubscription
            this.btnAddSubscription.Depth = 0;
            this.btnAddSubscription.Location = new System.Drawing.Point(12, 584);
            this.btnAddSubscription.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddSubscription.Name = "btnAddSubscription";
            this.btnAddSubscription.Primary = true;
            this.btnAddSubscription.Size = new System.Drawing.Size(150, 40);
            this.btnAddSubscription.TabIndex = 9;
            this.btnAddSubscription.Text = "Добавить подписку";
            this.btnAddSubscription.UseVisualStyleBackColor = true;
            this.btnAddSubscription.Click += new System.EventHandler(this.btnAddSubscription_Click);

            // btnEditSubscription
            this.btnEditSubscription.Depth = 0;
            this.btnEditSubscription.Location = new System.Drawing.Point(170, 584);
            this.btnEditSubscription.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditSubscription.Name = "btnEditSubscription";
            this.btnEditSubscription.Primary = true;
            this.btnEditSubscription.Size = new System.Drawing.Size(150, 40);
            this.btnEditSubscription.TabIndex = 10;
            this.btnEditSubscription.Text = "Редактировать";
            this.btnEditSubscription.UseVisualStyleBackColor = true;
            this.btnEditSubscription.Click += new System.EventHandler(this.btnEditSubscription_Click);

            // btnDeleteSubscription
            this.btnDeleteSubscription.Depth = 0;
            this.btnDeleteSubscription.Location = new System.Drawing.Point(330, 584);
            this.btnDeleteSubscription.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteSubscription.Name = "btnDeleteSubscription";
            this.btnDeleteSubscription.Primary = true;
            this.btnDeleteSubscription.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteSubscription.TabIndex = 11;
            this.btnDeleteSubscription.Text = "Удалить";
            this.btnDeleteSubscription.UseVisualStyleBackColor = true;
            this.btnDeleteSubscription.Click += new System.EventHandler(this.btnDeleteSubscription_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.dataGridViewPayments);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnEditPayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.dataGridViewSubscriptions);
            this.Controls.Add(this.btnAddSubscription);
            this.Controls.Add(this.btnEditSubscription);
            this.Controls.Add(this.btnDeleteSubscription);
            this.Name = "MainForm";
            this.Text = "Управление подписками и платежами";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscriptions)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
