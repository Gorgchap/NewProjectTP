using System;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            client_orderTA.Fill(dataSet.client_order);
            clientTA.Fill(dataSet.client);
            commodityTA.Fill(dataSet.commodity);
        }

        private void ClientOrderButton_Click(object sender, EventArgs e)
        {
            ClientOrderForm c = new ClientOrderForm();
            c.Show();
            c.FormClosed += SaveData;
        }

        private void SaveData(object sender, FormClosedEventArgs e)
        {
            commodityTA.Fill(dataSet.commodity);
            client_orderTA.Fill(dataSet.client_order);
        }

        private void RejectButton_Click(object sender, EventArgs e) { dataSet.client.RejectChanges(); }

        private void SaveButton_Click(object sender, EventArgs e) { clientTA.Update(dataSet.client); }

        private void ClientDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string status = "";
            if (e.RowIndex >= dataSet.client.Count)
                status = "будет удалена, так как не были заполнены все столбцы.";
            else
                status = "не была изменена.";
            MessageBox.Show(string.Format("Строка {0} {1}", e.RowIndex + 1, status), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SellerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataSet.client.GetChanges() != null)
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