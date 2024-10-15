using System;
using System.Windows.Forms;

namespace _2024_10_15
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            Database.OpenConnection();
            if (new LoginForm().ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
            label1.Text = $"Hello, {Database.ActiveUser.Username}!";
            label2.Text = $"Points: {Database.ActiveUser.Points}";
        }
    }
}
