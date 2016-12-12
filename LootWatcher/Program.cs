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
		[DllImport("user32.dll",SetLastError = true)]
		public static extern IntPtr GetDesktopWindow();
		[DllImport("user32.dll",SetLastError = true)]
		public static extern IntPtr GetWindowDC(IntPtr window);
		[DllImport("gdi32.dll",SetLastError = true)]
		public static extern uint GetPixel(IntPtr dc,int x,int y);
		[DllImport("user32.dll",SetLastError = true)]
		public static extern int ReleaseDC(IntPtr window,IntPtr dc);

		public static Color GetColorAt(int x,int y)
		{
			IntPtr desk = GetDesktopWindow();
			IntPtr dc = GetWindowDC(desk);
			int a = (int)GetPixel(dc,x,y);
			ReleaseDC(desk,dc);
			return Color.FromArgb(255,(a>>0)&0xff,(a>>8)&0xff,(a>>16)&0xff);
		}




















		public static TrayIcon MyIcon = new TrayIcon();


		static void Main()
		{
			Timer mainTimer = new Timer(300);
			mainTimer.Elapsed+=MainTimerOnElapsed;
			mainTimer.Start();
			
			while (Console.ReadLine() == "q")
			{
				
			}
			
		}
		private static void MainTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
		{
			Color reward1Color = GetColorAt(849,392);
			Color reward2Color = GetColorAt(923,364);
			Color reward3Color = GetColorAt(1020,339);
			Color reward4Color = GetColorAt(1156,423);
			Console.WriteLine("1 | " + reward1Color.R + " | " + reward1Color.G + " | " + reward1Color.B);
			Console.WriteLine("2 | "+reward2Color.R+" | "+reward2Color.G+" | "+reward2Color.B);
			Console.WriteLine("3 | "+reward3Color.R+" | "+reward3Color.G+" | "+reward3Color.B);
			Console.WriteLine("4 | "+reward4Color.R+" | "+reward4Color.G+" | "+reward4Color.B);

			//if (reward1Color.R < 150 && reward1Color.G < 200 && reward1Color.G > 70 && reward1Color.B > 150)
			//{
			//	MyIcon.ShowNotification("RARE","WHOA");
			//}
			if (reward1Color.R > 246 && reward1Color.G > 242 && reward1Color.B > 80 && reward1Color.B < 150)
			{
				MyIcon.ShowNotification("LEGENDARY", "EDVESFRG");
			}
			if(reward2Color.R>246&&reward2Color.G>242&&reward2Color.B>80&&reward2Color.B<150)
			{
				MyIcon.ShowNotification("LEGENDARY","EDVESFRG");
			}
			if(reward3Color.R>246&&reward3Color.G>242&&reward3Color.B>80&&reward3Color.B<150)
			{
				MyIcon.ShowNotification("LEGENDARY","EDVESFRG");
			}
			if(reward4Color.R>246&&reward4Color.G>242&&reward4Color.B>80&&reward4Color.B<150)
			{
				MyIcon.ShowNotification("LEGENDARY", "EDVESFRG");
			}
		}
	}
}
