namespace NewProject
{
    public partial class MainForm : Form
    {
        private readonly List<CustomerDataGridView> customerList;

        public MainForm()
        {
            InitializeComponent();
            customerList = new List<CustomerDataGridView>();
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
            var customerDataGridView = new CustomerDataGridView();
            using var registrationForm = new RegistrationForm(customerDataGridView);

            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                customerList.Add(customerDataGridView);

                DgvCustomer.DataSource = customerList.ToList();
                DgvCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }            
        }
    }
}
