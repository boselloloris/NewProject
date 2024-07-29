namespace NewProject
{
    public partial class RegistrationForm : Form
    {
        private CustomerDataGridView _customerDataGridView;

        public RegistrationForm(CustomerDataGridView customerDataGridView)
        {
            InitializeComponent();
            _customerDataGridView = customerDataGridView;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                _customerDataGridView.FirstName = TbxFirstname1.Text;
                _customerDataGridView.LastName = TbxLastname1.Text;
                _customerDataGridView.Address = TbxFulladdress1.Text;
                _customerDataGridView.Nationality = TbxNationality1.Text;
                _customerDataGridView.PhoneNumber = TbxPhone1.Text;                

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(TbxFirstname1.Text))
            {
                TbxFirstname1.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TbxLastname1.Text))
            {
                TbxLastname1.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TbxFulladdress1.Text))
            {
                TbxFulladdress1.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TbxNationality1.Text))
            {
                TbxNationality1.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TbxPhone1.Text))
            {
                TbxPhone1.Focus();
                return false;
            }

            return true;
        }
    }
}
