using DotSpatial.Controls;
using DotSpatial.Controls.Docking;
using DotSpatial.Controls.Header;
using GeoScopeBD.Controls;
using GeoScopeBD.Docking;
using System.ComponentModel.Composition;
using WeifenLuo.WinFormsUI.Docking;

namespace GeoScopeBD
{
	public partial class MainWindow : Form
	{
		[Export("Shell", typeof(ContainerControl))]
		private static ContainerControl shell;
		public Map MainMap { get; set; } = new Map();
		public Legend MapLegend { get; set; } = new Legend();
		public MainWindow()
		{
			InitializeComponent();
			if (DesignMode) return;
			shell = this;
			WindowState = FormWindowState.Maximized;
			DockpanelMain.Dock = DockStyle.Fill;
			var theme = new VS2015LightTheme();
			DockpanelMain.Theme = theme;

			AppManager = new AppManager
			{
				HeaderControl = null,
				ProgressHandler = null,
				Map = MainMap,
				Legend = MapLegend
			};
			
			AppManager.SatisfyImportsExtensionsActivated +=
			   delegate
			   {
				   DockablePanel dp = new("kMap", "Map", (Map)AppManager.Map, DockStyle.Fill) { SmallImage = null };
				   AppManager.DockManager.Add(dp);
				   NavigationControl nc = new(AppManager)
				   {
					   Parent = (UserControl)AppManager.Map
				   };
				   nc.Show();
			   };
			AppManager.LoadExtensions();
		}
		
		private void MainWindow_Load(object sender, EventArgs e)
		{
            Console.WriteLine(AppManager.Extensions.Count());
			var dockContent = new NewDockContent();
			var dockContent1 = new NewDockContent();
			var dockContent2 = new NewDockContent();
			dockContent2.Name = "map2";
			dockContent1.Name = "map1";
			dockContent.Name = "map";
			dockContent.TabText = "map";
			dockContent1.TabText = "Legend";
			MainMap.Legend = MapLegend;
			MapLegend.Dock = DockStyle.Fill;
			dockContent1.Controls.Add(MapLegend);
			dockContent2.TabText = "None";
			(MainMap as Control).Dock = DockStyle.Fill;
			dockContent2.Controls.Add((Control?)AppManager.Map);
			dockContent2.AllowEndUserDocking = false;
			dockContent2.AllowDrop = false;
			dockContent2.AllowTransparency = false;

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
