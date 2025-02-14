using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace GeoScopeBD.Docking
{
	public class NewDockContent : DockContent
	{
		
		public NewDockContent()
		{
			CloseButton = false;
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			bool cancel = false;
			e.Cancel = true;
			base.OnFormClosing(e);
		}
	}
}
