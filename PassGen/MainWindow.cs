using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace PassGen;

public partial class MainWindow : RibbonForm
{
	public MainWindow()
	{
		InitializeComponent();
	}

	private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
	{
		SimplePassGenerator simplePass = new();
		simplePass.MdiParent = this;
		simplePass.Show();
	}

	private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
	{
		CustomPassGenerator cstomPass = new();
		cstomPass.MdiParent = this;
		cstomPass.Show();
	}

	private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
	{
		AdvancedPassGenerator advancePass = new();
		advancePass.MdiParent = this;
		advancePass.Show();
	}

	private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
	{
		CheckStrengh checkStrengh = new();
		checkStrengh.MdiParent = this;
		checkStrengh.Show();
	}
}