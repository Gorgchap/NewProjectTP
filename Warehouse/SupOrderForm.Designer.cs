namespace Warehouse
{
    partial class SupOrderForm
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
            this.dataSet = new Warehouse.DataSet();
            this.consignmentTA = new Warehouse.DataSetTableAdapters.consignmentTableAdapter();
            this.SupLabel = new System.Windows.Forms.Label();
            this.Supplier = new System.Windows.Forms.ComboBox();
            this.consignmentBS = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBS = new System.Windows.Forms.BindingSource(this.components);
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.ComLabel = new System.Windows.Forms.Label();
            this.Commodity = new System.Windows.Forms.ComboBox();
            this.ComCount = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.supplierTA = new Warehouse.DataSetTableAdapters.supplierTableAdapter();
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consignmentBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consignmentTA
            // 
            this.consignmentTA.ClearBeforeFill = true;
            // 
            // SupLabel
            // 
            this.SupLabel.AutoSize = true;
            this.SupLabel.Location = new System.Drawing.Point(9, 13);
            this.SupLabel.Name = "SupLabel";
            this.SupLabel.Size = new System.Drawing.Size(65, 13);
            this.SupLabel.TabIndex = 0;
            this.SupLabel.Text = "Поставщик";
            // 
            // Supplier
            // 
            this.Supplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consignmentBS, "sup_id", true));
            this.Supplier.DataSource = this.supplierBS;
            this.Supplier.DisplayMember = "name";
            this.Supplier.FormattingEnabled = true;
            this.Supplier.Location = new System.Drawing.Point(84, 10);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(214, 21);
            this.Supplier.TabIndex = 1;
            this.Supplier.ValueMember = "id";
            // 
            // consignmentBS
            // 
            this.consignmentBS.DataMember = "consignment";
            this.consignmentBS.DataSource = this.dataSet;
            // 
            // supplierBS
            // 
            this.supplierBS.DataMember = "supplier";
            this.supplierBS.DataSource = this.dataSet;
            // 
            // commodityBS
            // 
            this.commodityBS.DataMember = "commodity";
            this.commodityBS.DataSource = this.dataSet;
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(9, 40);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(38, 13);
            this.ComLabel.TabIndex = 2;
            this.ComLabel.Text = "Товар";
            // 
            // Commodity
            // 
            this.Commodity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consignmentBS, "com_id", true));
            this.Commodity.DataSource = this.commodityBS;
            this.Commodity.DisplayMember = "name";
            this.Commodity.FormattingEnabled = true;
            this.Commodity.Location = new System.Drawing.Point(84, 37);
            this.Commodity.Name = "Commodity";
            this.Commodity.Size = new System.Drawing.Size(214, 21);
            this.Commodity.TabIndex = 3;
            this.Commodity.ValueMember = "id";
            // 
            // ComCount
            // 
            this.ComCount.Location = new System.Drawing.Point(84, 64);
            this.ComCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ComCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ComCount.Name = "ComCount";
            this.ComCount.Size = new System.Drawing.Size(214, 20);
            this.ComCount.TabIndex = 4;
            this.ComCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(9, 66);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(66, 13);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "Количество";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(223, 119);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "ОК";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(9, 94);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Цена";
            // 
            // Price
            // 
            this.Price.DecimalPlaces = 2;
            this.Price.Increment = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            this.Price.Location = new System.Drawing.Point(84, 90);
            this.Price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Price.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(214, 20);
            this.Price.TabIndex = 8;
            this.Price.Value = new decimal(new int[] {
            10,
            0,
            0,
            196608});
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(9, 121);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(83, 13);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Дата поставки";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(98, 119);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(119, 20);
            this.Date.TabIndex = 10;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
            // 
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // SupOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 145);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ComCount);
            this.Controls.Add(this.Commodity);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.SupLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SupOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ поставщику";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consignmentBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private DataSetTableAdapters.consignmentTableAdapter consignmentTA;
        private System.Windows.Forms.Label SupLabel;
        private System.Windows.Forms.ComboBox Supplier;
        private System.Windows.Forms.BindingSource commodityBS;
        private System.Windows.Forms.BindingSource supplierBS;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.ComboBox Commodity;
        private System.Windows.Forms.NumericUpDown ComCount;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker Date;
        private DataSetTableAdapters.supplierTableAdapter supplierTA;
        private System.Windows.Forms.BindingSource consignmentBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
    }
}