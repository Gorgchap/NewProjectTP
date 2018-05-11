using System.Windows.Forms;

namespace Warehouse
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            commodityTA.Fill(dataSet.commodity);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text))
            {
                MessageBox.Show("Введите наименование товара", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var row = dataSet.commodity.NewcommodityRow();
            row.name = NameBox.Text;
            row.count = 0;
            dataSet.commodity.Rows.Add(row);
            commodityTA.Update(dataSet.commodity);
            Close();
        }
    }
}