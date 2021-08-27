using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using krnlss;
using ScintillaNET;

namespace Controls
{
	public class CustomTabControl : TabControl
	{
		private readonly StringFormat CenterSringFormat = new StringFormat
		{
			Alignment = StringAlignment.Near,
			LineAlignment = StringAlignment.Center
		};

		private Color activeColor = Color.FromArgb(36, 36, 36);

		private Color backTabColor = Color.FromArgb(0, 0, 0);

		private Color borderColor = Color.FromArgb(30, 30, 30);

		private Color closingButtonColor = Color.WhiteSmoke;

		private string closingMessage;

		private Color headerColor = Color.FromArgb(45, 45, 48);

		private Color horizLineColor = Color.FromArgb(36, 36, 36);

		private TabPage predraggedTab;

		public TabPage contextTab;

		private Color textColor = Color.FromArgb(255, 255, 255);

		public Color selectedTextColor = Color.FromArgb(255, 255, 255);

		public static krnl Form1;

		private int count = 1;

		public bool ShowClosingButton { get; set; }

		[Category("Colors")]
		[Description("The color of the selected page")]
		[Browsable(true)]
		public Color ActiveColor
		{
			get
			{
				return activeColor;
			}
			set
			{
				activeColor = value;
			}
		}

		[Description("The color of the background of the tab")]
		[Browsable(true)]
		[Category("Colors")]
		public Color BackTabColor
		{
			get
			{
				return backTabColor;
			}
			set
			{
				backTabColor = value;
			}
		}

		[Browsable(true)]
		[Description("The color of the border of the control")]
		[Category("Colors")]
		public Color BorderColor
		{
			get
			{
				return borderColor;
			}
			set
			{
				borderColor = value;
			}
		}

		[Browsable(true)]
		[Description("The color of the closing button")]
		[Category("Colors")]
		public Color ClosingButtonColor
		{
			get
			{
				return closingButtonColor;
			}
			set
			{
				closingButtonColor = value;
			}
		}

		[Browsable(true)]
		[Description("The message that will be shown before closing.")]
		[Category("Options")]
		public string ClosingMessage
		{
			get
			{
				return closingMessage;
			}
			set
			{
				closingMessage = value;
			}
		}

		[Browsable(true)]
		[Description("The color of the header.")]
		[Category("Colors")]
		public Color HeaderColor
		{
			get
			{
				return headerColor;
			}
			set
			{
				headerColor = value;
			}
		}

		[Description("The color of the horizontal line which is located under the headers of the pages.")]
		[Browsable(true)]
		[Category("Colors")]
		public Color HorizontalLineColor
		{
			get
			{
				return horizLineColor;
			}
			set
			{
				horizLineColor = value;
			}
		}

		[Browsable(true)]
		[Category("Options")]
		[Description("Show a Yes/No message before closing?")]
		public bool ShowClosingMessage { get; set; }

		[Category("Colors")]
		[Description("The color of the title of the page")]
		[Browsable(true)]
		public Color SelectedTextColor
		{
			get
			{
				return selectedTextColor;
			}
			set
			{
				selectedTextColor = value;
			}
		}

		[Description("The color of the title of the page")]
		[Category("Colors")]
		[Browsable(true)]
		public Color TextColor
		{
			get
			{
				return textColor;
			}
			set
			{
				textColor = value;
			}
		}

		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		public CustomTabControl()
		{
			SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			DoubleBuffered = true;
			base.SizeMode = TabSizeMode.Normal;
			base.ItemSize = new Size(240, 16);
			AllowDrop = true;
			base.Selecting += TabChanging;
		}

		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Alignment = TabAlignment.Top;
			SendMessage(base.Handle, 4913, IntPtr.Zero, (IntPtr)16);
		}

		protected override void OnDragOver(DragEventArgs drgevent)
		{
			if (predraggedTab != null)
			{
				TabPage tabPage = (TabPage)drgevent.Data.GetData(typeof(TabPage));
				TabPage pointedTab = GetPointedTab();
				int num = base.TabPages.IndexOf(tabPage);
				if (tabPage != null && num != base.TabCount)
				{
					TabPage tabPage2 = base.TabPages[base.TabCount - 1];
					if (tabPage != tabPage2 && tabPage == predraggedTab && pointedTab != null)
					{
						drgevent.Effect = DragDropEffects.Move;
						if (pointedTab != tabPage2 && pointedTab != tabPage)
						{
							ReplaceTabPages(tabPage, pointedTab);
						}
					}
				}
			}
			base.OnDragOver(drgevent);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			predraggedTab = GetPointedTab();
			Point location = e.Location;
			for (int i = 0; i < base.TabCount; i++)
			{
				dynamic val = GetTabRect(i);
				val.Offset(val.Width - 15, 2);
				val.Width = 10;
				val.Height = 10;
				dynamic val2 = !val.Contains(location);
				if (val2 || e.Button != MouseButtons.Left)
				{
					continue;
				}
				if (i != base.TabCount - 1)
				{
					predraggedTab = null;
					TabPage tabPage = base.TabPages[i];
					if (!ShowClosingMessage)
					{
						if (base.TabCount == 2)
						{
							DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear this tab?\nThe reason why you see this prompt is because there is only one tab currently opened.", "SINGLE TAB DETECTED", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
							if (dialogResult == DialogResult.Yes)
							{
								tabPage.Text = "Untitled.lua";
								((Control)(object)GetWorkingTextEditor()).Text = "";
							}
							return;
						}
						if (tabPage.Controls.Count > 0)
						{
							tabPage.Controls[0].Dispose();
						}
						base.TabPages.RemoveAt(i);
						break;
					}
					CloseTab(tabPage);
				}
				else if (GetTabRect(base.TabCount - 1).Contains(e.Location))
				{
					AddEvent();
					predraggedTab = null;
					break;
				}
			}
			base.OnMouseDown(e);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && predraggedTab != null)
			{
				DoDragDrop(predraggedTab, DragDropEffects.Move);
			}
			base.OnMouseMove(e);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			predraggedTab = null;
			contextTab = null;
			if (e.Button == MouseButtons.Right)
			{
				Form1.TabContextMenu.Show(Cursor.Position);
				contextTab = GetPointedTab();
			}
			base.OnMouseUp(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(headerColor);
			try
			{
				base.SelectedTab.BackColor = backTabColor;
			}
			catch
			{
			}
			try
			{
				base.SelectedTab.BorderStyle = BorderStyle.None;
			}
			catch
			{
			}
			for (int i = 0; i <= base.TabCount - 1; i++)
			{
				TabPage tabPage = base.TabPages[i];
				tabPage.Width = (int)e.Graphics.MeasureString(tabPage.Text, Font).Width + 16;
				Rectangle rectangle = new Rectangle(new Point(GetTabRect(i).Location.X + 2, GetTabRect(i).Location.Y), new Size(GetTabRect(i).Width, GetTabRect(i).Height));
				Rectangle rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height));
				Brush brush = new SolidBrush(closingButtonColor);
				if (i != base.SelectedIndex)
				{
					graphics.DrawString(tabPage.Text, Font, new SolidBrush(textColor), rectangle2, CenterSringFormat);
				}
				else
				{
					graphics.FillRectangle(new SolidBrush(headerColor), rectangle2);
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(36, 36, 36)), new Rectangle(rectangle.X - 5, rectangle.Y - 3, rectangle.Width, rectangle.Height + 5));
					graphics.DrawString(tabPage.Text, Font, new SolidBrush(selectedTextColor), rectangle2, CenterSringFormat);
				}
				if (i != base.TabCount - 1)
				{
					if (ShowClosingButton)
					{
						e.Graphics.DrawString("X", Font, brush, rectangle2.Right - 17, 3f);
					}
				}
				else
				{
					using Font font = new Font(SystemFonts.DefaultFont.FontFamily, 14f, FontStyle.Bold);
					e.Graphics.DrawString("+", font, brush, rectangle2.Right - 22, rectangle2.Top / 2 - 4);
				}
				brush.Dispose();
			}
			graphics.DrawLine(new Pen(Color.FromArgb(36, 36, 36), 5f), new Point(0, 19), new Point(base.Width, 19));
			graphics.FillRectangle(new SolidBrush(backTabColor), new Rectangle(0, 20, base.Width, base.Height - 20));
			graphics.DrawRectangle(new Pen(borderColor, 2f), new Rectangle(0, 0, base.Width, base.Height));
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		}

		private TabPage GetPointedTab()
		{
			int num = 0;
			while (true)
			{
				if (num <= base.TabPages.Count - 1)
				{
					if (GetTabRect(num).Contains(PointToClient(Cursor.Position)))
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return base.TabPages[num];
		}

		private void ReplaceTabPages(TabPage Source, TabPage Destination)
		{
			dynamic val = base.TabPages.IndexOf(Source);
			dynamic val2 = base.TabPages.IndexOf(Destination);
			dynamic val3 = val == -1;
			if ((!(val3 ? true : false) || 1 == 0) && (!((val3 | (val2 == -1)) ? true : false) || 1 == 0))
			{
				base.TabPages[val2] = Source;
				base.TabPages[val] = Destination;
				if (base.SelectedIndex == val)
				{
					base.SelectedIndex = val2;
				}
				else if (base.SelectedIndex == val2)
				{
					base.SelectedIndex = val;
				}
				Refresh();
			}
		}

		public void CloseTab(TabPage tab)
		{
			Control control = tab.Controls[0];
			Scintilla val = (Scintilla)(object)((control is Scintilla) ? control : null);
			int num = base.TabPages.IndexOf(tab);
			if (num == 0 && base.TabCount <= 2)
			{
				_ = base.TabPages[0];
				tab.Text = "Untitled.lua";
				((Control)(object)val).Text = "";
				((Control)(object)val).Refresh();
			}
			else
			{
				base.TabPages.RemoveAt(num);
				count--;
			}
		}

		private void DragOverEnterHandler(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void DragDropHandler(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, autoConvert: false);
			string[] array2 = array;
			string[] array3 = array2;
			foreach (string path in array3)
			{
				AddEvent(Path.GetFileNameWithoutExtension(path), File.ReadAllText(path));
			}
		}

		public Scintilla NewEditor(string script)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			Scintilla val = new Scintilla();
			((Control)(object)val).AllowDrop = true;
			val.set_AutomaticFold((AutomaticFold)7);
			((Control)(object)val).BackColor = Color.Black;
			val.set_BorderStyle(BorderStyle.None);
			val.set_Lexer((Lexer)15);
			((Control)(object)val).Name = "scintilla";
			((Control)(object)val).Dock = DockStyle.Fill;
			val.set_ScrollWidth(1);
			((Control)(object)val).TabIndex = 0;
			val.get_Styles().get_Item(32).set_Size(15);
			val.get_Styles().get_Item(32).set_Size(15);
			val.get_Styles().get_Item(32).set_Size(15);
			val.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
			val.SetSelectionForeColor(true, Color.Black);
			val.get_Margins().get_Item(1).set_Width(0);
			val.StyleResetDefault();
			val.get_Styles().get_Item(32).set_Font("Consolas");
			val.get_Styles().get_Item(32).set_Size(10);
			val.get_Styles().get_Item(32).set_BackColor(Color.FromArgb(40, 40, 40));
			val.get_Styles().get_Item(32).set_ForeColor(Color.White);
			val.StyleClearAll();
			val.get_Styles().get_Item(11).set_ForeColor(Color.White);
			val.get_Styles().get_Item(1).set_ForeColor(Color.FromArgb(79, 81, 98));
			val.get_Styles().get_Item(2).set_ForeColor(Color.FromArgb(79, 81, 98));
			val.get_Styles().get_Item(3).set_ForeColor(Color.FromArgb(58, 64, 34));
			val.get_Styles().get_Item(4).set_ForeColor(Color.FromArgb(165, 112, 255));
			val.get_Styles().get_Item(6).set_ForeColor(Color.FromArgb(255, 192, 115));
			val.get_Styles().get_Item(7).set_ForeColor(Color.FromArgb(255, 192, 115));
			val.get_Styles().get_Item(8).set_ForeColor(Color.FromArgb(255, 192, 115));
			val.get_Styles().get_Item(9).set_ForeColor(Color.FromArgb(138, 175, 238));
			val.get_Styles().get_Item(10).set_ForeColor(Color.White);
			val.get_Styles().get_Item(5).set_ForeColor(Color.FromArgb(255, 60, 122));
			val.get_Styles().get_Item(13).set_ForeColor(Color.FromArgb(89, 255, 172));
			val.get_Styles().get_Item(13).set_Bold(true);
			val.get_Styles().get_Item(14).set_ForeColor(Color.FromArgb(89, 255, 172));
			val.get_Styles().get_Item(14).set_Bold(true);
			val.set_Lexer((Lexer)15);
			val.SetProperty("fold", "1");
			val.SetProperty("fold.compact", "1");
			val.get_Margins().get_Item(0).set_Width(15);
			val.get_Margins().get_Item(0).set_Type((MarginType)1);
			val.get_Margins().get_Item(1).set_Type((MarginType)0);
			val.get_Margins().get_Item(1).set_Mask(4261412864u);
			val.get_Margins().get_Item(1).set_Sensitive(true);
			val.get_Margins().get_Item(1).set_Width(8);
			for (int i = 25; i <= 31; i++)
			{
				val.get_Markers().get_Item(i).SetForeColor(Color.White);
				val.get_Markers().get_Item(i).SetBackColor(Color.White);
			}
			val.get_Markers().get_Item(30).set_Symbol((MarkerSymbol)12);
			val.get_Markers().get_Item(31).set_Symbol((MarkerSymbol)14);
			val.get_Markers().get_Item(25).set_Symbol((MarkerSymbol)13);
			val.get_Markers().get_Item(27).set_Symbol((MarkerSymbol)11);
			val.get_Markers().get_Item(26).set_Symbol((MarkerSymbol)15);
			val.get_Markers().get_Item(29).set_Symbol((MarkerSymbol)9);
			val.get_Markers().get_Item(28).set_Symbol((MarkerSymbol)10);
			val.get_Styles().get_Item(33).set_BackColor(Color.FromArgb(40, 40, 40));
			val.set_AutomaticFold((AutomaticFold)7);
			val.SetFoldMarginColor(true, Color.FromArgb(40, 40, 40));
			val.SetFoldMarginHighlightColor(true, Color.FromArgb(40, 40, 40));
			val.SetKeywords(0, "and break do else elseif end false for function if in local nil not or repeat return then true until while continue");
			val.SetKeywords(1, "warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle CFrame.new gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
			val.SetKeywords(2, "getrawmetatable loadstring getnamecallmethod setreadonly islclosure getgenv unlockModule lockModule mousemoverel debug.getupvalue debug.getupvalues debug.setupvalue debug.getmetatable debug.getregistry setclipboard setthreadcontext getthreadcontext checkcaller getgc debug.getconstant getrenv getreg ");
			val.set_ScrollWidth(1);
			val.set_ScrollWidthTracking(true);
			val.set_CaretForeColor(Color.White);
			((Control)(object)val).BackColor = Color.White;
			val.set_BorderStyle(BorderStyle.None);
			((Control)(object)val).TextChanged += scintilla1_TextChanged;
			val.set_WrapIndentMode((WrapIndentMode)2);
			val.set_WrapVisualFlagLocation((WrapVisualFlagLocation)1);
			val.set_BorderStyle(BorderStyle.None);
			((Control)(object)val).Text = script;
			return val;
		}

		private void scintilla1_TextChanged(object sender, EventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			Scintilla val = (Scintilla)sender;
			int length = val.get_Lines().get_Count().ToString()
				.Length;
			val.get_Margins().get_Item(0).set_Width(val.TextWidth(10, new string('9', length + 1)) + 2);
		}

		public void addnewtab()
		{
			int index = base.TabCount - 1;
			base.TabPages.Insert(index, $"Script{base.TabCount}.lua");
			base.TabPages[index].Controls.Add((Control)(object)NewEditor(""));
			base.SelectedIndex = index;
		}

		public Scintilla GetWorkingTextEditor()
		{
			if (base.SelectedTab.Controls.Count == 0)
			{
				return null;
			}
			if (base.SelectedTab == null)
			{
				addnewtab();
				Control control = base.SelectedTab.Controls[0];
				return (Scintilla)(object)((control is Scintilla) ? control : null);
			}
			Control control2 = base.SelectedTab.Controls[0];
			return (Scintilla)(object)((control2 is Scintilla) ? control2 : null);
		}

		public void AddEvent(string name = "Script.lua", string content = "")
		{
			if (string.IsNullOrEmpty(((Control)(object)GetWorkingTextEditor()).Text) && !string.IsNullOrEmpty(content))
			{
				addnewtab();
				base.SelectedTab.Text = "Script " + count + ".lua";
				base.SelectedTab.Controls[0].Text = content;
				base.SelectedTab.Controls[0].Refresh();
			}
			else
			{
				addnewtab();
				if (name.Contains("Script" + count + ".lua"))
				{
					base.SelectedTab.Text = "Script " + count + ".lua";
				}
			}
			count++;
		}

		public void TabChanging(object sender, TabControlCancelEventArgs e)
		{
			if (e.TabPageIndex == base.TabCount - 1)
			{
				e.Cancel = true;
			}
		}

		public string OpenSaveDialog(TabPage tab, string text)
		{
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.FileName = tab.Text;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog.FileName, text);
				return new FileInfo(saveFileDialog.FileName).Name;
			}
			return tab.Text;
		}

		public void RenameTab(string text)
		{
		}

		public bool OpenFileDialog(TabPage tab)
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				((Control)(object)GetWorkingTextEditor()).Text = File.ReadAllText(openFileDialog.FileName);
				tab.Text = Path.GetFileName(openFileDialog.FileName);
				return true;
			}
			return false;
		}
	}
}
