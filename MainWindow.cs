using GeoScopeBD.Docking;
using WeifenLuo.WinFormsUI.Docking;

namespace GeoScopeBD
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			DockpanelMain.Dock = DockStyle.Fill;
			var theme = new VS2015LightTheme();
			
			DockpanelMain.Theme = theme;
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			var dockContent = new NewDockContent();
			var dockContent1 = new NewDockContent();
			var dockContent2 = new NewDockContent();
			dockContent2.Name = "map2";
			dockContent1.Name = "map1";
			dockContent.Name = "map";
			dockContent.TabText = "map";
			dockContent1.TabText = "Legend";
			dockContent2.TabText = "None";
			dockContent2.AllowEndUserDocking = false;
			dockContent2.AllowDrop = false;
			dockContent2.AllowTransparency  = false;
			
			dockContent.Show(DockpanelMain, DockState.DockLeft);

			dockContent1.Show(DockpanelMain, DockState.DockLeft);
			dockContent2.CloseButtonVisible = false;
			dockContent2.AllowDrop = false;
			dockContent2.AllowTransparency = false;
			dockContent2.AllowEndUserDocking = false;
			dockContent2.Show(DockpanelMain, DockState.Document);

		}
	}
}
