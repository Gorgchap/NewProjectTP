using System.Windows.Forms;

namespace Warehouse
{
    public partial class LogPassForm : Form
    {
        public LogPassForm()
        {
            InitializeComponent();
            personTA.Fill(dataSet.person);
        }

        private void EnterButton_Click(object sender, System.EventArgs e)
        {
            bool error = true;
            for (int i = 0; i < dataSet.person.Rows.Count; i++)
            {
                if (dataSet.person.Rows[i][0].Equals(Login.Text) && dataSet.person.Rows[i][1].Equals(Password.Text))
                {
                    Hide();
                    if (dataSet.person.Rows[i][2].Equals("Manager"))
                    {
                        ManagerForm m = new ManagerForm();
                        m.Show();
                        m.FormClosed += Back;
                    }
                    if (dataSet.person.Rows[i][2].Equals("Seller"))
                    {
                        SellerForm s = new SellerForm();
                        s.Show();
                        s.FormClosed += Back;
                    }
                    error = false;
                    break;
                }
            }
            if (error)
                MessageBox.Show("Неправильные логин и пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Back(object sender, FormClosedEventArgs e) { Show(); }
    }
}