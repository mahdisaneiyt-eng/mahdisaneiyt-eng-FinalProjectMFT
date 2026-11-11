using ApplicationService.Dtos;
using ApplicationService.Services;

namespace View
{
    public partial class PersonForm : Form
    {
        private readonly PersonApplicationService _personApplicationService;

        #region [- ctor -]
        public PersonForm()
        {
            InitializeComponent();
            _personApplicationService = new PersonApplicationService();
        }
        #endregion

        #region [- PersonForm_Load() -]
        private void PersonForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region [- LoadData() -]
        private void LoadData()
        {
            try
            {
                dgvPersons.DataSource = _personApplicationService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region [- ClearForm() -]
        private void ClearForm()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dgvPersons.ClearSelection();
            txtFirstName.Focus();
        }
        #endregion

        #region [- IsInputValid() -]
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion

        #region [- dgvPersons_CellClick() -]
        private void dgvPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var person = (GetPersonDto)dgvPersons.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = person.Id.ToString();
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
        }
        #endregion

        #region [- btnInsert_Click() -]
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid())
                {
                    return;
                }
                var dto = new PostPersonDto()
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                };
                _personApplicationService.Post(dto);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region [- btnUpdate_Click() -]
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Please select a row from the list first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!IsInputValid())
                {
                    return;
                }
                var dto = new PutPersonDto()
                {
                    Id = int.Parse(txtId.Text),
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                };
                _personApplicationService.Put(dto);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region [- btnDelete_Click() -]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Please select a row from the list first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Are you sure you want to delete this person?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _personApplicationService.Delete(int.Parse(txtId.Text));
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region [- btnClear_Click() -]
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        #endregion
    }
}
