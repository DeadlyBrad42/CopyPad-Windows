using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CopyPad
{
	class ProcessIcon : IDisposable
	{
		NotifyIcon tray;

		public ProcessIcon()
		{
			tray = new NotifyIcon();
		}

		public void Display()
		{
			tray.MouseClick += new MouseEventHandler(click);
			tray.Icon = Properties.Resources.noticon;
			tray.Text = "CopyPad";
			tray.Visible = true;

			tray.ContextMenu = (new ContextMenus()).Create();
		}

		public void Dispose()
		{
			tray.Dispose();
		}

		void click(object sender, EventArgs e)
		{
			//tray.ShowBalloonTip(1000, "CopyPad for Windows!", "Programmed for no real reason by Brad Mason", ToolTipIcon.Info);
			Clipboard.SetText("ಠ_ಠ");
		}
	}
}
