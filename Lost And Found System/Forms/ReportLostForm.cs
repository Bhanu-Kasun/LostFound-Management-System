using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lost_And_Found_System.Forms
{
    public partial class ReportLostForm : Form
    {
        public ReportLostForm()
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
                        Color.FromArgb(26, 58, 92),
                        Color.FromArgb(0, 123, 255),
                        System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
                brush.Dispose();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Trim();
            string category = cmbCategory.Text;
            string description = txtDescription.Text.Trim();
            string dateLost = dtpDateLost.Value.ToString("yyyy-MM-dd");
            string location = txtLocation.Text.Trim();

            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(category))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "⚠ Item Name and Category are required!";
                return;
            }

            string reportId = "LF-" + DateTime.Now.Year + "-" + DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"INSERT INTO lost_items 
                        (report_id, user_id, item_name, category, description, date_lost, location, status, reported_at)
                        VALUES (@rid, @uid, @name, @cat, @desc, @dlost, @loc, 'Pending', NOW())";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@rid", reportId);
                    cmd.Parameters.AddWithValue("@uid", Lost_And_Found_System.LoginForm.CurrentUser.UserId);
                    cmd.Parameters.AddWithValue("@name", itemName);
                    cmd.Parameters.AddWithValue("@cat", category);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@dlost", dateLost);
                    cmd.Parameters.AddWithValue("@loc", location);
                    cmd.ExecuteNonQuery();

                    lblMessage.ForeColor = System.Drawing.Color.LightGreen;
                    lblMessage.Text = "✅ Report submitted! ID: " + reportId;
                    btnClear_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            dtpDateLost.Value = DateTime.Now;
            txtLocation.Clear();
        }
    }
}