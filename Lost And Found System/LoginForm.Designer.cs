namespace Lost_And_Found_System
{
    partial class LoginForm
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
            picLogo = new PictureBox();
            lblSystemName = new Label();
            lblUniversity = new Label();
            lblDivider = new Label();
            lblUniversityID = new Label();
            txtUserId = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            lblFooter = new Label();
            pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(picLogo);
            pnlCard.Controls.Add(lblSystemName);
            pnlCard.Controls.Add(lblUniversity);
            pnlCard.Controls.Add(lblDivider);
            pnlCard.Controls.Add(lblUniversityID);
            pnlCard.Controls.Add(txtUserId);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblError);
            pnlCard.Controls.Add(lblFooter);
            pnlCard.Location = new Point(1, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(425, 509);
            pnlCard.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(160, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // lblSystemName
            // 
            lblSystemName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.DarkRed;
            lblSystemName.Location = new Point(20, 125);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(380, 30);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "Lost And Found System";
            lblSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUniversity
            // 
            lblUniversity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUniversity.ForeColor = Color.DarkRed;
            lblUniversity.Location = new Point(20, 158);
            lblUniversity.Name = "lblUniversity";
            lblUniversity.Size = new Size(380, 20);
            lblUniversity.TabIndex = 2;
            lblUniversity.Text = "University of Moratuwa";
            lblUniversity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.DarkRed;
            lblDivider.Location = new Point(60, 188);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(300, 2);
            lblDivider.TabIndex = 3;
            // 
            // lblUniversityID
            // 
            lblUniversityID.AutoSize = true;
            lblUniversityID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUniversityID.ForeColor = Color.DarkRed;
            lblUniversityID.Location = new Point(40, 210);
            lblUniversityID.Name = "lblUniversityID";
            lblUniversityID.Size = new Size(92, 15);
            lblUniversityID.TabIndex = 4;
            lblUniversityID.Text = "UNIVERSITY ID";
            // 
            // txtUserId
            // 
            txtUserId.BackColor = Color.FromArgb(245, 247, 250);
            txtUserId.BorderStyle = BorderStyle.FixedSingle;
            txtUserId.Font = new Font("Segoe UI", 11F);
            txtUserId.Location = new Point(40, 232);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(340, 27);
            txtUserId.TabIndex = 5;
            txtUserId.TextChanged += txtUserId_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.DarkRed;
            lblPassword.Location = new Point(40, 278);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(245, 247, 250);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(40, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 358);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN →";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(220, 53, 69);
            lblError.Location = new Point(40, 415);
            lblError.Name = "lblError";
            lblError.Size = new Size(340, 20);
            lblError.TabIndex = 9;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.DarkRed;
            lblFooter.Location = new Point(40, 480);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(340, 20);
            lblFooter.TabIndex = 10;
            lblFooter.Text = "© 2026 Faculty of Information Technology";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(422, 502);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lost & Found - Login";
            Load += LoginForm_Load;
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblUniversityID;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFooter;
    }
}