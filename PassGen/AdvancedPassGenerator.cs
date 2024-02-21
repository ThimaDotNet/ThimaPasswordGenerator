using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PasswordToolbox;

namespace PassGen;

public partial class AdvancedPassGenerator : XtraForm
{
	public AdvancedPassGenerator()
	{
		InitializeComponent();
	}

	private void btnShowPass_Click(object sender, EventArgs e)
	{
		txtPass.Properties.UseSystemPasswordChar = !txtPass.Properties.UseSystemPasswordChar;
	}

	private void txtUpper_KeyPress(object sender, KeyPressEventArgs e)
	{
		// Allow only alphabetical characters
		if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
	}

	private void txtLower_KeyPress(object sender, KeyPressEventArgs e)
	{
		// Allow only alphabetical characters
		if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
	}

	private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
	{
		// Allow only numeric characters
		if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
	}

	private void txtSpecial_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!IsSpecialCharacter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
	}

	private bool IsSpecialCharacter(char c)
	{
		// Customize this method based on the special characters you want to allow
		const string allowedSpecialCharacters = "!@#$%^&*()_-+=[]{}|;:'<>,.?/";
		return allowedSpecialCharacters.Contains(c.ToString());
	}


	private void btnUseUppercase_CheckedChanged_1(object sender, EventArgs e)
	{
		txtUpper.Properties.ReadOnly = !btnUseUppercase.Checked;
		if (txtUpper.Properties.ReadOnly) txtUpper.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	}

	private void btnUseLowercase_CheckedChanged(object sender, EventArgs e)
	{
		txtLower.Properties.ReadOnly = !btnUseLowercase.Checked;
		if (txtLower.Properties.ReadOnly) txtLower.Text = "abcdefghijklmnopqrstuvwxyz";
	}

	private void btnUseNumbers_CheckedChanged(object sender, EventArgs e)
	{
		txtNumbers.Properties.ReadOnly = !btnUseNumbers.Checked;

		if (txtNumbers.Properties.ReadOnly) txtNumbers.Text = "0123456789";
	}

	private void btnUseSpecial_CheckedChanged(object sender, EventArgs e)
	{
		txtSpecial.Properties.ReadOnly = !btnUseSpecial.Checked;

		if (txtSpecial.Properties.ReadOnly) txtSpecial.Text = "!@#$%^&*()_ +";
	}

	private void btnGenerate_Click(object sender, EventArgs e)
	{
		if (nudLengh.Value <= 0)
		{
			MessageBox.Show("Lengh is invalid");
			return;
		}


		PasswordGenerator pg                                  = new();
		if (nudLengh.Text is not null) pg.PasswordLength      = (int)nudLengh.Value;
		if (txtLower.Text is not null) pg.LowercaseCharacters = txtLower.Text;
		if (txtUpper.Text is not null) pg.UppercaseCharacters = txtUpper.Text;
		if (txtNumbers.Text is not null) pg.NumberCharacters  = txtNumbers.Text;
		if (txtSpecial.Text is not null) pg.SpecialCharacters = txtSpecial.Text;

		(string password, int strength) generatedPassword = pg.GeneratePassword(includeUpper: btnUseUppercase.Checked,
			includeLower: btnUseLowercase.Checked,
			includeNumbers: btnUseNumbers.Checked, includeSpecial: btnUseSpecial.Checked);
		txtPass.Text    = generatedPassword.password;
		lblStrengh.Text = generatedPassword.strength.ToString();
	}
}