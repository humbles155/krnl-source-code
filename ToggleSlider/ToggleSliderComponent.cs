using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ToggleSlider
{
	public class ToggleSliderComponent : UserControl
	{
		private bool Checked_bool;

		private Color ToggleColorDisabled_Color = Color.Green;

		private Color Bar_Color = Color.Gray;

		private new string Text = "toggleSlider1";

		private int posx;

		private int posy;

		private bool init_ = true;

		private Color circlecolor_;

		private bool animating_;

		private Timer timer1 = new Timer();

		private IContainer components;

		public bool Checked
		{
			get
			{
				return Checked_bool;
			}
			set
			{
				Checked_bool = value;
				Invalidate();
			}
		}

		public Color ToggleCircleColor
		{
			get
			{
				return ToggleColorDisabled_Color;
			}
			set
			{
				ToggleColorDisabled_Color = value;
				Invalidate();
			}
		}

		public Color ToggleColorBar
		{
			get
			{
				return Bar_Color;
			}
			set
			{
				Bar_Color = value;
				Invalidate();
			}
		}

		public string ToggleBarText
		{
			get
			{
				return Text;
			}
			set
			{
				Text = value;
				Invalidate();
			}
		}

		public event EventHandler CheckChanged;

		public ToggleSliderComponent()
		{
			InitializeComponent();
			DoubleBuffered = true;
			base.Click += ToggleSlider_Click;
			timer1.Tick += Timer1_Tick;
			AutoSize = true;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			if (init_)
			{
				circlecolor_ = ToggleColorDisabled_Color;
			}
			pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			Size size = new Size(Convert.ToInt32(Font.SizeInPoints * 5f), Convert.ToInt32(Font.SizeInPoints * 5f));
			RoundedRect(Bar_Color, pevent.Graphics, new Rectangle(size.Width / 4, size.Height / 5 / 2, size.Width / 2, 3 * (size.Height / 5) / 2), 5);
			new LinearGradientBrush(new Point(size.Width / 4, size.Height / 5 / 2), new Point(size.Width / 2, size.Height / 2), ToggleColorDisabled_Color, ToggleColorDisabled_Color);
			if (!animating_)
			{
				if (!Checked_bool)
				{
					posx = 0;
				}
				else
				{
					posx = size.Width / 2;
				}
			}
			pevent.Graphics.FillEllipse(new SolidBrush(ToggleColorDisabled_Color), posx, posy, size.Width / 2, size.Height / 2);
			TextRenderer.DrawText(pevent.Graphics, ToggleBarText, Font, new Point(size.Width, size.Height / 10), ForeColor);
			SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
		}

		private void ToggleSlider_Click(object sender, EventArgs e)
		{
			Animate();
		}

		private void Animate()
		{
			timer1.Interval = 1;
			timer1.Start();
			animating_ = true;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			Size size = new Size(Convert.ToInt32(Font.SizeInPoints * 5f), Convert.ToInt32(Font.SizeInPoints * 5f));
			if (Checked_bool)
			{
				if (posx > 0)
				{
					posx -= 3;
					Invalidate();
					return;
				}
				Checked_bool = false;
				animating_ = false;
				if (this.CheckChanged != null)
				{
					this.CheckChanged(this, e);
				}
				timer1.Stop();
				return;
			}
			init_ = false;
			if (posx < size.Width / 2)
			{
				posx += 3;
				Invalidate();
				return;
			}
			Checked_bool = true;
			animating_ = false;
			if (this.CheckChanged != null)
			{
				this.CheckChanged(this, e);
			}
			timer1.Stop();
		}

		public static GraphicsPath RoundedRect(Color c, Graphics g, Rectangle bounds, int radius)
		{
			int num = radius * 2;
			Rectangle rect = new Rectangle(size: new Size(num, num), location: bounds.Location);
			GraphicsPath graphicsPath = new GraphicsPath();
			if (radius == 0)
			{
				graphicsPath.AddRectangle(bounds);
				return graphicsPath;
			}
			graphicsPath.AddArc(rect, 180f, 90f);
			rect.X = bounds.Right - num;
			graphicsPath.AddArc(rect, 270f, 90f);
			rect.Y = bounds.Bottom - num;
			graphicsPath.AddArc(rect, 0f, 90f);
			rect.X = bounds.Left;
			graphicsPath.AddArc(rect, 90f, 90f);
			g.FillPath(new SolidBrush(c), graphicsPath);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		private void ToggleSliderComponent_Load(object sender, EventArgs e)
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
			SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "ToggleSliderComponent";
			base.Size = new System.Drawing.Size(308, 52);
			base.Load += new System.EventHandler(ToggleSliderComponent_Load);
			ResumeLayout(false);
		}
	}
}
