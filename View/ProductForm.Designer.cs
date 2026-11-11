namespace View
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblId = new Label();
            txtId = new TextBox();
            lblCode = new Label();
            txtCode = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 23);
            lblId.Name = "lblId";
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(220, 23);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(20, 58);
            lblCode.Name = "lblCode";
            lblCode.TabIndex = 2;
            lblCode.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(120, 55);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 23);
            txtCode.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 93);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(120, 90);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 23);
            txtTitle.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(20, 128);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.TabIndex = 6;
            lblUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(120, 125);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(220, 23);
            txtUnitPrice.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 163);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(120, 160);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(220, 23);
            txtQuantity.TabIndex = 9;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(20, 205);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 32);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(130, 205);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 32);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(240, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 205);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(20, 255);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(640, 245);
            dgvProducts.TabIndex = 14;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // ProductForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 520);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblCode);
            Controls.Add(txtCode);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblUnitPrice);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvProducts);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Label lblCode;
        private TextBox txtCode;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
    }
}
