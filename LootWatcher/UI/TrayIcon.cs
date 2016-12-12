using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Drawing;

namespace LootWatcher
{
	class TrayIcon
	{
		public ContextMenu trayMenu { get; }
		public NotifyIcon trayIcon { get; }
		public TrayIcon()
		{
			trayIcon = new NotifyIcon();
			trayIcon.Text = "LootWatcher";
			trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);
			trayIcon.ContextMenu = trayMenu;
			trayIcon.Visible = true;
			trayIcon.Click += TrayIconOnClick;
			
		}

		private void TrayIconOnClick(object sender, EventArgs eventArgs)
		{
			Environment.Exit(0);
		}

		public void ShowNotification(string title, string text)
		{
			trayIcon.ShowBalloonTip(5, title, title, ToolTipIcon.Info);
		}
	}
}
