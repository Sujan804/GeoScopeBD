using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GSBD.Docking.Class
{
	public class NotCloseAbleContent : DockContent
	{
		public NotCloseAbleContent()
		{
			CloseButton = false;
			CloseButtonVisible = false;
		}
	}
}
