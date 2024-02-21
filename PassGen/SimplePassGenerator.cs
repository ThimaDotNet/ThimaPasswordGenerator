using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PasswordToolbox;

namespace PassGen;

public partial class SimplePassGenerator : XtraForm
{
	public SimplePassGenerator()
	{
		InitializeComponent();
	}

	private void btnShowPass_Click(object sender, EventArgs e)
	{
		txtPass.Properties.UseSystemPasswordChar = txtPass.Properties.UseSystemPasswordChar == false;
	}

	private void btnGeneratePass_Click(object sender, EventArgs e)
	{
		PasswordGenerator pg = new()
		{
			PasswordLength = 12
		};
		(string, int) generatedPAss =
			pg.GeneratePassword(includeUpper: true, includeLower: true, includeNumbers: true, includeSpecial: true);
		txtPass.Text    = generatedPAss.Item1;
		lblStrengh.Text = generatedPAss.Item2.ToString();
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