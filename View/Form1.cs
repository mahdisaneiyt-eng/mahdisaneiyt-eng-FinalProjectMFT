namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region [- btnPerson_Click() -]
        private void btnPerson_Click(object sender, EventArgs e)
        {
            var personForm = new PersonForm();
            personForm.ShowDialog();
        }
        #endregion

        #region [- btnProduct_Click() -]
        private void btnProduct_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.ShowDialog();
        }
        #endregion
    }
}
