namespace Lost_And_Found_System.Forms
{
    partial class AdminDashboard
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            btnLogout = new Button();
            pnlStats = new Panel();
            pnlTotal = new Panel();
            lblTotalCount = new Label();
            lblTotalTitle = new Label();
            pnlPending = new Panel();
            lblPendingCount = new Label();
            lblPendingTitle = new Label();
            pnlClaimed = new Panel();
            lblClaimedCount = new Label();
            lblClaimedTitle = new Label();
            pnlRequests = new Panel();
            lblClaimsTitle = new Label();
            lblClaimsTitle2 = new Label();
            dgvClaims = new DataGridView();
            btnApprove = new Button();
            btnReject = new Button();
            btnRefresh = new Button();
            lblMessage = new Label();
            tabControl = new TabControl();
            tabClaims = new TabPage();
            tabLostItems = new TabPage();
            dgvLostItems = new DataGridView();
            tabFoundItems = new TabPage();
            dgvFoundItems = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlClaimed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClaims).BeginInit();
            tabControl.SuspendLayout();
            tabClaims.SuspendLayout();
            tabLostItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLostItems).BeginInit();
            tabFoundItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkRed;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(943, 80);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lost And Found Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(22, 42);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(120, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Admin Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.DarkRed;
            btnLogout.Location = new Point(832, 27);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 32);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.White;
            pnlStats.Controls.Add(pnlTotal);
            pnlStats.Controls.Add(pnlPending);
            pnlStats.Controls.Add(pnlClaimed);
            pnlStats.Location = new Point(0, 80);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(15);
            pnlStats.Size = new Size(950, 110);
            pnlStats.TabIndex = 1;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.DarkRed;
            pnlTotal.Controls.Add(lblTotalCount);
            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Location = new Point(20, 15);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(270, 80);
            pnlTotal.TabIndex = 0;
            pnlTotal.Paint += pnlTotal_Paint;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotalCount.ForeColor = Color.White;
            lblTotalCount.Location = new Point(15, 6);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(44, 51);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "0";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.BackColor = Color.Transparent;
            lblTotalTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitle.ForeColor = Color.White;
            lblTotalTitle.Location = new Point(15, 55);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(120, 17);
            lblTotalTitle.TabIndex = 1;
            lblTotalTitle.Text = "Total Found Items";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.DarkRed;
            pnlPending.Controls.Add(lblPendingCount);
            pnlPending.Controls.Add(lblPendingTitle);
            pnlPending.Location = new Point(320, 15);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(270, 80);
            pnlPending.TabIndex = 1;
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(15, 7);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(44, 51);
            lblPendingCount.TabIndex = 0;
            lblPendingCount.Text = "0";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.BackColor = Color.Transparent;
            lblPendingTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingTitle.ForeColor = Color.White;
            lblPendingTitle.Location = new Point(15, 55);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(104, 17);
            lblPendingTitle.TabIndex = 1;
            lblPendingTitle.Text = "Pending Claims";
            // 
            // pnlClaimed
            // 
            pnlClaimed.BackColor = Color.DarkRed;
            pnlClaimed.Controls.Add(lblClaimedCount);
            pnlClaimed.Controls.Add(lblClaimedTitle);
            pnlClaimed.Location = new Point(620, 15);
            pnlClaimed.Name = "pnlClaimed";
            pnlClaimed.Size = new Size(270, 80);
            pnlClaimed.TabIndex = 2;
            // 
            // lblClaimedCount
            // 
            lblClaimedCount.AutoSize = true;
            lblClaimedCount.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblClaimedCount.ForeColor = Color.White;
            lblClaimedCount.Location = new Point(15, 7);
            lblClaimedCount.Name = "lblClaimedCount";
            lblClaimedCount.Size = new Size(44, 51);
            lblClaimedCount.TabIndex = 0;
            lblClaimedCount.Text = "0";
            // 
            // lblClaimedTitle
            // 
            lblClaimedTitle.AutoSize = true;
            lblClaimedTitle.BackColor = Color.Transparent;
            lblClaimedTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClaimedTitle.ForeColor = Color.White;
            lblClaimedTitle.Location = new Point(15, 55);
            lblClaimedTitle.Name = "lblClaimedTitle";
            lblClaimedTitle.Size = new Size(113, 17);
            lblClaimedTitle.TabIndex = 1;
            lblClaimedTitle.Text = "Approved Claims";
            // 
            // pnlRequests
            // 
            pnlRequests.Location = new Point(0, 0);
            pnlRequests.Name = "pnlRequests";
            pnlRequests.Size = new Size(200, 100);
            pnlRequests.TabIndex = 0;
            // 
            // lblClaimsTitle
            // 
            lblClaimsTitle.Location = new Point(0, 0);
            lblClaimsTitle.Name = "lblClaimsTitle";
            lblClaimsTitle.Size = new Size(100, 23);
            lblClaimsTitle.TabIndex = 0;
            // 
            // lblClaimsTitle2
            // 
            lblClaimsTitle2.Location = new Point(0, 0);
            lblClaimsTitle2.Name = "lblClaimsTitle2";
            lblClaimsTitle2.Size = new Size(100, 23);
            lblClaimsTitle2.TabIndex = 0;
            // 
            // dgvClaims
            // 
            dgvClaims.AllowUserToAddRows = false;
            dgvClaims.AllowUserToDeleteRows = false;
            dgvClaims.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClaims.BackgroundColor = Color.White;
            dgvClaims.BorderStyle = BorderStyle.None;
            dgvClaims.ColumnHeadersHeight = 35;
            dgvClaims.Font = new Font("Segoe UI", 9F);
            dgvClaims.Location = new Point(10, 10);
            dgvClaims.MultiSelect = false;
            dgvClaims.Name = "dgvClaims";
            dgvClaims.ReadOnly = true;
            dgvClaims.RowHeadersVisible = false;
            dgvClaims.RowTemplate.Height = 30;
            dgvClaims.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClaims.Size = new Size(920, 310);
            dgvClaims.TabIndex = 0;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.DarkRed;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(10, 330);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(160, 38);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "✔ Approve Claim";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.DarkRed;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(185, 330);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(160, 38);
            btnReject.TabIndex = 2;
            btnReject.Text = "✖ Reject Claim";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkRed;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(360, 330);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "↻ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(500, 340);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 4;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabClaims);
            tabControl.Controls.Add(tabLostItems);
            tabControl.Controls.Add(tabFoundItems);
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(0, 190);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(950, 430);
            tabControl.TabIndex = 2;
            // 
            // tabClaims
            // 
            tabClaims.BackColor = Color.White;
            tabClaims.Controls.Add(dgvClaims);
            tabClaims.Controls.Add(btnApprove);
            tabClaims.Controls.Add(btnReject);
            tabClaims.Controls.Add(btnRefresh);
            tabClaims.Controls.Add(lblMessage);
            tabClaims.Location = new Point(4, 26);
            tabClaims.Name = "tabClaims";
            tabClaims.Size = new Size(942, 400);
            tabClaims.TabIndex = 0;
            tabClaims.Text = "  Claim Requests  ";
            // 
            // tabLostItems
            // 
            tabLostItems.BackColor = Color.White;
            tabLostItems.Controls.Add(dgvLostItems);
            tabLostItems.Location = new Point(4, 26);
            tabLostItems.Name = "tabLostItems";
            tabLostItems.Size = new Size(942, 400);
            tabLostItems.TabIndex = 1;
            tabLostItems.Text = "  Lost Items  ";
            // 
            // dgvLostItems
            // 
            dgvLostItems.AllowUserToAddRows = false;
            dgvLostItems.AllowUserToDeleteRows = false;
            dgvLostItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLostItems.BackgroundColor = Color.White;
            dgvLostItems.BorderStyle = BorderStyle.None;
            dgvLostItems.ColumnHeadersHeight = 35;
            dgvLostItems.Font = new Font("Segoe UI", 9F);
            dgvLostItems.Location = new Point(14, 13);
            dgvLostItems.Name = "dgvLostItems";
            dgvLostItems.ReadOnly = true;
            dgvLostItems.RowHeadersVisible = false;
            dgvLostItems.RowTemplate.Height = 30;
            dgvLostItems.Size = new Size(920, 380);
            dgvLostItems.TabIndex = 0;
            // 
            // tabFoundItems
            // 
            tabFoundItems.BackColor = Color.White;
            tabFoundItems.Controls.Add(dgvFoundItems);
            tabFoundItems.Location = new Point(4, 26);
            tabFoundItems.Name = "tabFoundItems";
            tabFoundItems.Size = new Size(942, 400);
            tabFoundItems.TabIndex = 2;
            tabFoundItems.Text = "  Found Items  ";
            // 
            // dgvFoundItems
            // 
            dgvFoundItems.AllowUserToAddRows = false;
            dgvFoundItems.AllowUserToDeleteRows = false;
            dgvFoundItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoundItems.BackgroundColor = Color.White;
            dgvFoundItems.BorderStyle = BorderStyle.None;
            dgvFoundItems.ColumnHeadersHeight = 35;
            dgvFoundItems.Font = new Font("Segoe UI", 9F);
            dgvFoundItems.Location = new Point(14, 3);
            dgvFoundItems.Name = "dgvFoundItems";
            dgvFoundItems.ReadOnly = true;
            dgvFoundItems.RowHeadersVisible = false;
            dgvFoundItems.RowTemplate.Height = 30;
            dgvFoundItems.Size = new Size(920, 380);
            dgvFoundItems.TabIndex = 0;
            dgvFoundItems.CellContentClick += dgvFoundItems_CellContentClick;
            // 
            // AdminDashboard
            // 
            BackColor = Color.White;
            ClientSize = new Size(943, 642);
            Controls.Add(pnlHeader);
            Controls.Add(pnlStats);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lost & Found - Admin Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlClaimed.ResumeLayout(false);
            pnlClaimed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClaims).EndInit();
            tabControl.ResumeLayout(false);
            tabClaims.ResumeLayout(false);
            tabClaims.PerformLayout();
            tabLostItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLostItems).EndInit();
            tabFoundItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFoundItems).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel pnlPending;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Panel pnlClaimed;
        private System.Windows.Forms.Label lblClaimedCount;
        private System.Windows.Forms.Label lblClaimedTitle;
        private System.Windows.Forms.Panel pnlRequests;
        private System.Windows.Forms.Label lblClaimsTitle;
        private System.Windows.Forms.Label lblClaimsTitle2;
        private System.Windows.Forms.DataGridView dgvClaims;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClaims;
        private System.Windows.Forms.TabPage tabLostItems;
        private System.Windows.Forms.TabPage tabFoundItems;
        private System.Windows.Forms.DataGridView dgvLostItems;
        private System.Windows.Forms.DataGridView dgvFoundItems;
        private Label lblSubtitle;
    }
}