using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PasswordToolbox;

namespace PassGen;

public partial class CustomPassGenerator : XtraForm
{
	public CustomPassGenerator()
	{
		InitializeComponent();
	}

	private void btnGenerate_Click(object sender, EventArgs e)
	{
		if (!btnUseLowercase.Checked && !btnUseUppercase.Checked)
		{
			MessageBox.Show(@"At least one of Uppercase or Lowercase must be checked");
			return;
		}

		if (nudLengh.Value == 0)
		{
			MessageBox.Show(@"Password lengh must be at least one character");
			return;
		}

		PasswordGenerator pg = new()
		{
			PasswordLength = (int)nudLengh.Value
		};
		(string password, int strength) generatedPassword = pg.GeneratePassword(includeUpper: btnUseUppercase.Checked,
			includeLower: btnUseLowercase.Checked, includeNumbers: btnUseNumbers.Checked,
			includeSpecial: btnUseSpecial.Checked);
		txtPass.Text    = generatedPassword.password;
		lblStrengh.Text = generatedPassword.strength.ToString();
	}

	private void btnShowPass_Click(object sender, EventArgs e)
	{
		txtPass.Properties.UseSystemPasswordChar = !txtPass.Properties.UseSystemPasswordChar;
	}

	private void btnCopyToClipboard_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(txtPass.Text))
		{
			Clipboard.SetText(txtPass.Text);
			MessageBox.Show(@"Copied to clipboard.");
		}
		else
		{
			MessageBox.Show(@"Generate a password first");
		}
	}
}