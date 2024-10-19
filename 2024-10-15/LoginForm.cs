using System;
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
				MessageBox.Show($"You've logged in as {Database.ActiveUser.Username}");
				DialogResult = DialogResult.OK;
			}
		}
		private void registerButton_Click(object sender, EventArgs e)
		{
			if (usernameField.Text == "" && passwordField.Text == "")
			{
				MessageBox.Show("You must fill out both fields!");
			}
			else if (Database.Register(usernameField.Text, passwordField.Text))
			{
				MessageBox.Show($"Succesfully registered as {Database.ActiveUser.Username}");
				DialogResult = DialogResult.OK;
			}
		}
	}
}
