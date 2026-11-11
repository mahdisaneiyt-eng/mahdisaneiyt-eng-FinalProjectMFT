using ApplicationService.Dtos;
using ApplicationService.Services;

namespace View
{
    public partial class ProductForm : Form
    {
        private readonly ProductApplicationService _productApplicationService;

        #region [- ctor -]
        public ProductForm()
        {
            InitializeComponent();
            _productApplicationService = new ProductApplicationService();
        }
        #endregion

        #region [- ProductForm_Load() -]
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region [- LoadData() -]
        private void LoadData()
        {
            try
            {
                dgvProducts.DataSource = _productApplicationService.GetAll();
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
            txtCode.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            dgvProducts.ClearSelection();
            txtCode.Focus();
        }
        #endregion

        #region [- IsInputValid() -]
        private bool IsInputValid()
        {
            if (!int.TryParse(txtCode.Text, out _))
            {
                MessageBox.Show("Code must be a whole number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter Title.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(txtUnitPrice.Text, out _))
            {
                MessageBox.Show("Unit Price must be a number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity must be a whole number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion

        #region [- dgvProducts_CellClick() -]
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var product = (GetProductDto)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = product.Id.ToString();
            txtCode.Text = product.Code.ToString();
            txtTitle.Text = product.Title;
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtQuantity.Text = product.Quantity.ToString();
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
                var dto = new PostProductDto()
                {
                    Code = int.Parse(txtCode.Text),
                    Title = txtTitle.Text.Trim(),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                };
                _productApplicationService.Post(dto);
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
                var dto = new PutProductDto()
                {
                    Id = int.Parse(txtId.Text),
                    Code = int.Parse(txtCode.Text),
                    Title = txtTitle.Text.Trim(),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                };
                _productApplicationService.Put(dto);
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
                var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _productApplicationService.Delete(int.Parse(txtId.Text));
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
