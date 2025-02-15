using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace GSBD.Docking.Class
{
	internal class NotDropAbleContent:DockContent
	{
		public NotDropAbleContent()
		{
			AllowEndUserDocking = false;
			AllowDrop = false;
		}
	}
}
