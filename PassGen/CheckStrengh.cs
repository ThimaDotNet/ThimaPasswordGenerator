using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PasswordToolbox;

namespace PassGen;

public partial class CheckStrengh : XtraForm
{
	public CheckStrengh()
	{
		InitializeComponent();
	}

	private void simpleButton1_Click(object sender, EventArgs e)
	{
		if (textEdit1.Text is null || string.IsNullOrWhiteSpace(textEdit1.Text))
		{
			MessageBox.Show("Type password");
			return;
		}

		if (textEdit1.Text.Length >= 8)
		{
			int strength = PasswordGenerator.CalculateStrength(textEdit1.Text);
			lblStrengh.Text  = strength.ToString();
			tkbStrengh.Value = strength;
		}
		else
		{
			lblStrengh.Text  = "0";
			tkbStrengh.Value = 0;
		}
	}
}