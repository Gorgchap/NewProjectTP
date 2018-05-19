using System.Collections.Generic;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class ClientOrderForm : Form
    {
        public ClientOrderForm()
        {
            InitializeComponent();
            clientTA.Fill(dataSet.client);
            client_orderTA.Fill(dataSet.client_order);
            commodityTA.Fill(dataSet.commodity);
            consignmentTA.Fill(dataSet.consignment);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            long count = 0, counter = (long)ComCount.Value; double sum = 0;
            List<DataSet.consignmentRow> list = new List<DataSet.consignmentRow>();
            foreach (DataSet.consignmentRow r in dataSet.consignment.Rows)
                if (r.com_id.Equals((long)Commodity.SelectedValue) && r.con_date <= Date.Value)
                {
                    list.Add(r);
                    count += r.count;
                }
            if (count < ComCount.Value)
            {
                MessageBox.Show("Недостаточно товара на складе.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            list.Sort((a, b) => a.con_date.CompareTo(b.con_date));
            foreach (DataSet.consignmentRow r in list)
            {
                if (counter >= r.count)
                {
                    sum += r.price * r.count;
                    counter -= r.count;
                    consignmentTA.Delete(r.id, r.sup_id, r.com_id, r.price, r.con_date, r.count);
                }
                else
                {
                    sum += r.price * counter;
                    r.count -= counter;
                    break;
                }
            }
            DataSet.client_orderRow row = dataSet.client_order.Newclient_orderRow();
            row.client_id = (long)Client.SelectedValue;
            row.com_id = (long)Commodity.SelectedValue;
            row.count = (long)ComCount.Value;
            row.order_date = Date.Value;
            row.price = System.Math.Round(sum / row.count, 2);
            dataSet.client_order.Rows.Add(row);
            consignmentTA.Update(dataSet.consignment);
            client_orderTA.Update(dataSet.client_order);
            Close();
        }
    }
}