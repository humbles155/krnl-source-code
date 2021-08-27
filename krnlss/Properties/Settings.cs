using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace krnlss.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default => defaultInstance;

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Environment.CurrentDirectory + \"\\\\scripts\"")]
		public string ScriptPath
		{
			get
			{
				return (string)this["ScriptPath"];
			}
			set
			{
				this["ScriptPath"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool autoinject
		{
			get
			{
				return (bool)this["autoinject"];
			}
			set
			{
				this["autoinject"] = value;
			}
		}

		[DefaultSettingValue("false")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool topmostchecked
		{
			get
			{
				return (bool)this["topmostchecked"];
			}
			set
			{
				this["topmostchecked"] = value;
			}
		}

		[UserScopedSetting]
		[DefaultSettingValue("true")]
		[DebuggerNonUserCode]
		public bool fadein_out_opacity
		{
			get
			{
				return (bool)this["fadein_out_opacity"];
			}
			set
			{
				this["fadein_out_opacity"] = value;
			}
		}

		[DefaultSettingValue("false")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool remove_crash_logs
		{
			get
			{
				return (bool)this["remove_crash_logs"];
			}
			set
			{
				this["remove_crash_logs"] = value;
			}
		}

		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string cachedkey
		{
			get
			{
				return (string)this["cachedkey"];
			}
			set
			{
				this["cachedkey"] = value;
			}
		}

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("false")]
		public bool monaco
		{
			get
			{
				return (bool)this["monaco"];
			}
			set
			{
				this["monaco"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public DateTime timer
		{
			get
			{
				if (this["timer"] != null)
				{
					return Convert.ToDateTime(this["timer"]);
				}
				return Convert.ToDateTime(DateTime.Now);
			}
			set
			{
				this["timer"] = value;
			}
		}
	}
}
