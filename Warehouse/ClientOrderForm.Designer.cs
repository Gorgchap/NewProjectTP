namespace Warehouse
{
    partial class ClientOrderForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            this.ClientLabel = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.ComboBox();
            this.clientorderBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Warehouse.DataSet();
            this.clientBS = new System.Windows.Forms.BindingSource(this.components);
            this.clientTA = new Warehouse.DataSetTableAdapters.clientTableAdapter();
            this.client_orderTA = new Warehouse.DataSetTableAdapters.client_orderTableAdapter();
            this.ComLabel = new System.Windows.Forms.Label();
            this.Commodity = new System.Windows.Forms.ComboBox();
            this.commodityBS = new System.Windows.Forms.BindingSource(this.components);
            this.CountLabel = new System.Windows.Forms.Label();
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.ComCount = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.consignmentTA = new Warehouse.DataSetTableAdapters.consignmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComCount)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(9, 13);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(43, 13);
            this.ClientLabel.TabIndex = 1;
            this.ClientLabel.Text = "Клиент";
            // 
            // Client
            // 
            this.Client.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientorderBS, "client_id", true));
            this.Client.DataSource = this.clientBS;
            this.Client.DisplayMember = "name";
            this.Client.FormattingEnabled = true;
            this.Client.Location = new System.Drawing.Point(84, 10);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(172, 21);
            this.Client.TabIndex = 2;
            this.Client.ValueMember = "id";
            // 
            // clientorderBS
            // 
            this.clientorderBS.DataMember = "client_order";
            this.clientorderBS.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBS
            // 
            this.clientBS.DataMember = "client";
            this.clientBS.DataSource = this.dataSet;
            // 
            // clientTA
            // 
            this.clientTA.ClearBeforeFill = true;
            // 
            // client_orderTA
            // 
            this.client_orderTA.ClearBeforeFill = true;
            // 
            // ComLabel
            // 
            this.ComLabel.AutoSize = true;
            this.ComLabel.Location = new System.Drawing.Point(9, 40);
            this.ComLabel.Name = "ComLabel";
            this.ComLabel.Size = new System.Drawing.Size(38, 13);
            this.ComLabel.TabIndex = 3;
            this.ComLabel.Text = "Товар";
            // 
            // Commodity
            // 
            this.Commodity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientorderBS, "com_id", true));
            this.Commodity.DataSource = this.commodityBS;
            this.Commodity.DisplayMember = "name";
            this.Commodity.FormattingEnabled = true;
            this.Commodity.Location = new System.Drawing.Point(84, 37);
            this.Commodity.Name = "Commodity";
            this.Commodity.Size = new System.Drawing.Size(172, 21);
            this.Commodity.TabIndex = 4;
            this.Commodity.ValueMember = "id";
            // 
            // commodityBS
            // 
            this.commodityBS.DataMember = "commodity";
            this.commodityBS.DataSource = this.dataSet;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(9, 93);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(66, 13);
            this.CountLabel.TabIndex = 6;
            this.CountLabel.Text = "Количество";
            // 
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // ComCount
            // 
            this.ComCount.Location = new System.Drawing.Point(98, 91);
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
            this.ComCount.TabIndex = 7;
            this.ComCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(181, 91);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "ОК";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(9, 67);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(83, 13);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Дата поставки";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(98, 64);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(158, 20);
            this.Date.TabIndex = 11;
            // 
            // consignmentTA
            // 
            this.consignmentTA.ClearBeforeFill = true;
            // 
            // ClientOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 117);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ComCount);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Commodity);
            this.Controls.Add(this.ComLabel);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.ClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ клиента";
            ((System.ComponentModel.ISupportInitialize)(this.clientorderBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commodityBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.ComboBox Client;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource clientBS;
        private DataSetTableAdapters.clientTableAdapter clientTA;
        private System.Windows.Forms.BindingSource clientorderBS;
        private DataSetTableAdapters.client_orderTableAdapter client_orderTA;
        private System.Windows.Forms.Label ComLabel;
        private System.Windows.Forms.ComboBox Commodity;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.BindingSource commodityBS;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.NumericUpDown ComCount;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker Date;
        private DataSetTableAdapters.consignmentTableAdapter consignmentTA;
    }
}