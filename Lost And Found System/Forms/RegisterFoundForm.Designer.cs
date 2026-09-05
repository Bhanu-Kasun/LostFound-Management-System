namespace Lost_And_Found_System.Forms
{
    partial class RegisterFoundForm
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
            lblDateFound = new Label();
            dtpDateFound = new DateTimePicker();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblImage = new Label();
            txtImagePath = new TextBox();
            btnUploadImage = new Button();
            picPreview = new PictureBox();
            btnRegister = new Button();
            btnClear = new Button();
            lblMessage = new Label();
            pnlCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
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
            pnlCard.Controls.Add(lblDateFound);
            pnlCard.Controls.Add(dtpDateFound);
            pnlCard.Controls.Add(lblLocation);
            pnlCard.Controls.Add(txtLocation);
            pnlCard.Controls.Add(lblImage);
            pnlCard.Controls.Add(txtImagePath);
            pnlCard.Controls.Add(btnUploadImage);
            pnlCard.Controls.Add(picPreview);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(btnClear);
            pnlCard.Controls.Add(lblMessage);
            pnlCard.Location = new Point(0, -1);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(700, 590);
            pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkRed;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register Found Item";
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
            txtItemName.Size = new Size(380, 25);
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
            cmbCategory.Size = new Size(380, 25);
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
            txtDescription.Size = new Size(380, 60);
            txtDescription.TabIndex = 6;
            // 
            // lblDateFound
            // 
            lblDateFound.AutoSize = true;
            lblDateFound.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDateFound.ForeColor = Color.DarkRed;
            lblDateFound.Location = new Point(30, 295);
            lblDateFound.Name = "lblDateFound";
            lblDateFound.Size = new Size(89, 15);
            lblDateFound.TabIndex = 7;
            lblDateFound.Text = "DATE FOUND *";
            // 
            // dtpDateFound
            // 
            dtpDateFound.Font = new Font("Segoe UI", 10F);
            dtpDateFound.Format = DateTimePickerFormat.Short;
            dtpDateFound.Location = new Point(30, 315);
            dtpDateFound.Name = "dtpDateFound";
            dtpDateFound.Size = new Size(200, 25);
            dtpDateFound.TabIndex = 8;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocation.ForeColor = Color.DarkRed;
            lblLocation.Location = new Point(30, 355);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(118, 15);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "LOCATION FOUND *";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(245, 247, 250);
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 10F);
            txtLocation.Location = new Point(30, 375);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(380, 25);
            txtLocation.TabIndex = 10;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImage.ForeColor = Color.DarkRed;
            lblImage.Location = new Point(30, 415);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(154, 15);
            lblImage.TabIndex = 11;
            lblImage.Text = "UPLOAD IMAGE (Optional)";
            // 
            // txtImagePath
            // 
            txtImagePath.BackColor = Color.FromArgb(245, 247, 250);
            txtImagePath.BorderStyle = BorderStyle.FixedSingle;
            txtImagePath.Font = new Font("Segoe UI", 10F);
            txtImagePath.Location = new Point(30, 435);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.ReadOnly = true;
            txtImagePath.Size = new Size(270, 25);
            txtImagePath.TabIndex = 12;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.DarkRed;
            btnUploadImage.Cursor = Cursors.Hand;
            btnUploadImage.FlatAppearance.BorderSize = 0;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadImage.ForeColor = Color.White;
            btnUploadImage.Location = new Point(310, 435);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(100, 26);
            btnUploadImage.TabIndex = 13;
            btnUploadImage.Text = "Browse...";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // picPreview
            // 
            picPreview.BackColor = Color.FromArgb(245, 247, 250);
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(450, 78);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(220, 220);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 14;
            picPreview.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkRed;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(30, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 42);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register Item";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkRed;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(250, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 42);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 9F);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(30, 545);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(440, 20);
            lblMessage.TabIndex = 17;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterFoundForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(694, 579);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterFoundForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Found Item";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
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
        private System.Windows.Forms.Label lblDateFound;
        private System.Windows.Forms.DateTimePicker dtpDateFound;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMessage;
    }
}