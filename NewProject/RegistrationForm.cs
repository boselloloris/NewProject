namespace NewProject
{
    public partial class RegistrationForm : Form
    {
        CustomerDataGridView _customerDataGridView;

        public RegistrationForm(CustomerDataGridView customerDataGridView)
        {
            InitializeComponent();
            _customerDataGridView = customerDataGridView;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _customerDataGridView.FirstName = TbxFirstname1.Text;
            _customerDataGridView.LastName = TbxLastname1.Text;
            _customerDataGridView.Address = TbxFulladdress1.Text;
            _customerDataGridView.PhoneNumber = TbxPhone1.Text;
            _customerDataGridView.Nationality = TbxNationality1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
