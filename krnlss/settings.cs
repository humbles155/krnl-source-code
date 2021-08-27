using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injection;
using krnlss.Properties;
using ToggleSlider;

namespace krnlss
{
	public class settings : Form
	{
		private Form parent;

		private Thread autoinjectiont;

		private IContainer components;

		private Panel panel1;

		private BunifuCustomLabel bunifuCustomLabel1;

		private BunifuCustomLabel bunifuCustomLabel2;

		private ToggleSliderComponent toggleSliderComponent1;

		private ToggleSliderComponent toggleSliderComponent2;

		private Button button3;

		private Button button4;

		private ToggleSliderComponent toggleSliderComponent3;

		private BunifuCustomLabel bunifuCustomLabel3;

		private Label label1;

		private PictureBox pictureBox1;

		private BunifuCustomLabel bunifuCustomLabel4;

		private Button button1;

		private ToggleSliderComponent toggleSliderComponent4;

		private BunifuCustomLabel bunifuCustomLabel5;

		private ToggleSliderComponent toggleSliderComponent5;

		private BunifuCustomLabel bunifuCustomLabel6;

		private BunifuElipse bunifuElipse1;

		public static bool monaco_changed;

		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		public settings(Form parentt)
		{
			InitializeComponent();
			parent = parentt;
		}

		private void krnl_Load(object sender, EventArgs e)
		{
			if (Settings.Default.autoinject)
			{
				toggleSliderComponent1.Checked = true;
			}
			if (Settings.Default.topmostchecked)
			{
				toggleSliderComponent2.Checked = true;
			}
			if (Settings.Default.fadein_out_opacity)
			{
				toggleSliderComponent3.Checked = true;
			}
			if (Settings.Default.remove_crash_logs)
			{
				toggleSliderComponent4.Checked = true;
			}
			if (Settings.Default.monaco)
			{
				toggleSliderComponent5.Checked = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
		}

		private void OPACITYASSS_ValueChanged(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void panel1_MouseDown_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				krnl.ReleaseCapture();
				krnl.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private void toggleSliderComponent2_Load(object sender, EventArgs e)
		{
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void injectdll(dynamic filename, int PID)
		{
			switch (krnlgay.DllInjector.GetInstance.Inject(Application.StartupPath + $"\\\\{(object)filename}", PID))
			{
			case krnlgay.krnlgayResult.Failed:
				MessageBox.Show("Injection Failed For Unspecified Reason");
				break;
			case krnlgay.krnlgayResult.DllNotFound:
				MessageBox.Show($"Dll Named {(object)filename} Not Found!");
				break;
			}
		}

		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		private static bool findpipe(string pipeName)
		{
			try
			{
				if (WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) && (Marshal.GetLastWin32Error() == 0 || Marshal.GetLastWin32Error() == 2))
				{
					return false;
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private void autoinjectbruh()
		{
		}

		private void toggleSliderComponent1_Load(object sender, EventArgs e)
		{
		}

		private void toggleSliderComponent1_CheckChanged(object sender, EventArgs e)
		{
			if (toggleSliderComponent1.Checked)
			{
				autoinjectiont = new Thread(autoinjectbruh);
				autoinjectiont.IsBackground = true;
				autoinjectiont.Start();
				Settings.Default.autoinject = true;
				Settings.Default.Save();
				return;
			}
			if (autoinjectiont != null)
			{
				autoinjectiont.Abort();
				autoinjectiont = null;
			}
			Settings.Default.autoinject = false;
			Settings.Default.Save();
		}

		private void toggleSliderComponent2_CheckChanged(object sender, EventArgs e)
		{
			if (toggleSliderComponent2.Checked)
			{
				base.TopMost = true;
				parent.TopMost = true;
				Settings.Default.topmostchecked = true;
				Settings.Default.Save();
			}
			else
			{
				base.TopMost = false;
				parent.TopMost = false;
				Settings.Default.topmostchecked = false;
				Settings.Default.Save();
			}
		}

		private void settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (monaco_changed)
			{
				base.TopMost = true;
				DialogResult dialogResult = MessageBox.Show("Automatically restart the UI to complete the changes?", "Krnl Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Yes)
				{
					Process.Start(Process.GetCurrentProcess().MainModule.FileName);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected O, but got Unknown
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(krnlss.settings));
			panel1 = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			button3 = new System.Windows.Forms.Button();
			button4 = new System.Windows.Forms.Button();
			bunifuCustomLabel1 = new BunifuCustomLabel();
			bunifuCustomLabel2 = new BunifuCustomLabel();
			bunifuElipse1 = new BunifuElipse(components);
			bunifuCustomLabel3 = new BunifuCustomLabel();
			bunifuCustomLabel4 = new BunifuCustomLabel();
			button1 = new System.Windows.Forms.Button();
			bunifuCustomLabel5 = new BunifuCustomLabel();
			bunifuCustomLabel6 = new BunifuCustomLabel();
			toggleSliderComponent5 = new ToggleSlider.ToggleSliderComponent();
			toggleSliderComponent4 = new ToggleSlider.ToggleSliderComponent();
			toggleSliderComponent3 = new ToggleSlider.ToggleSliderComponent();
			toggleSliderComponent2 = new ToggleSlider.ToggleSliderComponent();
			toggleSliderComponent1 = new ToggleSlider.ToggleSliderComponent();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button4);
			panel1.Location = new System.Drawing.Point(-9, -3);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(281, 37);
			panel1.TabIndex = 13;
			panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(panel1_MouseDown_1);
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(7, 1);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(35, 36);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 24;
			pictureBox1.TabStop = false;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(110, 11);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(54, 17);
			label1.TabIndex = 23;
			label1.Text = "Settings";
			button3.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button3.ForeColor = System.Drawing.Color.White;
			button3.Location = new System.Drawing.Point(200, -1);
			button3.Margin = new System.Windows.Forms.Padding(4);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(25, 37);
			button3.TabIndex = 22;
			button3.Text = "—";
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click_1);
			button4.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			button4.FlatAppearance.BorderSize = 0;
			button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button4.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button4.ForeColor = System.Drawing.Color.White;
			button4.Location = new System.Drawing.Point(228, -1);
			button4.Margin = new System.Windows.Forms.Padding(4);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(25, 37);
			button4.TabIndex = 21;
			button4.Text = "✕";
			button4.UseVisualStyleBackColor = false;
			button4.Click += new System.EventHandler(button4_Click);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).AutoSize = true;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).ForeColor = System.Drawing.Color.White;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).Location = new System.Drawing.Point(10, 81);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).Name = "bunifuCustomLabel1";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).Size = new System.Drawing.Size(64, 17);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).TabIndex = 15;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel1).Text = "Top Most";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).AutoSize = true;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).ForeColor = System.Drawing.Color.White;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).Location = new System.Drawing.Point(10, 55);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).Name = "bunifuCustomLabel2";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).Size = new System.Drawing.Size(75, 17);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).TabIndex = 17;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel2).Text = "Auto Attach";
			bunifuElipse1.set_ElipseRadius(5);
			bunifuElipse1.set_TargetControl((System.Windows.Forms.Control)this);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).AutoSize = true;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).ForeColor = System.Drawing.Color.White;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).Location = new System.Drawing.Point(12, 108);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).Name = "bunifuCustomLabel3";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).Size = new System.Drawing.Size(123, 17);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).TabIndex = 15;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel3).Text = "Opacity Fade-in/out";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).AutoSize = true;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).ForeColor = System.Drawing.Color.White;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).Location = new System.Drawing.Point(12, 195);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).Name = "bunifuCustomLabel4";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).Size = new System.Drawing.Size(116, 17);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).TabIndex = 21;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel4).Text = "Install missing files";
			button1.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.Color.White;
			button1.Location = new System.Drawing.Point(155, 195);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(62, 23);
			button1.TabIndex = 22;
			button1.Text = "INSTALL";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click_2);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).AutoSize = true;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).ForeColor = System.Drawing.Color.White;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).Location = new System.Drawing.Point(12, 134);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).Name = "bunifuCustomLabel5";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).Size = new System.Drawing.Size(124, 17);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).TabIndex = 15;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel5).Text = "Remove Crash Logs";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).AutoSize = true;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).Enabled = false;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).ForeColor = System.Drawing.Color.White;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).Location = new System.Drawing.Point(12, 163);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).Name = "bunifuCustomLabel6";
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).Size = new System.Drawing.Size(100, 17);
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).TabIndex = 15;
			((System.Windows.Forms.Control)(object)bunifuCustomLabel6).Text = "Toggle Monaco";
			toggleSliderComponent5.AutoSize = true;
			toggleSliderComponent5.Checked = false;
			toggleSliderComponent5.Location = new System.Drawing.Point(187, 163);
			toggleSliderComponent5.Margin = new System.Windows.Forms.Padding(4);
			toggleSliderComponent5.Name = "toggleSliderComponent5";
			toggleSliderComponent5.Size = new System.Drawing.Size(54, 21);
			toggleSliderComponent5.TabIndex = 20;
			toggleSliderComponent5.ToggleBarText = "";
			toggleSliderComponent5.ToggleCircleColor = System.Drawing.Color.FromArgb(91, 91, 91);
			toggleSliderComponent5.ToggleColorBar = System.Drawing.Color.FromArgb(35, 35, 35);
			toggleSliderComponent5.CheckChanged += new System.EventHandler(toggleSliderComponent5_CheckChanged);
			toggleSliderComponent5.Load += new System.EventHandler(toggleSliderComponent5_Load);
			toggleSliderComponent4.AutoSize = true;
			toggleSliderComponent4.Checked = false;
			toggleSliderComponent4.Location = new System.Drawing.Point(187, 134);
			toggleSliderComponent4.Margin = new System.Windows.Forms.Padding(4);
			toggleSliderComponent4.Name = "toggleSliderComponent4";
			toggleSliderComponent4.Size = new System.Drawing.Size(54, 21);
			toggleSliderComponent4.TabIndex = 20;
			toggleSliderComponent4.ToggleBarText = "";
			toggleSliderComponent4.ToggleCircleColor = System.Drawing.Color.FromArgb(91, 91, 91);
			toggleSliderComponent4.ToggleColorBar = System.Drawing.Color.FromArgb(35, 35, 35);
			toggleSliderComponent4.CheckChanged += new System.EventHandler(toggleSliderComponent4_CheckChanged);
			toggleSliderComponent4.Load += new System.EventHandler(toggleSliderComponent4_Load);
			toggleSliderComponent3.AutoSize = true;
			toggleSliderComponent3.Checked = false;
			toggleSliderComponent3.Location = new System.Drawing.Point(187, 108);
			toggleSliderComponent3.Margin = new System.Windows.Forms.Padding(4);
			toggleSliderComponent3.Name = "toggleSliderComponent3";
			toggleSliderComponent3.Size = new System.Drawing.Size(54, 21);
			toggleSliderComponent3.TabIndex = 20;
			toggleSliderComponent3.ToggleBarText = "";
			toggleSliderComponent3.ToggleCircleColor = System.Drawing.Color.FromArgb(91, 91, 91);
			toggleSliderComponent3.ToggleColorBar = System.Drawing.Color.FromArgb(35, 35, 35);
			toggleSliderComponent3.CheckChanged += new System.EventHandler(toggleSliderComponent3_CheckChanged);
			toggleSliderComponent3.Load += new System.EventHandler(toggleSliderComponent3_Load);
			toggleSliderComponent2.AutoSize = true;
			toggleSliderComponent2.Checked = false;
			toggleSliderComponent2.Location = new System.Drawing.Point(187, 81);
			toggleSliderComponent2.Margin = new System.Windows.Forms.Padding(4);
			toggleSliderComponent2.Name = "toggleSliderComponent2";
			toggleSliderComponent2.Size = new System.Drawing.Size(54, 21);
			toggleSliderComponent2.TabIndex = 20;
			toggleSliderComponent2.ToggleBarText = "";
			toggleSliderComponent2.ToggleCircleColor = System.Drawing.Color.FromArgb(91, 91, 91);
			toggleSliderComponent2.ToggleColorBar = System.Drawing.Color.FromArgb(35, 35, 35);
			toggleSliderComponent2.CheckChanged += new System.EventHandler(toggleSliderComponent2_CheckChanged);
			toggleSliderComponent2.Load += new System.EventHandler(toggleSliderComponent2_Load);
			toggleSliderComponent1.AutoSize = true;
			toggleSliderComponent1.Checked = false;
			toggleSliderComponent1.Location = new System.Drawing.Point(187, 55);
			toggleSliderComponent1.Margin = new System.Windows.Forms.Padding(4);
			toggleSliderComponent1.Name = "toggleSliderComponent1";
			toggleSliderComponent1.Size = new System.Drawing.Size(54, 21);
			toggleSliderComponent1.TabIndex = 19;
			toggleSliderComponent1.ToggleBarText = "";
			toggleSliderComponent1.ToggleCircleColor = System.Drawing.Color.FromArgb(91, 91, 91);
			toggleSliderComponent1.ToggleColorBar = System.Drawing.Color.FromArgb(35, 35, 35);
			toggleSliderComponent1.CheckChanged += new System.EventHandler(toggleSliderComponent1_CheckChanged);
			toggleSliderComponent1.Load += new System.EventHandler(toggleSliderComponent1_Load);
			BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new System.Drawing.Size(248, 230);
			base.Controls.Add(button1);
			base.Controls.Add((System.Windows.Forms.Control)(object)bunifuCustomLabel4);
			base.Controls.Add(toggleSliderComponent5);
			base.Controls.Add(toggleSliderComponent4);
			base.Controls.Add(toggleSliderComponent3);
			base.Controls.Add(toggleSliderComponent2);
			base.Controls.Add(toggleSliderComponent1);
			base.Controls.Add((System.Windows.Forms.Control)(object)bunifuCustomLabel2);
			base.Controls.Add((System.Windows.Forms.Control)(object)bunifuCustomLabel6);
			base.Controls.Add((System.Windows.Forms.Control)(object)bunifuCustomLabel5);
			base.Controls.Add((System.Windows.Forms.Control)(object)bunifuCustomLabel3);
			base.Controls.Add((System.Windows.Forms.Control)(object)bunifuCustomLabel1);
			base.Controls.Add(panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "settings";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(settings_FormClosing);
			base.Load += new System.EventHandler(krnl_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void toggleSliderComponent3_Load(object sender, EventArgs e)
		{
		}

		private void toggleSliderComponent3_CheckChanged(object sender, EventArgs e)
		{
			Settings.Default.fadein_out_opacity = toggleSliderComponent3.Checked;
			if (Settings.Default.fadein_out_opacity)
			{
				while (parent.Opacity > 0.5)
				{
					Task.Delay(10).GetAwaiter().GetResult();
					parent.Opacity -= 0.05;
				}
			}
			else
			{
				while (parent.Opacity < 1.0)
				{
					Task.Delay(10).GetAwaiter().GetResult();
					parent.Opacity += 0.05;
				}
			}
			Settings.Default.Save();
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			new WebClient().DownloadFile(new Uri("http://cdn.krnl.rocks:8080/bootstrapper"), "krnl_bootstrapper_v3.exe");
			Process.Start("krnl_bootstrapper_v3.exe");
			Environment.Exit(1);
		}

		private void toggleSliderComponent4_CheckChanged(object sender, EventArgs e)
		{
			Settings.Default.remove_crash_logs = toggleSliderComponent4.Checked;
			Settings.Default.Save();
		}

		private void toggleSliderComponent4_Load(object sender, EventArgs e)
		{
		}

		private void toggleSliderComponent5_Load(object sender, EventArgs e)
		{
		}

		private void toggleSliderComponent5_CheckChanged(object sender, EventArgs e)
		{
			monaco_changed = !monaco_changed;
			Settings.Default.monaco = toggleSliderComponent5.Checked;
			Settings.Default.Save();
		}
	}
}
