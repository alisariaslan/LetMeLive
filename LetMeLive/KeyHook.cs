using EventHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetMeLive
{
	internal class KeyHook
	{
		public static string keyName;
		public static async Task StartHook(Button btn, bool setNow, Form1 form1)
		{
			await Task.Run(() =>
			{
				Console.WriteLine("Task Run");
				using (var eventHookFactory = new EventHookFactory())
				{
					var keyboardWatcher = eventHookFactory.GetKeyboardWatcher();
					keyboardWatcher.Start();
					int i = 0;
					int c = 0;
					keyboardWatcher.OnKeyInput += (s, e) =>
					{
						if (setNow)
						{
							keyName = e.KeyData.Keyname;
							Console.WriteLine(string.Format("Set: {0} {1}", e.KeyData.EventType, keyName));
							btn.Text = e.KeyData.Keyname + "\n is set. Minimize this window then press the key you setted when you are ready.";
							btn.BackColor = System.Drawing.Color.LightGreen;
							keyboardWatcher.Stop();
							setNow = false;
							form1.MinimizeBox = true;
							return;
						}
						else
						{
							if (i == 0)
							{
								if(c == 0)
								{
									Console.WriteLine("Timer Start");
									form1.StartTimer();
									c++;
								} else
								{
									string timeNow = DateTime.Now.ToString("HH:mm:ss");
									Console.WriteLine(string.Format("Log Time: {0} | Event: {1} | Key: {2}", timeNow, e.KeyData.EventType, e.KeyData.Keyname));
									if (e.KeyData.Keyname.Equals(keyName))
									{
										keyboardWatcher.Stop();
										form1.StopListen();
										return;
									}
									c = 0;
								}
								i++;
							}
							else
								i = 0;

						}

					};

				}
			});

		}

	}
}
