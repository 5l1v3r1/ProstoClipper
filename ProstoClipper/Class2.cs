using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200002A RID: 42
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Class2
{
	// Token: 0x0600045E RID: 1118 RVA: 0x00002109 File Offset: 0x00000309
	internal Class2()
	{
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600045F RID: 1119 RVA: 0x00003AF4 File Offset: 0x00001CF4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class2.resourceManager_0 == null)
			{
				Class2.resourceManager_0 = Class2.smethod_2("-%f\"t<5hHMKg>:}r\\[^'UCap0", Class2.smethod_1(Class2.smethod_0(typeof(Class2).TypeHandle)));
			}
			return Class2.resourceManager_0;
		}
	}

	// Token: 0x17000064 RID: 100
	// (set) Token: 0x06000460 RID: 1120 RVA: 0x00003B20 File Offset: 0x00001D20
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		set
		{
			Class2.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000461 RID: 1121 RVA: 0x00003B28 File Offset: 0x00001D28
	internal static string String_0
	{
		get
		{
			return Class2.smethod_3(Class2.ResourceManager_0, "config", Class2.cultureInfo_0);
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000462 RID: 1122 RVA: 0x00003B3E File Offset: 0x00001D3E
	internal static byte[] Byte_0
	{
		get
		{
			return (byte[])Class2.smethod_4(Class2.ResourceManager_0, "ConfuserEx", Class2.cultureInfo_0);
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000463 RID: 1123 RVA: 0x00003B59 File Offset: 0x00001D59
	internal static string String_1
	{
		get
		{
			return Class2.smethod_3(Class2.ResourceManager_0, "Stub", Class2.cultureInfo_0);
		}
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00002068 File Offset: 0x00000268
	static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00003B6F File Offset: 0x00001D6F
	static Assembly smethod_1(Type type_0)
	{
		return type_0.Assembly;
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00003B77 File Offset: 0x00001D77
	static ResourceManager smethod_2(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00003B80 File Offset: 0x00001D80
	static string smethod_3(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetString(string_0, cultureInfo_1);
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00003B8A File Offset: 0x00001D8A
	static object smethod_4(ResourceManager resourceManager_1, string string_0, CultureInfo cultureInfo_1)
	{
		return resourceManager_1.GetObject(string_0, cultureInfo_1);
	}

	// Token: 0x0400012A RID: 298
	private static ResourceManager resourceManager_0;

	// Token: 0x0400012B RID: 299
	private static CultureInfo cultureInfo_0;
}
