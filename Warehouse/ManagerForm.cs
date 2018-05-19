using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            commodityTA.Fill(dataSet.commodity);
            supplierTA.Fill(dataSet.supplier);
            consignmentTA.Fill(dataSet.consignment);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm a = new AddForm();
            a.Show();
            a.FormClosed += SaveData;
        }

        private void SaveData(object sender, FormClosedEventArgs e)
        {
            commodityTA.Fill(dataSet.commodity);
            consignmentTA.Fill(dataSet.consignment);
        }

        private void RejectButton_Click(object sender, EventArgs e) { dataSet.supplier.RejectChanges(); }

        private void SaveButton_Click(object sender, EventArgs e) { supplierTA.Update(dataSet.supplier); }

        private void SupOrderButton_Click(object sender, EventArgs e)
        {
            SupOrderForm s = new SupOrderForm();
            s.Show();
            s.FormClosed += SaveData;
        }

        private void SupplierDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string status = "";
            if (e.RowIndex >= dataSet.supplier.Count)
                status = "будет удалена, так как не были заполнены все столбцы.";
            else
                status = "не была изменена.";
            MessageBox.Show(string.Format("Строка {0} {1}", e.RowIndex + 1, status), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataSet.supplier.GetChanges() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Имеются несохранённые данные. Выполнить сохранение?",
                    "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        SaveButton_Click(sender, e);
                        break;
                }
            }
        }
    }
}