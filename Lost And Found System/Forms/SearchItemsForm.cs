using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lost_And_Found_System.Forms
{
    public partial class SearchItemsForm : Form
    {
        public SearchItemsForm()
        {
            InitializeComponent();
            this.Paint += Form_Paint;

            cmbCategory.Items.Add("All");
            cmbCategory.Items.AddRange(new string[]
            { "Electronics", "Clothing", "Documents", "Accessories", "Books", "Other" });
            cmbCategory.SelectedIndex = 0;

            dgvResults.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 58, 92);
            dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvResults.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvResults.EnableHeadersVisualStyles = false;

            LoadItems("", "All", "");
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
                        Color.FromArgb(0, 123, 255),
                        Color.FromArgb(26, 58, 92),
                        System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
                brush.Dispose();
            }
        }

        private void LoadItems(string keyword, string category, string location)
        {
            string query = @"SELECT found_id AS ID, item_name AS 'Item Name',
                            category AS Category, date_found AS 'Date Found',
                            location AS Location, status AS Status
                            FROM found_items WHERE 1=1";

            if (!string.IsNullOrEmpty(keyword))
                query += " AND (item_name LIKE @kw OR description LIKE @kw)";
            if (category != "All")
                query += " AND category = @cat";
            if (!string.IsNullOrEmpty(location))
                query += " AND location LIKE @loc";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                    if (category != "All")
                        cmd.Parameters.AddWithValue("@cat", category);
                    if (!string.IsNullOrEmpty(location))
                        cmd.Parameters.AddWithValue("@loc", "%" + location + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvResults.DataSource = table;

                    if (dgvResults.Columns["ID"] != null)
                        dgvResults.Columns["ID"].Visible = false;

                    lblResults.Text = "Found Items: " + table.Rows.Count + " result(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadItems(txtKeyword.Text.Trim(), cmbCategory.Text, txtLocation.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            cmbCategory.SelectedIndex = 0;
            txtLocation.Clear();
            LoadItems("", "All", "");
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to claim.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foundItemId = Convert.ToInt32(dgvResults.SelectedRows[0].Cells["ID"].Value);
            string itemName = dgvResults.SelectedRows[0].Cells["Item Name"].Value.ToString();
            string status = dgvResults.SelectedRows[0].Cells["Status"].Value.ToString();

            if (status == "Claimed")
            {
                MessageBox.Show("This item has already been claimed.", "Already Claimed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Claim: " + itemName + "?\n\nAdmin will verify your request.",
                "Confirm Claim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        string query = @"INSERT INTO claim_requests
                            (found_item_id, claimant_user_id, requested_at, status)
                            VALUES (@fid, @uid, NOW(), 'Pending')";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@fid", foundItemId);
                        cmd.Parameters.AddWithValue("@uid", Lost_And_Found_System.LoginForm.CurrentUser.UserId);
                        cmd.ExecuteNonQuery();

                        lblMessage.ForeColor = Color.Green;
                        lblMessage.Text = "✅ Claim submitted for: " + itemName;
                        LoadItems("", "All", "");
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}