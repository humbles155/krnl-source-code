using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace krnlss
{
	public class Games : Form
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private List<Panel> listPanel = new List<Panel>();

		private int i;

		private IContainer components;

		private Panel panel1;

		private Button button1;

		private PictureBox pictureBox1;

		private Label label1;

		private PictureBox pictureBox2;

		private PictureBox pictureBox3;

		private PictureBox pictureBox4;

		private PictureBox pictureBox5;

		private PictureBox pictureBox6;

		private PictureBox pictureBox7;

		private PictureBox pictureBox8;

		private PictureBox pictureBox9;

		private PictureBox pictureBox10;

		private PictureBox pictureBox11;

		private PictureBox pictureBox12;

		private Button button2;

		private Button button3;

		private Panel panel2;

		private Panel panel3;

		private PictureBox pictureBox13;

		private PictureBox pictureBox14;

		private PictureBox pictureBox15;

		private PictureBox pictureBox16;

		private PictureBox pictureBox17;

		private PictureBox pictureBox18;

		private PictureBox pictureBox19;

		private PictureBox pictureBox20;

		private PictureBox pictureBox21;

		private PictureBox pictureBox22;

		private PictureBox pictureBox23;

		private PictureBox pictureBox24;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public Games()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Games_Load(object sender, EventArgs e)
		{
			panel2.Visible = false;
			panel3.Visible = false;
			listPanel.Add(panel2);
			listPanel.Add(panel3);
			listPanel[i].BringToFront();
			listPanel[i].Visible = true;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Jxnt Scripts", "Credits");
			krnl.Pipe("loadstring(game:HttpGet('https://system-exodus.com/scripts/ninjalegends/NinjaLegendsV2.lua', true))()");
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/rT3UCQRs', true))();");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/cE6kQe1G', true))();");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/J420Y71u', true))();");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                while wait(0.5) do\r\n                local stuff = workspace:getDescendants()\r\n                for i=1,#stuff do\r\n                if stuff[i].Name == 'Hitbox' then\r\n                if stuff[i].Parent.Name ~= game.Players.LocalPlayer.Name then\r\n                stuff[i].Massless = true\r\n                stuff[i].Size = Vector3.new (100,100,100)\r\n                stuff[i].Transparency = 0.5\r\n                end\r\n                end\r\n                end\r\n                end\r\n            ");
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                _G.ServerHop = false\r\n                _G.PercentageToHop = 25\r\n                _G.AutoEquipMask = false\r\n                _G.RepFarm = false\r\n                _G.AogiriFarm = false\r\n                _G.CCGFarm = false\r\n                _G.HumanFarm = false\r\n                _G.FarmAll = false\r\n                _G.PlayAsGhoul = false\r\n                _G.PlayAsCCG = false\r\n\r\n                loadstring(game:HttpGet(('https://pastebin.com/raw/x9She8BF'),true))()\r\n            ");
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                local player = game.Players.LocalPlayer\r\n                local library = loadstring(game:HttpGet('https://pastebin.com/raw/JsdM2jiP',true))()\r\n                library.options.underlinecolor = 'rainbow'\r\n\r\n                -- Ranch Tab\r\n                local Ranch = library:CreateWindow('Ranch')\r\n                Ranch: Section('- Ranch -')\r\n                local Upgrade = Ranch:Toggle('Auto Upgrade Ranch', { flag = 'RU'})\r\n                local EquipBest = Ranch:Toggle('Auto Equip Pets', { flag = 'EP'})\r\n\r\n                --Auto Upgrade\r\n                spawn(function()\r\n                while wait(.01) do\r\n                                    if Ranch.flags.RU then\r\n                                    game:GetService('ReplicatedStorage').RemoteFunctions.MainRemoteFunction:InvokeServer('UpgradeRanch', false)\r\n                end\r\n                end\r\n                end)\r\n\r\n                --Auto Equip\r\n                spawn(function()\r\n                while wait(.01) do\r\n                                    if Ranch.flags.EP then\r\n                                    game:GetService('ReplicatedStorage').RemoteFunctions.MainRemoteFunction:InvokeServer('EquipTopPets')\r\n                end\r\n                end\r\n                end)\r\n            ");
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/bCYBdgTD', true))();");
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/ecVs72us', true))()");
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/p2wJy279', true))()");
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/WBfWy8Md', true))()");
			MessageBox.Show("This script was created by Jxnt#9946!");
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/Rge4t3Sh', true))()");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (i < listPanel.Count - 1)
			{
				listPanel[i].Visible = false;
				listPanel[++i].BringToFront();
				listPanel[i].Visible = true;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (i > 0)
			{
				listPanel[i].Visible = false;
				listPanel[--i].BringToFront();
				listPanel[i].Visible = true;
			}
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(krnlss.Games));
			panel1 = new System.Windows.Forms.Panel();
			button3 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			button1 = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			pictureBox8 = new System.Windows.Forms.PictureBox();
			pictureBox9 = new System.Windows.Forms.PictureBox();
			pictureBox10 = new System.Windows.Forms.PictureBox();
			pictureBox11 = new System.Windows.Forms.PictureBox();
			pictureBox12 = new System.Windows.Forms.PictureBox();
			panel2 = new System.Windows.Forms.Panel();
			panel3 = new System.Windows.Forms.Panel();
			pictureBox13 = new System.Windows.Forms.PictureBox();
			pictureBox14 = new System.Windows.Forms.PictureBox();
			pictureBox15 = new System.Windows.Forms.PictureBox();
			pictureBox16 = new System.Windows.Forms.PictureBox();
			pictureBox17 = new System.Windows.Forms.PictureBox();
			pictureBox18 = new System.Windows.Forms.PictureBox();
			pictureBox19 = new System.Windows.Forms.PictureBox();
			pictureBox20 = new System.Windows.Forms.PictureBox();
			pictureBox21 = new System.Windows.Forms.PictureBox();
			pictureBox22 = new System.Windows.Forms.PictureBox();
			pictureBox23 = new System.Windows.Forms.PictureBox();
			pictureBox24 = new System.Windows.Forms.PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
			SuspendLayout();
			panel1.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(button1);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(575, 41);
			panel1.TabIndex = 2;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			button3.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button3.Font = new System.Drawing.Font("Corbel", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button3.ForeColor = System.Drawing.Color.White;
			button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
			button3.Location = new System.Drawing.Point(435, 0);
			button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(47, 41);
			button3.TabIndex = 6;
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button2.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button2.Font = new System.Drawing.Font("Corbel", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button2.ForeColor = System.Drawing.Color.White;
			button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
			button2.Location = new System.Drawing.Point(481, 0);
			button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(47, 41);
			button2.TabIndex = 5;
			button2.UseVisualStyleBackColor = false;
			button2.Click += new System.EventHandler(button2_Click);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(249, 9);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(69, 25);
			label1.TabIndex = 4;
			label1.Text = "Games";
			button1.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Corbel", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.Color.White;
			button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(528, 0);
			button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(47, 41);
			button1.TabIndex = 3;
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(1, 0);
			pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(133, 126);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			pictureBox1.MouseHover += new System.EventHandler(pictureBox1_MouseHover);
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(143, 0);
			pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(133, 126);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new System.Drawing.Point(284, 0);
			pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(133, 126);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			pictureBox3.Click += new System.EventHandler(pictureBox3_Click);
			pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new System.Drawing.Point(425, 0);
			pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(133, 126);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 6;
			pictureBox4.TabStop = false;
			pictureBox4.Click += new System.EventHandler(pictureBox4_Click);
			pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new System.Drawing.Point(1, 128);
			pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(133, 126);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox5.TabIndex = 7;
			pictureBox5.TabStop = false;
			pictureBox5.Click += new System.EventHandler(pictureBox5_Click);
			pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new System.Drawing.Point(1, 256);
			pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new System.Drawing.Size(133, 126);
			pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 8;
			pictureBox6.TabStop = false;
			pictureBox6.Click += new System.EventHandler(pictureBox6_Click);
			pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new System.Drawing.Point(143, 128);
			pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new System.Drawing.Size(133, 126);
			pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox7.TabIndex = 9;
			pictureBox7.TabStop = false;
			pictureBox7.Click += new System.EventHandler(pictureBox7_Click);
			pictureBox8.Image = (System.Drawing.Image)resources.GetObject("pictureBox8.Image");
			pictureBox8.Location = new System.Drawing.Point(425, 128);
			pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox8.Name = "pictureBox8";
			pictureBox8.Size = new System.Drawing.Size(133, 126);
			pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox8.TabIndex = 11;
			pictureBox8.TabStop = false;
			pictureBox8.Click += new System.EventHandler(pictureBox8_Click);
			pictureBox9.Image = (System.Drawing.Image)resources.GetObject("pictureBox9.Image");
			pictureBox9.Location = new System.Drawing.Point(284, 128);
			pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new System.Drawing.Size(133, 126);
			pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox9.TabIndex = 10;
			pictureBox9.TabStop = false;
			pictureBox9.Click += new System.EventHandler(pictureBox9_Click);
			pictureBox10.Image = (System.Drawing.Image)resources.GetObject("pictureBox10.Image");
			pictureBox10.Location = new System.Drawing.Point(143, 256);
			pictureBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox10.Name = "pictureBox10";
			pictureBox10.Size = new System.Drawing.Size(133, 126);
			pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox10.TabIndex = 12;
			pictureBox10.TabStop = false;
			pictureBox10.Click += new System.EventHandler(pictureBox10_Click);
			pictureBox11.Image = (System.Drawing.Image)resources.GetObject("pictureBox11.Image");
			pictureBox11.Location = new System.Drawing.Point(425, 256);
			pictureBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox11.Name = "pictureBox11";
			pictureBox11.Size = new System.Drawing.Size(133, 126);
			pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox11.TabIndex = 14;
			pictureBox11.TabStop = false;
			pictureBox11.Click += new System.EventHandler(pictureBox11_Click);
			pictureBox12.Image = (System.Drawing.Image)resources.GetObject("pictureBox12.Image");
			pictureBox12.Location = new System.Drawing.Point(284, 256);
			pictureBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox12.Name = "pictureBox12";
			pictureBox12.Size = new System.Drawing.Size(133, 126);
			pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox12.TabIndex = 13;
			pictureBox12.TabStop = false;
			pictureBox12.Click += new System.EventHandler(pictureBox12_Click);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(pictureBox6);
			panel2.Controls.Add(pictureBox10);
			panel2.Controls.Add(pictureBox12);
			panel2.Controls.Add(pictureBox11);
			panel2.Controls.Add(pictureBox8);
			panel2.Controls.Add(pictureBox4);
			panel2.Controls.Add(pictureBox3);
			panel2.Controls.Add(pictureBox9);
			panel2.Controls.Add(pictureBox2);
			panel2.Controls.Add(pictureBox7);
			panel2.Controls.Add(pictureBox5);
			panel2.Location = new System.Drawing.Point(8, 46);
			panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			panel2.Name = "panel2";
			panel2.Size = new System.Drawing.Size(559, 382);
			panel2.TabIndex = 15;
			panel3.Controls.Add(pictureBox13);
			panel3.Controls.Add(pictureBox14);
			panel3.Controls.Add(pictureBox15);
			panel3.Controls.Add(pictureBox16);
			panel3.Controls.Add(pictureBox17);
			panel3.Controls.Add(pictureBox18);
			panel3.Controls.Add(pictureBox19);
			panel3.Controls.Add(pictureBox20);
			panel3.Controls.Add(pictureBox21);
			panel3.Controls.Add(pictureBox22);
			panel3.Controls.Add(pictureBox23);
			panel3.Controls.Add(pictureBox24);
			panel3.Location = new System.Drawing.Point(8, 46);
			panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			panel3.Name = "panel3";
			panel3.Size = new System.Drawing.Size(559, 382);
			panel3.TabIndex = 16;
			pictureBox13.Image = (System.Drawing.Image)resources.GetObject("pictureBox13.Image");
			pictureBox13.Location = new System.Drawing.Point(1, 0);
			pictureBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox13.Name = "pictureBox13";
			pictureBox13.Size = new System.Drawing.Size(133, 126);
			pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox13.TabIndex = 3;
			pictureBox13.TabStop = false;
			pictureBox14.Image = (System.Drawing.Image)resources.GetObject("pictureBox14.Image");
			pictureBox14.Location = new System.Drawing.Point(1, 256);
			pictureBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox14.Name = "pictureBox14";
			pictureBox14.Size = new System.Drawing.Size(133, 126);
			pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox14.TabIndex = 8;
			pictureBox14.TabStop = false;
			pictureBox15.Image = (System.Drawing.Image)resources.GetObject("pictureBox15.Image");
			pictureBox15.Location = new System.Drawing.Point(143, 256);
			pictureBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox15.Name = "pictureBox15";
			pictureBox15.Size = new System.Drawing.Size(133, 126);
			pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox15.TabIndex = 12;
			pictureBox15.TabStop = false;
			pictureBox16.Image = (System.Drawing.Image)resources.GetObject("pictureBox16.Image");
			pictureBox16.Location = new System.Drawing.Point(284, 256);
			pictureBox16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox16.Name = "pictureBox16";
			pictureBox16.Size = new System.Drawing.Size(133, 126);
			pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox16.TabIndex = 13;
			pictureBox16.TabStop = false;
			pictureBox17.Image = (System.Drawing.Image)resources.GetObject("pictureBox17.Image");
			pictureBox17.Location = new System.Drawing.Point(425, 256);
			pictureBox17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox17.Name = "pictureBox17";
			pictureBox17.Size = new System.Drawing.Size(133, 126);
			pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox17.TabIndex = 14;
			pictureBox17.TabStop = false;
			pictureBox18.Image = (System.Drawing.Image)resources.GetObject("pictureBox18.Image");
			pictureBox18.Location = new System.Drawing.Point(425, 128);
			pictureBox18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox18.Name = "pictureBox18";
			pictureBox18.Size = new System.Drawing.Size(133, 126);
			pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox18.TabIndex = 11;
			pictureBox18.TabStop = false;
			pictureBox19.Image = (System.Drawing.Image)resources.GetObject("pictureBox19.Image");
			pictureBox19.Location = new System.Drawing.Point(425, 0);
			pictureBox19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox19.Name = "pictureBox19";
			pictureBox19.Size = new System.Drawing.Size(133, 126);
			pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox19.TabIndex = 6;
			pictureBox19.TabStop = false;
			pictureBox20.Image = (System.Drawing.Image)resources.GetObject("pictureBox20.Image");
			pictureBox20.Location = new System.Drawing.Point(284, 0);
			pictureBox20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox20.Name = "pictureBox20";
			pictureBox20.Size = new System.Drawing.Size(133, 126);
			pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox20.TabIndex = 5;
			pictureBox20.TabStop = false;
			pictureBox21.Image = (System.Drawing.Image)resources.GetObject("pictureBox21.Image");
			pictureBox21.Location = new System.Drawing.Point(284, 128);
			pictureBox21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox21.Name = "pictureBox21";
			pictureBox21.Size = new System.Drawing.Size(133, 126);
			pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox21.TabIndex = 10;
			pictureBox21.TabStop = false;
			pictureBox22.Image = (System.Drawing.Image)resources.GetObject("pictureBox22.Image");
			pictureBox22.Location = new System.Drawing.Point(143, 0);
			pictureBox22.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox22.Name = "pictureBox22";
			pictureBox22.Size = new System.Drawing.Size(133, 126);
			pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox22.TabIndex = 4;
			pictureBox22.TabStop = false;
			pictureBox23.Image = (System.Drawing.Image)resources.GetObject("pictureBox23.Image");
			pictureBox23.Location = new System.Drawing.Point(143, 128);
			pictureBox23.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox23.Name = "pictureBox23";
			pictureBox23.Size = new System.Drawing.Size(133, 126);
			pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox23.TabIndex = 9;
			pictureBox23.TabStop = false;
			pictureBox24.Image = (System.Drawing.Image)resources.GetObject("pictureBox24.Image");
			pictureBox24.Location = new System.Drawing.Point(1, 128);
			pictureBox24.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			pictureBox24.Name = "pictureBox24";
			pictureBox24.Size = new System.Drawing.Size(133, 126);
			pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox24.TabIndex = 7;
			pictureBox24.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
			base.ClientSize = new System.Drawing.Size(575, 434);
			base.Controls.Add(panel3);
			base.Controls.Add(panel1);
			base.Controls.Add(panel2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "Games";
			Text = "Games";
			base.TopMost = true;
			base.Load += new System.EventHandler(Games_Load);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
			ResumeLayout(false);
		}
	}
}
