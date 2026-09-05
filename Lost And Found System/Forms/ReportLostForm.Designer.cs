namespace Lost_And_Found_System.Forms
{
    partial class ReportLostForm
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
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDateLost = new Label();
            dtpDateLost = new DateTimePicker();
            lblLocation = new Label();
            txtLocation = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            lblMessage = new Label();
            pnlCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(pnlHeader);
            pnlCard.Controls.Add(lblItemName);
            pnlCard.Controls.Add(txtItemName);
            pnlCard.Controls.Add(lblCategory);
            pnlCard.Controls.Add(cmbCategory);
            pnlCard.Controls.Add(lblDescription);
            pnlCard.Controls.Add(txtDescription);
            pnlCard.Controls.Add(lblDateLost);
            pnlCard.Controls.Add(dtpDateLost);
            pnlCard.Controls.Add(lblLocation);
            pnlCard.Controls.Add(txtLocation);
            pnlCard.Controls.Add(btnSubmit);
            pnlCard.Controls.Add(btnClear);
            pnlCard.Controls.Add(lblMessage);
            pnlCard.Location = new Point(-1, 0);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(500, 560);
            pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkRed;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(500, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📋 Report Lost Item";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemName.ForeColor = Color.DarkRed;
            lblItemName.Location = new Point(30, 78);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(80, 15);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "ITEM NAME *";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(245, 247, 250);
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Font = new Font("Segoe UI", 10F);
            txtItemName.Location = new Point(30, 98);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(440, 25);
            txtItemName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.DarkRed;
            lblCategory.Location = new Point(30, 138);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "CATEGORY *";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(245, 247, 250);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.Location = new Point(30, 158);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(440, 25);
            cmbCategory.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.DarkRed;
            lblDescription.Location = new Point(30, 198);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(84, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "DESCRIPTION";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(245, 247, 250);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(30, 218);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(440, 70);
            txtDescription.TabIndex = 6;
            // 
            // lblDateLost
            // 
            lblDateLost.AutoSize = true;
            lblDateLost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateLost.ForeColor = Color.DarkRed;
            lblDateLost.Location = new Point(30, 305);
            lblDateLost.Name = "lblDateLost";
            lblDateLost.Size = new Size(76, 15);
            lblDateLost.TabIndex = 7;
            lblDateLost.Text = "DATE LOST *";
            // 
            // dtpDateLost
            // 
            dtpDateLost.CalendarForeColor = Color.DarkRed;
            dtpDateLost.CalendarMonthBackground = Color.DarkRed;
            dtpDateLost.CalendarTitleBackColor = Color.DarkRed;
            dtpDateLost.CalendarTrailingForeColor = Color.DarkRed;
            dtpDateLost.Font = new Font("Segoe UI", 10F);
            dtpDateLost.Format = DateTimePickerFormat.Short;
            dtpDateLost.Location = new Point(30, 325);
            dtpDateLost.Name = "dtpDateLost";
            dtpDateLost.Size = new Size(200, 25);
            dtpDateLost.TabIndex = 8;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(30, 365);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(146, 15);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "LAST KNOWN LOCATION";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(245, 247, 250);
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(30, 385);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(440, 25);
            txtLocation.TabIndex = 10;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkRed;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(30, 430);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(200, 42);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit Report";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(250, 430);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(220, 42);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(30, 485);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(440, 20);
            lblMessage.TabIndex = 13;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportLostForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(496, 550);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReportLostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Lost Item";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDateLost;
        private System.Windows.Forms.DateTimePicker dtpDateLost;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMessage;
    }
}