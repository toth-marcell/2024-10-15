using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_10_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.OpenConnection();
            if (new LoginForm().ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }
            Text = $"Logged in as {Database.ActiveUser.Username}";
        }
    }
}
