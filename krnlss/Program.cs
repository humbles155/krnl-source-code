using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injection;
using krnlss.Properties;
using Microsoft.Win32;

namespace krnlss
{
	internal static class Program
	{
		public static Form form;

		public static List<string> tabScripts = new List<string>();

		public static bool injecting = false;

		public static bool failed_inject = false;

		public static int __i;

		public static bool debugme;

		public static int idx;

		private static int injectedPID { get; }

		[STAThread]
		public static void writerblx()
		{
		}

		public static void pc(bool start = false, bool urlPassed = false, int key = -1)
		{
			if ((dynamic)debugme)
			{
				if ((dynamic)start)
				{
					File.WriteAllText("pass check.txt", "");
				}
				string text = Convert.ToString(__i++);
				File.AppendAllText("pass check.txt", text + (string)(key switch
				{
					1 => " Key", 
					0 => " No Key", 
					_ => "", 
				}) + (urlPassed ? " Url Passed" : "") + "\n");
			}
		}

		public static bool isCompatible()
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			string text = (string)registryKey.GetValue("ProductName");
			if (text.IndexOf("Windows 8.1") == -1 && (text.IndexOf("Windows 8") == -1 || text.IndexOf("1") == -1))
			{
				return text.IndexOf("Windows 10") != -1;
			}
			return true;
		}

		public static bool hasFolder(string name, string path)
		{
			DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
			int num = 0;
			while (true)
			{
				if (num < directories.Length)
				{
					if ((dynamic)directories[num].Name == name)
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		public static bool hasFile(string name, string path)
		{
			FileInfo[] files = new DirectoryInfo(path).GetFiles();
			int num = 0;
			while (true)
			{
				if (num < files.Length)
				{
					if ((dynamic)files[num].Name == name)
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		private static void LoadReferencedAssembly(Assembly assembly)
		{
			AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
			AssemblyName[] array = referencedAssemblies;
			foreach (AssemblyName name in array)
			{
				if (!AppDomain.CurrentDomain.GetAssemblies().Any((Assembly a) => a.FullName == name.FullName))
				{
					LoadReferencedAssembly(Assembly.Load(name));
				}
			}
		}

		public static void test()
		{
		}

		[STAThread]
		private static void Main()
		{
			if (!File.Exists("krnlss.exe.config"))
			{
				File.WriteAllText("krnlss.exe.config", "<?xml version=\"1.0\" encoding=\"utf-8\" ?><configuration><runtime><assemblyBinding xmlns=\"urn:schemas-microsoft-com:asm.v1\"><probing privatePath=\"bin;bin/src\" /></assemblyBinding></runtime></configuration>");
				Task.Delay(500).GetAwaiter().GetResult();
				Process.Start("krnlss.exe");
				Environment.Exit(0);
			}
			test();
			try
			{
				string[] array = new string[4] { "CefSharp.dll", "CefSharp.Core.dll", "CefSharp.WinForms.dll", "CefSharp.OffScreen.dll" };
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						LoadReferencedAssembly(Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin/src", array[i])));
					}
					catch
					{
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				string[] array2 = new string[2] { "ScintillaNET.dll", "Bunifu_UI_v1.5.3.dll" };
				for (int j = 0; j < array2.Length; j++)
				{
					try
					{
						LoadReferencedAssembly(Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", array2[j])));
					}
					catch
					{
					}
				}
			}
			catch (Exception)
			{
			}
			test();
			ServicePointManager.Expect100Continue = true;
			if ((dynamic)(!isCompatible()))
			{
				MessageBox.Show("You do not have Windows 8.1 or Windows 10!");
				Environment.Exit(1);
				return;
			}
			test();
			Process[] processes = Process.GetProcesses();
			for (int k = 0; k < processes.Length; k++)
			{
				if (processes[k] != Process.GetCurrentProcess() && new string[2] { "krnl", "krnlss" }.ToList().IndexOf(processes[k].ProcessName.Split('.')[0].ToLower()) != -1)
				{
					try
					{
						processes[k].CloseMainWindow();
					}
					catch
					{
					}
				}
			}
			test();
			if ((dynamic)(!Directory.Exists("workspace")))
			{
				Directory.CreateDirectory("workspace");
			}
			if ((dynamic)(!Directory.Exists("scripts")))
			{
				Directory.CreateDirectory("scripts");
			}
			if ((dynamic)(!Directory.Exists("autoexec")))
			{
				Directory.CreateDirectory("autoexec");
			}
			test();
			writerblx();
			if ((dynamic)File.Exists("krnl.exe.bak"))
			{
				File.Delete("krnl.exe.bak");
			}
			test();
			Stack<string> stack = new Stack<string>(Environment.CurrentDirectory.Split('\\'));
			bool flag = false;
			stack.Reverse();
			while (stack.Count != 0)
			{
				if (!(((dynamic)string.Join("\\", stack.ToArray().Reverse()) + "\\" == Path.GetTempPath()) ? true : false))
				{
					stack.Pop();
					continue;
				}
				flag = true;
				break;
			}
			if ((!(dynamic)flag))
			{
				if (Directory.GetCurrentDirectory().Split('\\').ToList()
					.Last()
					.StartsWith("Rar$EX"))
				{
					flag = true;
				}
				if (Directory.GetCurrentDirectory().ToLower().IndexOf("c:\\windows\\system32") != -1)
				{
					flag = false;
					MessageBox.Show("You cannot run this here!\nYou must extract the zip file!", "Zip file detected.");
				}
			}
			if ((dynamic)flag)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				if ((dynamic)(!Directory.Exists(folderPath + "\\krnl")))
				{
					Directory.CreateDirectory(folderPath + "\\krnl");
				}
				string text = folderPath + "\\krnl";
				new DirectoryInfo(text);
				DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
				directoryInfo.GetDirectories();
				FileInfo[] files = directoryInfo.GetFiles();
				MessageBox.Show("You cannot run this here!\nExtracting the zip file to your Desktop.", "Zip file detected.");
				MessageBox.Show(Process.GetCurrentProcess().MainModule.FileName);
				for (int l = 0; l < files.Length; l++)
				{
					if ((dynamic)(!hasFile(files[l].Name, text)))
					{
						files[l].CopyTo(files[l].FullName.Replace(Environment.CurrentDirectory, text), overwrite: true);
					}
				}
				Process.Start(text);
				Process.Start(new ProcessStartInfo
				{
					WorkingDirectory = text,
					FileName = "krnl.exe",
					CreateNoWindow = true
				});
				Environment.Exit(1);
				return;
			}
			test();
			if (!Settings.Default.monaco)
			{
				form = new krnl();
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						Task.Delay(500).GetAwaiter().GetResult();
						if (krnl_monaco.findpipe("krnlpipe"))
						{
							form.Invoke((MethodInvoker)delegate
							{
								Control control4 = form.Controls["bunifuFlatButton5"];
								((control4 is BunifuFlatButton) ? control4 : null).Text = "INJECTED";
							});
							injecting = false;
							failed_inject = false;
						}
						else if (!injecting || failed_inject || (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0 && Process.GetProcessesByName("RobloxPlayerLauncher").Length == 0))
						{
							form.Invoke((MethodInvoker)delegate
							{
								Control control3 = form.Controls["bunifuFlatButton5"];
								((control3 is BunifuFlatButton) ? control3 : null).Text = "INJECT";
							});
							injecting = false;
							failed_inject = false;
						}
					}
				}).Start();
			}
			else
			{
				form = new krnl_monaco();
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						Task.Delay(500).GetAwaiter().GetResult();
						if (krnl_monaco.findpipe("krnlpipe"))
						{
							form.Invoke((MethodInvoker)delegate
							{
								Control control2 = form.Controls["bunifuFlatButton5"];
								((control2 is BunifuFlatButton) ? control2 : null).Text = "INJECTED";
							});
							injecting = false;
							failed_inject = false;
						}
						else if (!injecting || failed_inject || (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0 && Process.GetProcessesByName("RobloxPlayerLauncher").Length == 0))
						{
							form.Invoke((MethodInvoker)delegate
							{
								Control control = form.Controls["bunifuFlatButton5"];
								((control is BunifuFlatButton) ? control : null).Text = "INJECT";
							});
							injecting = false;
							failed_inject = false;
						}
					}
				}).Start();
			}
			test();
			form.Width = 690;
			form.Opacity = 0.0;
			Application.Run(form);
			form.Load += Form_Activated;
			form.Disposed += Form_Disposed;
			form.FormClosing += Form_FormClosing;
			Process.GetCurrentProcess().Disposed += Program_Disposed;
			Process.GetCurrentProcess().Exited += Program_Exited;
			AppDomain.CurrentDomain.ProcessExit += CurrentDomain_ProcessExit;
			test();
		}

		private static void Program_Disposed(object sender, EventArgs e)
		{
			if (Settings.Default.monaco)
			{
				MessageBox.Show(((krnl_monaco)form).customTabControl1.TabCount.ToString());
			}
		}

		private static void Program_Exited(object sender, EventArgs e)
		{
			if (Settings.Default.monaco)
			{
				MessageBox.Show(((krnl_monaco)form).customTabControl1.TabCount.ToString());
			}
		}

		private static void Form_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Settings.Default.monaco)
			{
				MessageBox.Show(((krnl_monaco)form).customTabControl1.TabCount.ToString());
			}
		}

		private static void Form_Disposed(object sender, EventArgs e)
		{
			if (Settings.Default.monaco)
			{
				MessageBox.Show(((krnl_monaco)form).customTabControl1.TabCount.ToString());
			}
		}

		private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
		{
			if (Settings.Default.monaco)
			{
				MessageBox.Show(((krnl_monaco)form).customTabControl1.TabCount.ToString());
			}
		}

		public static void writeToDir(string directory)
		{
		}

		public static bool injectdll(dynamic filename, int PID)
		{
			krnlgay.krnlgayResult krnlgayResult = krnlgay.DllInjector.GetInstance.Inject(Application.StartupPath + $"\\\\{(object)filename}", PID);
			string text = "";
			string text2 = "";
			if ((dynamic)krnlgayResult == krnlgay.krnlgayResult.DllNotFound)
			{
				text = $"{(object)filename} is missing!";
			}
			if ((dynamic)krnlgayResult == krnlgay.krnlgayResult.Failed)
			{
				text = "Failed to inject for unknown reason.";
			}
			if ((dynamic)krnlgayResult == krnlgay.krnlgayResult.Success)
			{
				injectedPID = PID;
			}
			if ((dynamic)krnlgayResult == krnlgay.krnlgayResult.threaderr)
			{
				text = "Caught Thread Error";
				text2 = "Unknown Error";
			}
			if ((dynamic)(!string.IsNullOrEmpty(text)))
			{
				MessageBox.Show(text, (text2 != "") ? text2 : "Krnl Error");
				return false;
			}
			return true;
		}

		private static void Form_Activated(object sender, EventArgs e)
		{
			while (form.Opacity < 1.0)
			{
				form.Opacity += 0.05;
				Task.Delay(1).GetAwaiter().GetResult();
			}
		}
	}
}
