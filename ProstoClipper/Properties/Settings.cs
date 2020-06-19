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
		// Token: 0x06000472 RID: 1138 RVA: 0x00003C1E File Offset: 0x00001E1E
		static object smethod_0(SettingsBase settingsBase_0, string string_0)
		{
			return settingsBase_0[string_0];
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00003C27 File Offset: 0x00001E27
		static void smethod_1(SettingsBase settingsBase_0, string string_0, object object_0)
		{
			settingsBase_0[string_0] = object_0;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00003C31 File Offset: 0x00001E31
		static SettingsBase smethod_2(SettingsBase settingsBase_0)
		{
			return SettingsBase.Synchronized(settingsBase_0);
		}
	}
}
