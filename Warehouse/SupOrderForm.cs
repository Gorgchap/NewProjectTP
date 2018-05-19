using System.Windows.Forms;

namespace Warehouse
{
    public partial class SupOrderForm : Form
    {
        public SupOrderForm()
        {
            InitializeComponent();
            supplierTA.Fill(dataSet.supplier);
            commodityTA.Fill(dataSet.commodity);
            consignmentTA.Fill(dataSet.consignment);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            DataSet.consignmentRow row = dataSet.consignment.NewconsignmentRow();
            row.sup_id = (long)Supplier.SelectedValue;
            row.com_id = (long)Commodity.SelectedValue;
            row.count = (long)ComCount.Value;
            row.price = (double)Price.Value;
            row.con_date = Date.Value;
            dataSet.consignment.Rows.Add(row);
            consignmentTA.Update(dataSet.consignment);
            Close();
        }
    }
}