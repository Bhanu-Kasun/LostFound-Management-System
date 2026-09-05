using Lost_And_Found_System.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lost_And_Found_System.Forms
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
            this.Paint += UserDashboard_Paint;
            lblWelcome.Text = "Welcome, " + Lost_And_Found_System.LoginForm.CurrentUser.FullName + "!";

            if (Lost_And_Found_System.LoginForm.CurrentUser.Role != "staff")
                btnRegisterFound.Visible = false;
        }

        private void UserDashboard_Paint(object sender, PaintEventArgs e)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Lost_And_Found_System.LoginForm().Show();
        }

        private void btnReportLost_Click(object sender, EventArgs e)
        {
            new ReportLostForm().Show();
        }

        private void btnRegisterFound_Click(object sender, EventArgs e)
        {
            new RegisterFoundForm().Show();
        }

        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            new SearchItemsForm().Show();
        }
    }
}