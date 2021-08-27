using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace krnlss
{
	public class About : Form
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private IContainer components;

		private Button button1;

		private Panel panel1;

		private PictureBox pictureBox1;

		private Label label1;

		private Label label2;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private Label label7;

		private Label label8;

		private Label label10;

		private Label label11;

		private Label label9;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public About()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void panel1_Move(object sender, EventArgs e)
		{
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(base.Handle, 161, 2, 0);
			}
		}

		private void About_Load(object sender, EventArgs e)
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(krnlss.About));
			button1 = new System.Windows.Forms.Button();
			panel1 = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			button1.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Font = new System.Drawing.Font("Corbel", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			button1.ForeColor = System.Drawing.Color.White;
			button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(285, 0);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(35, 33);
			button1.TabIndex = 3;
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(button1_Click);
			panel1.BackColor = System.Drawing.Color.FromArgb(29, 29, 29);
			panel1.Controls.Add(button1);
			panel1.Dock = System.Windows.Forms.DockStyle.Top;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(320, 33);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(panel1_MouseMove);
			panel1.Move += new System.EventHandler(panel1_Move);
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(-64, -21);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(270, 237);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(140, 59);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(168, 17);
			label1.TabIndex = 3;
			label1.Text = "UI Design and Components";
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.DarkGray;
			label2.Location = new System.Drawing.Point(140, 78);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(25, 17);
			label2.TabIndex = 4;
			label2.Text = "Iris";
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.DarkGray;
			label3.Location = new System.Drawing.Point(164, 78);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(51, 17);
			label3.TabIndex = 5;
			label3.Text = "Littensy";
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.DarkGray;
			label4.Location = new System.Drawing.Point(140, 116);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(54, 17);
			label4.TabIndex = 7;
			label4.Text = "Ice Bear";
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.White;
			label5.Location = new System.Drawing.Point(140, 97);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(111, 17);
			label5.TabIndex = 6;
			label5.Text = "Exploit Developer";
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.DarkGray;
			label6.Location = new System.Drawing.Point(230, 154);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(72, 17);
			label6.TabIndex = 10;
			label6.Text = "KowalskiFX";
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.Color.DarkGray;
			label7.Location = new System.Drawing.Point(140, 154);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(75, 17);
			label7.TabIndex = 9;
			label7.Text = "Customality";
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label8.ForeColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(140, 135);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(49, 17);
			label8.TabIndex = 8;
			label8.Text = "Credits";
			label9.AutoSize = true;
			label9.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label9.ForeColor = System.Drawing.Color.DarkGray;
			label9.Location = new System.Drawing.Point(212, 78);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(24, 17);
			label9.TabIndex = 11;
			label9.Text = "XV";
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label10.ForeColor = System.Drawing.Color.DarkGray;
			label10.Location = new System.Drawing.Point(234, 78);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(35, 17);
			label10.TabIndex = 11;
			label10.Text = "0x00";
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label11.ForeColor = System.Drawing.Color.DarkGray;
			label11.Location = new System.Drawing.Point(268, 78);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(34, 17);
			label11.TabIndex = 11;
			label11.Text = "King";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
			base.ClientSize = new System.Drawing.Size(320, 191);
			base.Controls.Add(label11);
			base.Controls.Add(label10);
			base.Controls.Add(label9);
			base.Controls.Add(label6);
			base.Controls.Add(label7);
			base.Controls.Add(label8);
			base.Controls.Add(label4);
			base.Controls.Add(label5);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.Controls.Add(panel1);
			base.Controls.Add(pictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "About";
			Text = "About";
			base.TopMost = true;
			base.Load += new System.EventHandler(About_Load);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
