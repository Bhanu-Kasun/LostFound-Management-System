using LostAndFoundSystem;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lost_And_Found_System.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            StyleGridHeaders();
            LoadStats();
            LoadClaimRequests();
            LoadLostItems();
            LoadFoundItems();

        }

        private void StyleGridHeaders()
        {
            foreach (DataGridView dgv in new[] { dgvClaims, dgvLostItems, dgvFoundItems })
            {
                dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 58, 92);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                dgv.EnableHeadersVisualStyles = false;
            }
        }

        private void LoadStats()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    var cmd1 = new MySqlCommand("SELECT COUNT(*) FROM found_items", conn);
                    lblTotalCount.Text = cmd1.ExecuteScalar().ToString();

                    var cmd2 = new MySqlCommand("SELECT COUNT(*) FROM claim_requests WHERE status='Pending'", conn);
                    lblPendingCount.Text = cmd2.ExecuteScalar().ToString();

                    var cmd3 = new MySqlCommand("SELECT COUNT(*) FROM claim_requests WHERE status='Approved'", conn);
                    lblClaimedCount.Text = cmd3.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stats Error: " + ex.Message);
            }
        }

        private void LoadClaimRequests()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                        cr.claim_id AS 'Claim ID',
                        u.full_name AS 'Claimant',
                        u.user_id AS 'User ID',
                        fi.item_name AS 'Item',
                        fi.category AS 'Category',
                        fi.location AS 'Location',
                        cr.requested_at AS 'Requested At',
                        cr.status AS 'Status'
                        FROM claim_requests cr
                        JOIN users u ON cr.claimant_user_id = u.user_id
                        JOIN found_items fi ON cr.found_item_id = fi.found_id
                        ORDER BY cr.requested_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvClaims.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Claims Error: " + ex.Message);
            }
        }

        private void LoadLostItems()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                        report_id AS 'Report ID',
                        user_id AS 'User ID',
                        item_name AS 'Item Name',
                        category AS 'Category',
                        date_lost AS 'Date Lost',
                        location AS 'Location',
                        status AS 'Status',
                        reported_at AS 'Reported At'
                        FROM lost_items
                        ORDER BY reported_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvLostItems.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lost Items Error: " + ex.Message);
            }
        }

        private void LoadFoundItems()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT 
                        found_id AS 'ID',
                        staff_id AS 'Staff ID',
                        item_name AS 'Item Name',
                        category AS 'Category',
                        date_found AS 'Date Found',
                        location AS 'Location',
                        status AS 'Status',
                        registered_at AS 'Registered At'
                        FROM found_items
                        ORDER BY registered_at DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvFoundItems.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Found Items Error: " + ex.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvClaims.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a claim to approve.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int claimId = Convert.ToInt32(dgvClaims.SelectedRows[0].Cells["Claim ID"].Value);
            string claimant = dgvClaims.SelectedRows[0].Cells["Claimant"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Approve claim for: " + claimant + "?",
                "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                UpdateClaimStatus(claimId, "Approved");
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Claim approved for " + claimant;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvClaims.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a claim to reject.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int claimId = Convert.ToInt32(dgvClaims.SelectedRows[0].Cells["Claim ID"].Value);
            string claimant = dgvClaims.SelectedRows[0].Cells["Claimant"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                "Reject claim for: " + claimant + "?",
                "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                UpdateClaimStatus(claimId, "Rejected");
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "✖ Claim rejected for " + claimant;
            }
        }

        private void UpdateClaimStatus(int claimId, string status)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = "UPDATE claim_requests SET status=@status WHERE claim_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", claimId);
                    cmd.ExecuteNonQuery();

                    LoadStats();
                    LoadClaimRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
            LoadClaimRequests();
            LoadLostItems();
            LoadFoundItems();
            lblMessage.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void pnlTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvFoundItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}