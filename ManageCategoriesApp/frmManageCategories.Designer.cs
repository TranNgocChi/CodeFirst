namespace ManageCategoriesApp
{
    partial class frmManageCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCategory = new Label();
            label2 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            dgvCategories = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategory.Location = new Point(91, 35);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(88, 21);
            lbCategory.TabIndex = 0;
            lbCategory.Text = "CategoryID";
            lbCategory.Click += LbCategoryID;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 79);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 1;
            label2.Text = "CategoryName";
            label2.Click += label2_Click;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryID.Location = new Point(212, 37);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(256, 25);
            txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(212, 77);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(256, 25);
            txtCategoryName.TabIndex = 3;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(91, 118);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(377, 174);
            dgvCategories.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(91, 315);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(88, 37);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(236, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(388, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 37);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 364);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvCategories);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label2);
            Controls.Add(lbCategory);
            Name = "frmManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategory;
        private Label label2;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private DataGridView dgvCategories;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}