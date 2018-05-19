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
            this.Consignments = new System.Windows.Forms.TabPage();
            this.ConsignmentDGV = new System.Windows.Forms.DataGridView();
            this.supidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supplierBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Warehouse.DataSet();
            this.comidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consignmentBS = new System.Windows.Forms.BindingSource(this.components);
            this.Suppliers = new System.Windows.Forms.TabPage();
            this.SupplierDGV = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.RejectButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SupOrderButton = new System.Windows.Forms.Button();
            this.consignmentTA = new Warehouse.DataSetTableAdapters.consignmentTableAdapter();
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.supplierTA = new Warehouse.DataSetTableAdapters.supplierTableAdapter();
            this.ManagerTB.SuspendLayout();
            this.Consignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consignmentBS)).BeginInit();
            this.Suppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerTB
            // 
            this.ManagerTB.Controls.Add(this.Consignments);
            this.ManagerTB.Controls.Add(this.Suppliers);
            this.ManagerTB.Location = new System.Drawing.Point(4, 3);
            this.ManagerTB.Name = "ManagerTB";
            this.ManagerTB.SelectedIndex = 0;
            this.ManagerTB.Size = new System.Drawing.Size(523, 276);
            this.ManagerTB.TabIndex = 0;
            // 
            // Consignments
            // 
            this.Consignments.BackColor = System.Drawing.SystemColors.Control;
            this.Consignments.Controls.Add(this.ConsignmentDGV);
            this.Consignments.Location = new System.Drawing.Point(4, 22);
            this.Consignments.Name = "Consignments";
            this.Consignments.Padding = new System.Windows.Forms.Padding(3);
            this.Consignments.Size = new System.Drawing.Size(515, 250);
            this.Consignments.TabIndex = 0;
            this.Consignments.Text = "Партии товаров";
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
            this.dataGridViewTextBoxColumn1});
            this.ConsignmentDGV.DataSource = this.consignmentBS;
            this.ConsignmentDGV.Location = new System.Drawing.Point(0, 0);
            this.ConsignmentDGV.Name = "ConsignmentDGV";
            this.ConsignmentDGV.ReadOnly = true;
            this.ConsignmentDGV.Size = new System.Drawing.Size(520, 250);
            this.ConsignmentDGV.TabIndex = 0;
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
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // commodityBS
            // 
            this.commodityBS.DataMember = "commodity";
            this.commodityBS.DataSource = this.dataSet;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn1.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // consignmentBS
            // 
            this.consignmentBS.DataMember = "consignment";
            this.consignmentBS.DataSource = this.dataSet;
            // 
            // Suppliers
            // 
            this.Suppliers.BackColor = System.Drawing.SystemColors.Control;
            this.Suppliers.Controls.Add(this.SupplierDGV);
            this.Suppliers.Location = new System.Drawing.Point(4, 22);
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Padding = new System.Windows.Forms.Padding(3);
            this.Suppliers.Size = new System.Drawing.Size(515, 250);
            this.Suppliers.TabIndex = 1;
            this.Suppliers.Text = "Поставщики";
            // 
            // SupplierDGV
            // 
            this.SupplierDGV.AllowUserToDeleteRows = false;
            this.SupplierDGV.AllowUserToResizeColumns = false;
            this.SupplierDGV.AllowUserToResizeRows = false;
            this.SupplierDGV.AutoGenerateColumns = false;
            this.SupplierDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.SupplierDGV.DataSource = this.supplierBS;
            this.SupplierDGV.Location = new System.Drawing.Point(0, 0);
            this.SupplierDGV.Name = "SupplierDGV";
            this.SupplierDGV.Size = new System.Drawing.Size(520, 250);
            this.SupplierDGV.TabIndex = 2;
            this.SupplierDGV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SupplierDGV_DataError);
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
            this.addressDataGridViewTextBoxColumn.Width = 210;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(159, 285);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить товар";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(371, 285);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(75, 23);
            this.RejectButton.TabIndex = 2;
            this.RejectButton.Text = "Отменить";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(452, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SupOrderButton
            // 
            this.SupOrderButton.Location = new System.Drawing.Point(265, 285);
            this.SupOrderButton.Name = "SupOrderButton";
            this.SupOrderButton.Size = new System.Drawing.Size(100, 23);
            this.SupOrderButton.TabIndex = 4;
            this.SupOrderButton.Text = "Сделать заказ";
            this.SupOrderButton.UseVisualStyleBackColor = true;
            this.SupOrderButton.Click += new System.EventHandler(this.SupOrderButton_Click);
            // 
            // consignmentTA
            // 
            this.consignmentTA.ClearBeforeFill = true;
            // 
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.SupOrderButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ManagerTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно приложения для менеджеров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.ManagerTB.ResumeLayout(false);
            this.Consignments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsignmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consignmentBS)).EndInit();
            this.Suppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ManagerTB;
        private System.Windows.Forms.TabPage Consignments;
        private System.Windows.Forms.DataGridView ConsignmentDGV;
        private System.Windows.Forms.TabPage Suppliers;
        private System.Windows.Forms.DataGridView SupplierDGV;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SupOrderButton;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource consignmentBS;
        private DataSetTableAdapters.consignmentTableAdapter consignmentTA;
        private System.Windows.Forms.BindingSource commodityBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.BindingSource supplierBS;
        private DataSetTableAdapters.supplierTableAdapter supplierTA;
        private System.Windows.Forms.DataGridViewComboBoxColumn supidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}