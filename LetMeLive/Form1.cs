using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace LetMeLive
{

	public partial class Form1 : Form
	{
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		const int SW_HIDE = 0;
		const int SW_SHOW = 5;
		IntPtr console;

		static Task pos;


		public Form1()
		{
			InitializeComponent();
			Form.CheckForIllegalCrossThreadCalls = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			console = GetConsoleWindow();
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Task task = KeyHook.StartHook(btn_set, false,this);
			
				Console.WriteLine("Start Listen");
				Hide();
				ShowWindow(console, SW_HIDE);
			}
		}

		private void btn_set_Click(object sender, EventArgs e)
		{
			this.MinimizeBox = false;
			Console.WriteLine("Start Listen");
			btn_set.Text = "Press this button for setting your pause key";
			btn_set.BackColor = btn_set.BackColor = System.Drawing.Color.Red;
			Task task = KeyHook.StartHook(btn_set,true,this);
		}

		public void StopListen()
		{
			ShowWindow(console, SW_SHOW);
			Show();
			Console.WriteLine("Stop Listen");
			SetPos.StopTimer();
		}

		public void StartTimer()
		{
			int directionX;
			if (rb_left.Checked)
				directionX = -1;
			else
				directionX = 1;
			SetPos.SetTimer(trackBar1.Value, directionX);
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			lbl_speed.Text = "Speed: " + trackBar1.Value;
		}
	}
}
