namespace GeoScopeBD
{
	partial class MainWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			AppManager = new DotSpatial.Controls.AppManager();
			DockpanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
			SuspendLayout();
			// 
			// AppManager
			// 
			AppManager.Directories = (List<string>)resources.GetObject("AppManager.Directories");
			AppManager.DockManager = null;
			AppManager.HeaderControl = null;
			AppManager.Legend = null;
			AppManager.Map = null;
			AppManager.ProgressHandler = null;
			// 
			// DockpanelMain
			// 
			DockpanelMain.Dock = DockStyle.Fill;
			DockpanelMain.Location = new Point(0, 0);
			DockpanelMain.Name = "DockpanelMain";
			DockpanelMain.Size = new Size(1037, 569);
			DockpanelMain.TabIndex = 1;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1037, 569);
			Controls.Add(DockpanelMain);
			Icon = (Icon)resources.GetObject("$this.Icon");
			IsMdiContainer = true;
			Name = "MainWindow";
			Text = "GeoScope BD";
			Load += MainWindow_Load;
			ResumeLayout(false);
		}

		#endregion
		private DotSpatial.Controls.AppManager AppManager;
		private WeifenLuo.WinFormsUI.Docking.DockPanel DockpanelMain;
	}
}
