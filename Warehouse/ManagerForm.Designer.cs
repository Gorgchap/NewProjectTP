namespace Warehouse
{
    partial class ManagerForm
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Warehouse.DataSet();
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.SupplierDGV = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBS = new System.Windows.Forms.BindingSource(this.components);
            this.SupOrders = new System.Windows.Forms.TabPage();
            this.SupOrderDGV = new System.Windows.Forms.DataGridView();
            this.supidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suporderBS = new System.Windows.Forms.BindingSource(this.components);
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.supplierTA = new Warehouse.DataSetTableAdapters.supplierTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SupOrderButton = new System.Windows.Forms.Button();
            this.sup_orderTA = new Warehouse.DataSetTableAdapters.sup_orderTableAdapter();
            this.ManagerTB.SuspendLayout();
            this.Commodities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommodityDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).BeginInit();
            this.SupOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupOrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suporderBS)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerTB
            // 
            this.ManagerTB.Controls.Add(this.Commodities);
            this.ManagerTB.Controls.Add(this.Suppliers);
            this.ManagerTB.Controls.Add(this.SupOrders);
            this.ManagerTB.Location = new System.Drawing.Point(4, 3);
            this.ManagerTB.Name = "ManagerTB";
            this.ManagerTB.SelectedIndex = 0;
            this.ManagerTB.Size = new System.Drawing.Size(402, 276);
            this.ManagerTB.TabIndex = 0;
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
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.SystemColors.Control;
            this.Suppliers.Controls.Add(this.SupplierDGV);
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers.Size = new System.Drawing.Size(394, 250);
            this.Suppliers.TabIndex = 1;
            this.Suppliers.Text = "Поставщики";
            // 
            // SupplierDGV
            // 
            this.SupplierDGV.AllowUserToDeleteRows = false;
            this.SupplierDGV.AutoGenerateColumns = false;
            this.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.SupplierDGV.DataSource = this.supplierBS;
            this.SupplierDGV.Location = new System.Drawing.Point(0, 0);
            this.SupplierDGV.Name = "SupplierDGV";
            this.SupplierDGV.Size = new System.Drawing.Size(399, 250);
            this.SupplierDGV.TabIndex = 2;
            this.SupplierDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SupplierDGV_DataError);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.MaxInputLength = 255;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 75;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.MaxInputLength = 255;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 175;
            // 
            // supplierBS
            // 
            this.supplierBS.DataMember = "supplier";
            this.supplierBS.DataSource = this.dataSet;
            // 
            // SupOrders
            // 
            this.SupOrders.BackColor = System.Drawing.SystemColors.Control;
            this.SupOrders.Controls.Add(this.SupOrderDGV);
            this.SupOrders.Location = new System.Drawing.Point(4, 22);
            this.SupOrders.Name = "SupOrders";
            this.SupOrders.Size = new System.Drawing.Size(394, 250);
            this.SupOrders.TabIndex = 2;
            this.SupOrders.Text = "Заказы от поставщиков";
            // 
            // SupOrderDGV
            // 
            this.SupOrderDGV.AllowUserToAddRows = false;
            this.SupOrderDGV.AllowUserToDeleteRows = false;
            this.SupOrderDGV.AutoGenerateColumns = false;
            this.SupOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupOrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supidDataGridViewTextBoxColumn,
            this.comidDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn1});
            this.SupOrderDGV.DataSource = this.suporderBS;
            this.SupOrderDGV.Location = new System.Drawing.Point(0, 0);
            this.SupOrderDGV.Name = "SupOrderDGV";
            this.SupOrderDGV.ReadOnly = true;
            this.SupOrderDGV.Size = new System.Drawing.Size(394, 250);
            this.SupOrderDGV.TabIndex = 0;
            // 
            // supidDataGridViewTextBoxColumn
            // 
            this.supidDataGridViewTextBoxColumn.DataPropertyName = "sup_id";
            this.supidDataGridViewTextBoxColumn.DataSource = this.supplierBS;
            this.supidDataGridViewTextBoxColumn.DisplayMember = "name";
            this.supidDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supidDataGridViewTextBoxColumn.Name = "supidDataGridViewTextBoxColumn";
            this.supidDataGridViewTextBoxColumn.ReadOnly = true;
            this.supidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supidDataGridViewTextBoxColumn.ValueMember = "id";
            this.supidDataGridViewTextBoxColumn.Width = 140;
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
            this.comidDataGridViewTextBoxColumn.Width = 140;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countDataGridViewTextBoxColumn1.Width = 70;
            // 
            // suporderBS
            // 
            this.suporderBS.DataMember = "sup_order";
            this.suporderBS.DataSource = this.dataSet;
            // 
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(34, 285);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить товар";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(246, 285);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(75, 23);
            this.RejectButton.TabIndex = 2;
            this.RejectButton.Text = "Отменить";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(327, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SupOrderButton
            // 
            this.SupOrderButton.Location = new System.Drawing.Point(140, 285);
            this.SupOrderButton.Name = "SupOrderButton";
            this.SupOrderButton.Size = new System.Drawing.Size(100, 23);
            this.SupOrderButton.TabIndex = 4;
            this.SupOrderButton.Text = "Сделать заказ";
            this.SupOrderButton.UseVisualStyleBackColor = true;
            this.SupOrderButton.Click += new System.EventHandler(this.SupOrderButton_Click);
            // 
            // sup_orderTA
            // 
            this.sup_orderTA.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 313);
            this.Controls.Add(this.SupOrderButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ManagerTB);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно приложения для менеджеров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.ManagerTB.ResumeLayout(false);
            this.Commodities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CommodityDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).EndInit();
            this.SupOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupOrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suporderBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManagerTB;
        private System.Windows.Forms.TabPage Commodities;
        private System.Windows.Forms.DataGridView CommodityDGV;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.TabPage SupOrders;
        private System.Windows.Forms.DataGridView SupOrderDGV;
        private System.Windows.Forms.BindingSource suporderBS;
        private DataSetTableAdapters.sup_orderTableAdapter sup_orderTA;
        private System.Windows.Forms.BindingSource commodityBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.DataGridView SupplierDGV;
        private System.Windows.Forms.BindingSource supplierBS;
        private DataSetTableAdapters.supplierTableAdapter supplierTA;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SupOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataSet dataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
    }
}