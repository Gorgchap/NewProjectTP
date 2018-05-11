namespace Warehouse
{
    partial class AddForm
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
            this.dataSet = new Warehouse.DataSet();
            this.commodityTA = new Warehouse.DataSetTableAdapters.commodityTableAdapter();
            this.AddLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // commodityTA
            // 
            this.commodityTA.ClearBeforeFill = true;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Location = new System.Drawing.Point(12, 13);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(83, 13);
            this.AddLabel.TabIndex = 0;
            this.AddLabel.Text = "Наименование";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(102, 10);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(166, 20);
            this.NameBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(102, 36);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "ОК";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 62);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddLabel);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новый товар";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet dataSet;
        private DataSetTableAdapters.commodityTableAdapter commodityTA;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button AddButton;
    }
}