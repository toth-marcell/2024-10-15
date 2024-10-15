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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Database.Login(usernameField.Text, passwordField.Text))
            {
                DialogResult = DialogResult.OK;
            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (Database.Register(usernameField.Text, passwordField.Text))
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
