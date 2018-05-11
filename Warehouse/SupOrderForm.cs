using System.Windows.Forms;

namespace Warehouse
{
    public partial class SupOrderForm : Form
    {
        public SupOrderForm()
        {
            InitializeComponent();
            commodityTA.Fill(dataSet.commodity);
            supplierTA.Fill(dataSet.supplier);
            sup_orderTA.Fill(dataSet.sup_order);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            var row = dataSet.sup_order.Newsup_orderRow();
            row.sup_id = (long)Supplier.SelectedValue;
            row.com_id = (long)Commodity.SelectedValue;
            row.count = (long)ComCount.Value;
            dataSet.sup_order.Rows.Add(row);
            for (int i = 0; i < dataSet.commodity.Rows.Count; i++)
                if (dataSet.commodity.Rows[i][0].Equals(row.com_id))
                    dataSet.commodity.Rows[i][2] = (long)dataSet.commodity.Rows[i][2] + row.count;
            commodityTA.Update(dataSet.commodity);
            sup_orderTA.Update(dataSet.sup_order);
            Close();
        }
    }
}