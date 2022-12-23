using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;

namespace LetMeLive
{
	internal class SetPos
	{
		public static Timer posTimer;
		private static int dir = 1;
		private static int val = 7;
		
		public static void SetTimer(int trackBarValue,int directionX)
		{
			dir = directionX;
			val = trackBarValue;
			// Create a timer with a two second interval.
			posTimer = new System.Timers.Timer(val);
			// Hook up the Elapsed event for the timer. 
			posTimer.Elapsed += OnTimedEvent;
			posTimer.AutoReset = true;
			posTimer.Enabled = true;
		}
		
		public static void StopTimer()
		{
			posTimer.Stop();
		}

		private static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			int x = System.Windows.Forms.Control.MousePosition.X;
			int y = System.Windows.Forms.Control.MousePosition.Y;
			if (dir == -1)
			{
				x--;
				if (val > 0)
					val *= -1;
			}
				
			else
				x++;
			MouseEvent.POINT point = new MouseEvent.POINT(x+val, y);
			MouseEvent.ClientToScreen(IntPtr.Zero, ref point);
			MouseEvent.SetCursorPos(point.x, point.y);

		}

		
		
	}
}
