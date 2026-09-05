namespace Lost_And_Found_System.Forms
{
    partial class SearchItemsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSearch = new Panel();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            lblResults = new Label();
            dgvResults = new DataGridView();
            btnClaim = new Button();
            lblMessage = new Label();
            pnlCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(pnlHeader);
            pnlCard.Controls.Add(pnlSearch);
            pnlCard.Controls.Add(lblResults);
            pnlCard.Controls.Add(dgvResults);
            pnlCard.Controls.Add(btnClaim);
            pnlCard.Controls.Add(lblMessage);
            pnlCard.Location = new Point(-1, -2);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(920, 658);
            pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkRed;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(920, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔍 Search & Claim Found Items";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(lblKeyword);
            pnlSearch.Controls.Add(txtKeyword);
            pnlSearch.Controls.Add(lblCategory);
            pnlSearch.Controls.Add(cmbCategory);
            pnlSearch.Controls.Add(lblLocation);
            pnlSearch.Controls.Add(txtLocation);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnClear);
            pnlSearch.Location = new Point(0, 60);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(880, 80);
            pnlSearch.TabIndex = 1;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKeyword.ForeColor = Color.DarkRed;
            lblKeyword.Location = new Point(15, 10);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(66, 15);
            lblKeyword.TabIndex = 0;
            lblKeyword.Text = "KEYWORD";
            // 
            // txtKeyword
            // 
            txtKeyword.BackColor = Color.White;
            txtKeyword.BorderStyle = BorderStyle.FixedSingle;
            txtKeyword.Font = new Font("Segoe UI", 10F);
            txtKeyword.Location = new Point(15, 28);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(190, 25);
            txtKeyword.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.DarkRed;
            lblCategory.Location = new Point(220, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "CATEGORY";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.Location = new Point(220, 28);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(160, 25);
            cmbCategory.TabIndex = 3;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(395, 10);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(65, 15);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "LOCATION";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.White;
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(395, 28);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(160, 25);
            txtLocation.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkRed;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(570, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 32);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(700, 25);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 32);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.BackColor = Color.Transparent;
            lblResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResults.ForeColor = Color.DarkRed;
            lblResults.Location = new Point(15, 152);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(94, 19);
            lblResults.TabIndex = 2;
            lblResults.Text = "Found Items:";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = Color.White;
            dgvResults.BorderStyle = BorderStyle.None;
            dgvResults.ColumnHeadersHeight = 35;
            dgvResults.Font = new Font("Segoe UI", 9F);
            dgvResults.Location = new Point(15, 172);
            dgvResults.MultiSelect = false;
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.RowTemplate.Height = 30;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(850, 320);
            dgvResults.TabIndex = 3;
            // 
            // btnClaim
            // 
            btnClaim.BackColor = Color.DarkRed;
            btnClaim.Cursor = Cursors.Hand;
            btnClaim.FlatAppearance.BorderSize = 0;
            btnClaim.FlatStyle = FlatStyle.Flat;
            btnClaim.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClaim.ForeColor = Color.White;
            btnClaim.Location = new Point(15, 505);
            btnClaim.Name = "btnClaim";
            btnClaim.Size = new Size(220, 42);
            btnClaim.TabIndex = 4;
            btnClaim.Text = "🙋 Claim This Item";
            btnClaim.UseVisualStyleBackColor = false;
            btnClaim.Click += btnClaim_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(250, 515);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(600, 20);
            lblMessage.TabIndex = 5;
            // 
            // SearchItemsForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(904, 640);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SearchItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search & Claim Items";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnClaim;
        private System.Windows.Forms.Label lblMessage;
    }
}