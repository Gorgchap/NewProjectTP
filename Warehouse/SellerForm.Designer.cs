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
            this.ClientOrders = new System.Windows.Forms.TabPage();
            this.ClientOrderDGV = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Warehouse.DataSet();
            this.comidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientorderBS = new System.Windows.Forms.BindingSource(this.components);
            this.Commodities = new System.Windows.Forms.TabPage();
            this.ConsignmentDGV = new System.Windows.Forms.DataGridView();
            this.supidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierBS = new System.Windows.Forms.BindingSource(this.components);
            this.comidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consignmentBS = new System.Windows.Forms.BindingSource(this.components);
            this.Clients = new System.Windows.Forms.TabPage();
            this.ClientDGV = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientOrderButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.consignmentTA = new Warehouse.DataSetTableAdapters.consignmentTableAdapter();
            this.supplierTA = new Warehouse.DataSetTableAdapters.supplierTableAdapter();
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.clientTA = new Warehouse.DataSetTableAdapters.clientTableAdapter();
            this.client_orderTA = new Warehouse.DataSetTableAdapters.client_orderTableAdapter();
            this.ManagerTB.SuspendLayout();
            this.ClientOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientOrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBS)).BeginInit();
            this.Commodities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consignmentBS)).BeginInit();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerTB
            // 
            this.ManagerTB.Controls.Add(this.ClientOrders);
            this.ManagerTB.Controls.Add(this.Commodities);
            this.ManagerTB.Controls.Add(this.Clients);
            this.ManagerTB.Location = new System.Drawing.Point(3, 3);
            this.ManagerTB.Name = "ManagerTB";
            this.ManagerTB.SelectedIndex = 0;
            this.ManagerTB.Size = new System.Drawing.Size(523, 276);
            this.ManagerTB.TabIndex = 1;
            // 
            // ClientOrders
            // 
            this.ClientOrders.BackColor = System.Drawing.SystemColors.Control;
            this.ClientOrders.Controls.Add(this.ClientOrderDGV);
            this.ClientOrders.Location = new System.Drawing.Point(4, 22);
            this.ClientOrders.Name = "ClientOrders";
            this.ClientOrders.Size = new System.Drawing.Size(515, 250);
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
            this.comidDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.orderdateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn1});
            this.ClientOrderDGV.DataSource = this.clientorderBS;
            this.ClientOrderDGV.Location = new System.Drawing.Point(0, 0);
            this.ClientOrderDGV.Name = "ClientOrderDGV";
            this.ClientOrderDGV.ReadOnly = true;
            this.ClientOrderDGV.Size = new System.Drawing.Size(520, 250);
            this.ClientOrderDGV.TabIndex = 0;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.DataSource = this.clientBS;
            this.clientidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.clientidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientidDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientidDataGridViewTextBoxColumn.ValueMember = "id";
            this.clientidDataGridViewTextBoxColumn.Width = 147;
            // 
            // clientBS
            // 
            this.clientBS.DataMember = "client";
            this.clientBS.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comidDataGridViewTextBoxColumn1
            // 
            this.comidDataGridViewTextBoxColumn1.DataPropertyName = "com_id";
            this.comidDataGridViewTextBoxColumn1.DataSource = this.commodityBS;
            this.comidDataGridViewTextBoxColumn1.DisplayMember = "name";
            this.comidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.comidDataGridViewTextBoxColumn1.HeaderText = "Товар";
            this.comidDataGridViewTextBoxColumn1.Name = "comidDataGridViewTextBoxColumn1";
            this.comidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.comidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comidDataGridViewTextBoxColumn1.ValueMember = "id";
            // 
            // commodityBS
            // 
            this.commodityBS.DataMember = "commodity";
            this.commodityBS.DataSource = this.dataSet;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 70;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderdateDataGridViewTextBoxColumn.Width = 70;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countDataGridViewTextBoxColumn1.Width = 65;
            // 
            // clientorderBS
            // 
            this.clientorderBS.DataMember = "client_order";
            this.clientorderBS.DataSource = this.dataSet;
            // 
            // Commodities
            // 
            this.Commodities.BackColor = System.Drawing.SystemColors.Control;
            this.Commodities.Controls.Add(this.ConsignmentDGV);
            this.Commodities.Location = new System.Drawing.Point(4, 22);
            this.Commodities.Name = "Commodities";
            this.Commodities.Padding = new System.Windows.Forms.Padding(3);
            this.Commodities.Size = new System.Drawing.Size(515, 250);
            this.Commodities.TabIndex = 0;
            this.Commodities.Text = "Товары";
            // 
            // ConsignmentDGV
            // 
            this.ConsignmentDGV.AllowUserToAddRows = false;
            this.ConsignmentDGV.AllowUserToDeleteRows = false;
            this.ConsignmentDGV.AutoGenerateColumns = false;
            this.ConsignmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsignmentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supidDataGridViewTextBoxColumn,
            this.comidDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.condateDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.ConsignmentDGV.DataSource = this.consignmentBS;
            this.ConsignmentDGV.Location = new System.Drawing.Point(-3, 0);
            this.ConsignmentDGV.Name = "ConsignmentDGV";
            this.ConsignmentDGV.ReadOnly = true;
            this.ConsignmentDGV.Size = new System.Drawing.Size(520, 250);
            this.ConsignmentDGV.TabIndex = 1;
            // 
            // supidDataGridViewTextBoxColumn
            // 
            this.supidDataGridViewTextBoxColumn.DataPropertyName = "sup_id";
            this.supidDataGridViewTextBoxColumn.DataSource = this.supplierBS;
            this.supidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.supidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.supidDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supidDataGridViewTextBoxColumn.Name = "supidDataGridViewTextBoxColumn";
            this.supidDataGridViewTextBoxColumn.ReadOnly = true;
            this.supidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supidDataGridViewTextBoxColumn.ValueMember = "id";
            this.supidDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierBS
            // 
            this.supplierBS.DataMember = "supplier";
            this.supplierBS.DataSource = this.dataSet;
            // 
            // comidDataGridViewTextBoxColumn
            // 
            this.comidDataGridViewTextBoxColumn.DataPropertyName = "com_id";
            this.comidDataGridViewTextBoxColumn.DataSource = this.commodityBS;
            this.comidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.comidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.comidDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.comidDataGridViewTextBoxColumn.Name = "comidDataGridViewTextBoxColumn";
            this.comidDataGridViewTextBoxColumn.ReadOnly = true;
            this.comidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 70;
            // 
            // condateDataGridViewTextBoxColumn
            // 
            this.condateDataGridViewTextBoxColumn.DataPropertyName = "con_date";
            this.condateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.condateDataGridViewTextBoxColumn.Name = "condateDataGridViewTextBoxColumn";
            this.condateDataGridViewTextBoxColumn.ReadOnly = true;
            this.condateDataGridViewTextBoxColumn.Width = 70;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 65;
            // 
            // consignmentBS
            // 
            this.consignmentBS.DataMember = "consignment";
            this.consignmentBS.DataSource = this.dataSet;
            // 
            // Clients
            // 
            this.Clients.BackColor = System.Drawing.SystemColors.Control;
            this.Clients.Controls.Add(this.ClientDGV);
            this.Clients.Location = new System.Drawing.Point(4, 22);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(515, 250);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Клиенты";
            // 
            // ClientDGV
            // 
            this.ClientDGV.AllowUserToDeleteRows = false;
            this.ClientDGV.AutoGenerateColumns = false;
            this.ClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.ClientDGV.DataSource = this.clientBS;
            this.ClientDGV.Location = new System.Drawing.Point(0, 0);
            this.ClientDGV.Name = "ClientDGV";
            this.ClientDGV.Size = new System.Drawing.Size(520, 250);
            this.ClientDGV.TabIndex = 2;
            this.ClientDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ClientDGV_DataError);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 131;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 110;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 215;
            // 
            // ClientOrderButton
            // 
            this.ClientOrderButton.Location = new System.Drawing.Point(263, 285);
            this.ClientOrderButton.Name = "ClientOrderButton";
            this.ClientOrderButton.Size = new System.Drawing.Size(102, 23);
            this.ClientOrderButton.TabIndex = 5;
            this.ClientOrderButton.Text = "Оформить заказ";
            this.ClientOrderButton.UseVisualStyleBackColor = true;
            this.ClientOrderButton.Click += new System.EventHandler(this.ClientOrderButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(371, 285);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(75, 23);
            this.RejectButton.TabIndex = 6;
            this.RejectButton.Text = "Отменить";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(452, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // consignmentTA
            // 
            this.consignmentTA.ClearBeforeFill = true;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
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
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.ClientOrderButton);
            this.Controls.Add(this.ManagerTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно приложения для продавцов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerForm_FormClosing);
            this.ManagerTB.ResumeLayout(false);
            this.ClientOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientOrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBS)).EndInit();
            this.Commodities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consignmentBS)).EndInit();
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManagerTB;
        private System.Windows.Forms.TabPage Commodities;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView ClientDGV;
        private System.Windows.Forms.TabPage ClientOrders;
        private System.Windows.Forms.DataGridView ClientOrderDGV;
        private System.Windows.Forms.Button ClientOrderButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView ConsignmentDGV;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource consignmentBS;
        private DataSetTableAdapters.consignmentTableAdapter consignmentTA;
        private System.Windows.Forms.BindingSource supplierBS;
        private DataSetTableAdapters.supplierTableAdapter supplierTA;
        private System.Windows.Forms.BindingSource commodityBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.DataGridViewComboBoxColumn supidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBS;
        private DataSetTableAdapters.clientTableAdapter clientTA;
        private System.Windows.Forms.BindingSource clientorderBS;
        private DataSetTableAdapters.client_orderTableAdapter client_orderTA;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}