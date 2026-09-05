using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Lost_And_Found_System.Models;

namespace Lost_And_Found_System
{
    public partial class LoginForm : Form
    {
        public static User CurrentUser = new User();

        public LoginForm()
        {
            InitializeComponent();
            this.Paint += LoginForm_Paint;
            LoadLogo();
        }

        private void LoadLogo()
        {
            // Load logo
            string logoPath = "Resources\\logo.png";
            if (System.IO.File.Exists(logoPath))
            {
                picLogo.Image = Image.FromFile(logoPath);
            }
            else
            {
                // Show as placeholder
                picLogo.BackColor = Color.FromArgb(26, 58, 92);
            }
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw background image or gradient
            string bgPath = "Resources\\bg.jpg";
            if (System.IO.File.Exists(bgPath))
            {
                Image bg = Image.FromFile(bgPath);
                e.Graphics.DrawImage(bg, 0, 0, this.Width, this.Height);
                bg.Dispose();
            }
            else
            {
                // Draw gradient background if no image
                System.Drawing.Drawing2D.LinearGradientBrush brush =
                    new System.Drawing.Drawing2D.LinearGradientBrush(
                        this.ClientRectangle,
                        Color.FromArgb(26, 58, 92),
                        Color.FromArgb(0, 123, 255),
                        System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
                brush.Dispose();
            }


            // Add shadow effect to card
            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(30, 0, 0, 0)),
                pnlCard.Left + 5, pnlCard.Top + 5,
                pnlCard.Width, pnlCard.Height);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Fields cannot be empty.";
                return;
            }

            string hashedPassword = DatabaseHelper.HashPassword(password); // hash password before checking

            try
            {
                using (var conn = DatabaseHelper.GetConnection()) //open c w db

                {
                    string query = "SELECT * FROM users WHERE user_id=@uid AND password_hash=@pwd";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.Parameters.AddWithValue("@pwd", hashedPassword);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurrentUser.UserId = reader["user_id"].ToString();
                            CurrentUser.FullName = reader["full_name"].ToString();
                            CurrentUser.Role = reader["role"].ToString();

                            this.Hide();

                            if (CurrentUser.Role == "admin")
                                new Lost_And_Found_System.Forms.AdminDashboard().Show();
                            else
                                new Lost_And_Found_System.Forms.UserDashboard().Show();
                        }
                        else
                        {
                            lblError.Text = "Invalid credentials. Please try again.";
                            txtPassword.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "DB Error: " + ex.Message;
            }
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }
    }
}