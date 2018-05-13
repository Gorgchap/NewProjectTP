using System.Windows.Forms;

namespace Warehouse
{
    public partial class ClientOrderForm : Form
    {
        public ClientOrderForm()
        {
            InitializeComponent();
            commodityTA.Fill(dataSet.commodity);
            client_orderTA.Fill(dataSet.client_order);
            clientTA.Fill(dataSet.client);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var row = dataSet.client_order.Newclient_orderRow();
            row.client_id = (long)Client.SelectedValue;
            row.com_id = (long)Commodity.SelectedValue;
            row.count = (long)ComCount.Value;
            for (int i = 0; i < dataSet.commodity.Rows.Count; i++)
                if (dataSet.commodity.Rows[i][0].Equals(row.com_id))
                {
                    if (row.count <= (long)dataSet.commodity.Rows[i][2])
                        dataSet.commodity.Rows[i][2] = (long)dataSet.commodity.Rows[i][2] - row.count;
                    else
                    {
                        MessageBox.Show("Недостаточно товара " + dataSet.commodity.Rows[i][1] + " на складе.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            dataSet.client_order.Rows.Add(row);
            commodityTA.Update(dataSet.commodity);
            client_orderTA.Update(dataSet.client_order);
            Close();
        }
    }
}