namespace Lost_And_Found_System.Forms
{
    partial class UserDashboard
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
            lblWelcome = new Label();
            btnLogout = new Button();
            pnlButtons = new Panel();
            lblMenuTitle = new Label();
            btnReportLost = new Button();
            btnRegisterFound = new Button();
            btnSearchItems = new Button();
            pnlHeader.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(771, 95);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DarkRed;
            lblWelcome.Location = new Point(20, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(111, 24);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkRed;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(650, 24);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 32);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.BorderStyle = BorderStyle.FixedSingle;
            pnlButtons.Controls.Add(lblMenuTitle);
            pnlButtons.Controls.Add(btnReportLost);
            pnlButtons.Controls.Add(btnRegisterFound);
            pnlButtons.Controls.Add(btnSearchItems);
            pnlButtons.Location = new Point(-17, 84);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(795, 467);
            pnlButtons.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.AutoSize = true;
            lblMenuTitle.BackColor = Color.Transparent;
            lblMenuTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.White;
            lblMenuTitle.Location = new Point(0, 0);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(245, 25);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "What would you like to do?";
            // 
            // btnReportLost
            // 
            btnReportLost.BackColor = Color.DarkRed;
            btnReportLost.Cursor = Cursors.Hand;
            btnReportLost.FlatAppearance.BorderSize = 0;
            btnReportLost.FlatStyle = FlatStyle.Flat;
            btnReportLost.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReportLost.ForeColor = Color.White;
            btnReportLost.Location = new Point(120, 70);
            btnReportLost.Name = "btnReportLost";
            btnReportLost.Size = new Size(267, 120);
            btnReportLost.TabIndex = 1;
            btnReportLost.Text = "📋  Report Lost Item\n\nI lost something on campus";
            btnReportLost.UseVisualStyleBackColor = false;
            btnReportLost.Click += btnReportLost_Click;
            // 
            // btnRegisterFound
            // 
            btnRegisterFound.BackColor = Color.DarkRed;
            btnRegisterFound.Cursor = Cursors.Hand;
            btnRegisterFound.FlatAppearance.BorderSize = 0;
            btnRegisterFound.FlatStyle = FlatStyle.Flat;
            btnRegisterFound.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegisterFound.ForeColor = Color.White;
            btnRegisterFound.Location = new Point(419, 70);
            btnRegisterFound.Name = "btnRegisterFound";
            btnRegisterFound.Size = new Size(256, 120);
            btnRegisterFound.TabIndex = 2;
            btnRegisterFound.Text = "📦  Register Found Item\n\nI found something on campus";
            btnRegisterFound.UseVisualStyleBackColor = false;
            btnRegisterFound.Click += btnRegisterFound_Click;
            // 
            // btnSearchItems
            // 
            btnSearchItems.BackColor = Color.DarkRed;
            btnSearchItems.Cursor = Cursors.Hand;
            btnSearchItems.FlatAppearance.BorderSize = 0;
            btnSearchItems.FlatStyle = FlatStyle.Flat;
            btnSearchItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearchItems.ForeColor = Color.White;
            btnSearchItems.Location = new Point(120, 235);
            btnSearchItems.Name = "btnSearchItems";
            btnSearchItems.Size = new Size(555, 100);
            btnSearchItems.TabIndex = 3;
            btnSearchItems.Text = "🔍  Search & Claim Items\n\nBrowse found items and submit a claim";
            btnSearchItems.UseVisualStyleBackColor = false;
            btnSearchItems.Click += btnSearchItems_Click;
            // 
            // UserDashboard
            // 
            BackColor = Color.White;
            ClientSize = new Size(771, 500);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lost & Found - User Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnReportLost;
        private System.Windows.Forms.Button btnRegisterFound;
        private System.Windows.Forms.Button btnSearchItems;
    }
}