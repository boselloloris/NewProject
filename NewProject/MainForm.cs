using System.Windows.Forms;

namespace NewProject
{
    public partial class MainForm : Form
    {
        List<CustomerDataGridView> list;

        public MainForm()
        {
            InitializeComponent();
            list = new List<CustomerDataGridView>();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CustomerDataGridView customerDataGridView = new CustomerDataGridView();

            using (RegistrationForm form2 = new RegistrationForm(customerDataGridView))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    DgvCustomer.DataSource = null;

                    list.Add(customerDataGridView);

                    DgvCustomer.DataSource = list; 
                    DgvCustomer.Refresh();
                    DgvCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                }
            }
        }
    }
}
