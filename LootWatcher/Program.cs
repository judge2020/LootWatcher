using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace LootWatcher
{
	class Program
	{


		public static TrayIcon MyIcon = new TrayIcon();


		static void Main()
		{
			BoxWatcher myWatcher = new BoxWatcher(MyIcon);

			while(Console.ReadLine() == "q")
			{

			}

		}
		private static void MainTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
		{

		}
	}
}
