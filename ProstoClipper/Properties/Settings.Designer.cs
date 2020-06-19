using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ProstoClipper.Properties
{
	// Token: 0x0200002B RID: 43
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00003B94 File Offset: 0x00001D94
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00003B9B File Offset: 0x00001D9B
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00003BAD File Offset: 0x00001DAD
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Login
		{
			get
			{
				return (string)Settings.smethod_0(this, "Login");
			}
			set
			{
				Settings.smethod_1(this, "Login", value);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00003BBB File Offset: 0x00001DBB
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003BCD File Offset: 0x00001DCD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Pass
		{
			get
			{
				return (string)Settings.smethod_0(this, "Pass");
			}
			set
			{
				Settings.smethod_1(this, "Pass", value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00003BDB File Offset: 0x00001DDB
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003BED File Offset: 0x00001DED
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		public bool Pos
		{
			get
			{
				return (bool)Settings.smethod_0(this, "Pos");
			}
			set
			{
				Settings.smethod_1(this, "Pos", value);
			}
		}

		// Token: 0x0400012C RID: 300
		private static Settings settings_0 = (Settings)Settings.smethod_2(new Settings());
	}
}
