namespace View
{
    partial class PersonForm
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
            lblFirstName = new Label();
            lblLastName = new Label();
            txtId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvPersons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
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
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(20, 58);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(20, 93);
            lblLastName.Name = "lblLastName";
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 23);
            txtLastName.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(20, 130);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(100, 32);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(130, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 32);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(240, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 32);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 130);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvPersons
            // 
            dgvPersons.AllowUserToAddRows = false;
            dgvPersons.AllowUserToDeleteRows = false;
            dgvPersons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPersons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(20, 180);
            dgvPersons.MultiSelect = false;
            dgvPersons.Name = "dgvPersons";
            dgvPersons.ReadOnly = true;
            dgvPersons.RowHeadersVisible = false;
            dgvPersons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersons.Size = new Size(640, 280);
            dgvPersons.TabIndex = 10;
            dgvPersons.CellClick += dgvPersons_CellClick;
            // 
            // PersonForm
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 480);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvPersons);
            Name = "PersonForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person";
            Load += PersonForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvPersons;
    }
}
