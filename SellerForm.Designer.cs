namespace Warehouse
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ManagerTB = new System.Windows.Forms.TabControl();
            this.Commodities = new System.Windows.Forms.TabPage();
            this.CommodityDGV = new System.Windows.Forms.DataGridView();
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Warehouse.DataSet();
            this.Clients = new System.Windows.Forms.TabPage();
            this.ClientDGV = new System.Windows.Forms.DataGridView();
            this.clientBS = new System.Windows.Forms.BindingSource(this.components);
            this.ClientOrders = new System.Windows.Forms.TabPage();
            this.ClientOrderDGV = new System.Windows.Forms.DataGridView();
            this.clientorderBS = new System.Windows.Forms.BindingSource(this.components);
            this.ClientOrderButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.clientTA = new Warehouse.DataSetTableAdapters.clientTableAdapter();
            this.client_orderTA = new Warehouse.DataSetTableAdapters.client_orderTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerTB.SuspendLayout();
            this.Commodities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommodityDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).BeginInit();
            this.ClientOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientOrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBS)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerTB
            // 
            this.ManagerTB.Controls.Add(this.Commodities);
            this.ManagerTB.Controls.Add(this.Clients);
            this.ManagerTB.Controls.Add(this.ClientOrders);
            this.ManagerTB.Location = new System.Drawing.Point(3, 3);
            this.ManagerTB.Name = "ManagerTB";
            this.ManagerTB.SelectedIndex = 0;
            this.ManagerTB.Size = new System.Drawing.Size(402, 276);
            this.ManagerTB.TabIndex = 1;
            // 
            // Commodities
            // 
            this.Commodities.BackColor = System.Drawing.SystemColors.Control;
            this.Commodities.Controls.Add(this.CommodityDGV);
            this.Commodities.Location = new System.Drawing.Point(4, 22);
            this.Commodities.Name = "Commodities";
            this.Commodities.Padding = new System.Windows.Forms.Padding(3);
            this.Commodities.Size = new System.Drawing.Size(394, 250);
            this.Commodities.TabIndex = 0;
            this.Commodities.Text = "Товары";
            // 
            // CommodityDGV
            // 
            this.CommodityDGV.AllowUserToAddRows = false;
            this.CommodityDGV.AllowUserToDeleteRows = false;
            this.CommodityDGV.AutoGenerateColumns = false;
            this.CommodityDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CommodityDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.CommodityDGV.DataSource = this.commodityBS;
            this.CommodityDGV.Location = new System.Drawing.Point(0, 0);
            this.CommodityDGV.Name = "CommodityDGV";
            this.CommodityDGV.ReadOnly = true;
            this.CommodityDGV.Size = new System.Drawing.Size(394, 250);
            this.CommodityDGV.TabIndex = 0;
            // 
            // commodityBS
            // 
            this.commodityBS.DataMember = "commodity";
            this.commodityBS.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.SystemColors.Control;
            this.Clients.Controls.Add(this.ClientDGV);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(394, 250);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Клиенты";
            // 
            // ClientDGV
            // 
            this.ClientDGV.AllowUserToDeleteRows = false;
            this.ClientDGV.AutoGenerateColumns = false;
            this.ClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn});
            this.ClientDGV.DataSource = this.clientBS;
            this.ClientDGV.Location = new System.Drawing.Point(0, 0);
            this.ClientDGV.Name = "ClientDGV";
            this.ClientDGV.Size = new System.Drawing.Size(399, 250);
            this.ClientDGV.TabIndex = 2;
            this.ClientDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ClientDGV_DataError);
            // 
            // clientBS
            // 
            this.clientBS.DataMember = "client";
            this.clientBS.DataSource = this.dataSet;
            // 
            // ClientOrders
            // 
            this.ClientOrders.BackColor = System.Drawing.SystemColors.Control;
            this.ClientOrders.Controls.Add(this.ClientOrderDGV);
            this.ClientOrders.Location = new System.Drawing.Point(4, 22);
            this.ClientOrders.Name = "ClientOrders";
            this.ClientOrders.Size = new System.Drawing.Size(394, 250);
            this.ClientOrders.TabIndex = 2;
            this.ClientOrders.Text = "Заказы клиентов";
            // 
            // ClientOrderDGV
            // 
            this.ClientOrderDGV.AllowUserToAddRows = false;
            this.ClientOrderDGV.AllowUserToDeleteRows = false;
            this.ClientOrderDGV.AutoGenerateColumns = false;
            this.ClientOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientOrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.comidDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn1});
            this.ClientOrderDGV.DataSource = this.clientorderBS;
            this.ClientOrderDGV.Location = new System.Drawing.Point(0, 0);
            this.ClientOrderDGV.Name = "ClientOrderDGV";
            this.ClientOrderDGV.ReadOnly = true;
            this.ClientOrderDGV.Size = new System.Drawing.Size(394, 250);
            this.ClientOrderDGV.TabIndex = 0;
            // 
            // clientorderBS
            // 
            this.clientorderBS.DataMember = "client_order";
            this.clientorderBS.DataSource = this.dataSet;
            // 
            // ClientOrderButton
            // 
            this.ClientOrderButton.Location = new System.Drawing.Point(138, 285);
            this.ClientOrderButton.Name = "ClientOrderButton";
            this.ClientOrderButton.Size = new System.Drawing.Size(102, 23);
            this.ClientOrderButton.TabIndex = 5;
            this.ClientOrderButton.Text = "Оформить заказ";
            this.ClientOrderButton.UseVisualStyleBackColor = true;
            this.ClientOrderButton.Click += new System.EventHandler(this.ClientOrderButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(246, 285);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(75, 23);
            this.RejectButton.TabIndex = 6;
            this.RejectButton.Text = "Отменить";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(327, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // clientTA
            // 
            this.clientTA.ClearBeforeFill = true;
            // 
            // client_orderTA
            // 
            this.client_orderTA.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 83;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 133;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.DataSource = this.clientBS;
            this.clientidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientidDataGridViewTextBoxColumn.ValueMember = "id";
            this.clientidDataGridViewTextBoxColumn.Width = 133;
            // 
            // comidDataGridViewTextBoxColumn
            // 
            this.comidDataGridViewTextBoxColumn.DataPropertyName = "com_id";
            this.comidDataGridViewTextBoxColumn.DataSource = this.commodityBS;
            this.comidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.comidDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.comidDataGridViewTextBoxColumn.Name = "comidDataGridViewTextBoxColumn";
            this.comidDataGridViewTextBoxColumn.ReadOnly = true;
            this.comidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comidDataGridViewTextBoxColumn.ValueMember = "id";
            this.comidDataGridViewTextBoxColumn.Width = 130;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countDataGridViewTextBoxColumn1.Width = 70;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 312);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ClientOrderButton);
            this.Controls.Add(this.ManagerTB);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно приложения для продавцов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerForm_FormClosing);
            this.ManagerTB.ResumeLayout(false);
            this.Commodities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CommodityDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).EndInit();
            this.ClientOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientOrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManagerTB;
        private System.Windows.Forms.TabPage Commodities;
        private System.Windows.Forms.DataGridView CommodityDGV;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView ClientDGV;
        private System.Windows.Forms.TabPage ClientOrders;
        private System.Windows.Forms.DataGridView ClientOrderDGV;
        private System.Windows.Forms.Button ClientOrderButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button SaveButton;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource commodityBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.BindingSource clientBS;
        private DataSetTableAdapters.clientTableAdapter clientTA;
        private System.Windows.Forms.BindingSource clientorderBS;
        private DataSetTableAdapters.client_orderTableAdapter client_orderTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
    }
}