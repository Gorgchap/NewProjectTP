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
            this.sup_orderTA = new Warehouse.DataSetTableAdapters.sup_orderTableAdapter();
            this.SupLabel = new System.Windows.Forms.Label();
            this.Supplier = new System.Windows.Forms.ComboBox();
            this.suporderBS = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBS = new System.Windows.Forms.BindingSource(this.components);
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.supplierTA = new Warehouse.DataSetTableAdapters.supplierTableAdapter();
            this.ComLabel = new System.Windows.Forms.Label();
            this.Commodity = new System.Windows.Forms.ComboBox();
            this.ComCount = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suporderBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sup_orderTA
            // 
            this.sup_orderTA.ClearBeforeFill = true;
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
            this.Supplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suporderBS, "sup_id", true));
            this.Supplier.DataSource = this.supplierBS;
            this.Supplier.DisplayMember = "name";
            this.Supplier.FormattingEnabled = true;
            this.Supplier.Location = new System.Drawing.Point(84, 10);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(172, 21);
            this.Supplier.TabIndex = 1;
            this.Supplier.ValueMember = "id";
            // 
            // suporderBS
            // 
            this.suporderBS.DataMember = "sup_order";
            this.suporderBS.DataSource = this.dataSet;
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
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // supplierTA
            // 
            this.supplierTA.ClearBeforeFill = true;
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
            this.Commodity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suporderBS, "com_id", true));
            this.Commodity.DataSource = this.commodityBS;
            this.Commodity.DisplayMember = "name";
            this.Commodity.FormattingEnabled = true;
            this.Commodity.Location = new System.Drawing.Point(84, 37);
            this.Commodity.Name = "Commodity";
            this.Commodity.Size = new System.Drawing.Size(172, 21);
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
            this.ComCount.Size = new System.Drawing.Size(57, 20);
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
            this.AddButton.Location = new System.Drawing.Point(181, 64);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "ОК";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SupOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 91);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.ComCount);
            this.Controls.Add(this.Commodity);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.SupLabel);
            this.Name = "SupOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ поставщику";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suporderBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private DataSetTableAdapters.sup_orderTableAdapter sup_orderTA;
        private System.Windows.Forms.Label SupLabel;
        private System.Windows.Forms.ComboBox Supplier;
        private System.Windows.Forms.BindingSource commodityBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.BindingSource suporderBS;
        private System.Windows.Forms.BindingSource supplierBS;
        private DataSetTableAdapters.supplierTableAdapter supplierTA;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.ComboBox Commodity;
        private System.Windows.Forms.NumericUpDown ComCount;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button AddButton;
    }
}