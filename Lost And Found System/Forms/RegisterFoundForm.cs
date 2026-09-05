using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lost_And_Found_System.Forms
{
    public partial class RegisterFoundForm : Form
    {
        private string imagePath = "";

        public RegisterFoundForm()
        {
            InitializeComponent();
            this.Paint += Form_Paint;
            cmbCategory.Items.AddRange(new string[]
            { "Electronics", "Clothing", "Documents", "Accessories", "Books", "Other" });
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            string bgPath = "Resources\\bg.jpg";
            if (System.IO.File.Exists(bgPath))
            {
                Image bg = Image.FromFile(bgPath);
                e.Graphics.DrawImage(bg, 0, 0, this.Width, this.Height);
                bg.Dispose();
            }
            else
            {
                System.Drawing.Drawing2D.LinearGradientBrush brush =
                    new System.Drawing.Drawing2D.LinearGradientBrush(
                        this.ClientRectangle,
                        Color.FromArgb(40, 167, 69),
                        Color.FromArgb(0, 200, 100),
                        System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
                brush.Dispose();
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            dlg.Title = "Select Item Image";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagePath = dlg.FileName;
                txtImagePath.Text = imagePath;
                picPreview.Image = Image.FromFile(imagePath);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Trim();
            string category = cmbCategory.Text;
            string description = txtDescription.Text.Trim();
            string dateFound = dtpDateFound.Value.ToString("yyyy-MM-dd");
            string location = txtLocation.Text.Trim();

            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(location))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Item Name, Category and Location are required!";
                return;
            }

            string savedImagePath = "";
            if (!string.IsNullOrEmpty(imagePath))
            {
                string folder = "FoundItemImages";
                Directory.CreateDirectory(folder);
                string ext = Path.GetExtension(imagePath);
                string newFileName = Guid.NewGuid().ToString() + ext;
                savedImagePath = Path.Combine(folder, newFileName);
                File.Copy(imagePath, savedImagePath, true);
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO found_items 
                        (staff_id, item_name, category, description, date_found, location, image_path, status, registered_at)
                        VALUES (@sid, @name, @cat, @desc, @dfound, @loc, @img, 'Pending', NOW())";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sid", Lost_And_Found_System.LoginForm.CurrentUser.UserId);
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@cat", category);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@dfound", dateFound);
                    cmd.Parameters.AddWithValue("@loc", location);
                    cmd.Parameters.AddWithValue("@img", savedImagePath);
                    cmd.ExecuteNonQuery();

                    lblMessage.ForeColor = Color.Green;
                    lblMessage.Text = "✅ Found item registered successfully!";
                    btnClear_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            dtpDateFound.Value = DateTime.Now;
            txtLocation.Clear();
            txtImagePath.Clear();
            picPreview.Image = null;
            imagePath = "";
        }
    }
}