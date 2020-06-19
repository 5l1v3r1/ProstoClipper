using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200002C RID: 44
[CompilerGenerated]
internal static class Class3
{
	// Token: 0x06000475 RID: 1141 RVA: 0x00003C39 File Offset: 0x00001E39
	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return Class3.smethod_9(cultureInfo_0);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00010650 File Offset: 0x0000E850
	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		foreach (Assembly assembly in Class3.smethod_11(Class3.smethod_10()))
		{
			AssemblyName assemblyName_ = Class3.smethod_12(assembly);
			if (Class3.smethod_14(Class3.smethod_13(assemblyName_), Class3.smethod_13(assemblyName_0), StringComparison.InvariantCultureIgnoreCase) && Class3.smethod_14(Class3.smethod_0(Class3.smethod_15(assemblyName_)), Class3.smethod_0(Class3.smethod_15(assemblyName_0)), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x000106B8 File Offset: 0x0000E8B8
	private static void smethod_2(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int int_;
		while ((int_ = Class3.smethod_17(stream_0, array, 0, array.Length)) != 0)
		{
			Class3.smethod_16(stream_1, array, 0, int_);
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x000106EC File Offset: 0x0000E8EC
	private static Stream smethod_3(string string_0)
	{
		Assembly assembly_ = Class3.smethod_18();
		if (Class3.smethod_19(string_0, ".compressed"))
		{
			Stream stream = Class3.smethod_20(assembly_, string_0);
			Stream result;
			try
			{
				DeflateStream deflateStream = Class3.smethod_21(stream, CompressionMode.Decompress);
				try
				{
					MemoryStream memoryStream = Class3.smethod_22();
					Class3.smethod_2(deflateStream, memoryStream);
					Class3.smethod_23(memoryStream, 0L);
					result = memoryStream;
				}
				finally
				{
					if (deflateStream != null)
					{
						Class3.smethod_24(deflateStream);
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					Class3.smethod_24(stream);
				}
			}
			return result;
		}
		return Class3.smethod_20(assembly_, string_0);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00010778 File Offset: 0x0000E978
	private static Stream smethod_4(Dictionary<string, string> dictionary_3, string string_0)
	{
		string string_;
		if (dictionary_3.TryGetValue(string_0, out string_))
		{
			return Class3.smethod_3(string_);
		}
		return null;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00010798 File Offset: 0x0000E998
	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[Class3.smethod_25(stream_0)];
		Class3.smethod_17(stream_0, array, 0, array.Length);
		return array;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000107C0 File Offset: 0x0000E9C0
	private static Assembly smethod_6(Dictionary<string, string> dictionary_3, Dictionary<string, string> dictionary_4, AssemblyName assemblyName_0)
	{
		string text = Class3.smethod_26(Class3.smethod_13(assemblyName_0));
		if (Class3.smethod_15(assemblyName_0) != null && !Class3.smethod_27(Class3.smethod_9(Class3.smethod_15(assemblyName_0))))
		{
			text = Class3.smethod_28(Class3.smethod_9(Class3.smethod_15(assemblyName_0)), ".", text);
		}
		Stream stream = Class3.smethod_4(dictionary_3, text);
		byte[] byte_;
		try
		{
			if (stream == null)
			{
				return null;
			}
			byte_ = Class3.smethod_5(stream);
		}
		finally
		{
			if (stream != null)
			{
				Class3.smethod_24(stream);
			}
		}
		Stream stream2 = Class3.smethod_4(dictionary_4, text);
		try
		{
			if (stream2 != null)
			{
				byte[] byte_2 = Class3.smethod_5(stream2);
				return Class3.smethod_29(byte_, byte_2);
			}
		}
		finally
		{
			if (stream2 != null)
			{
				Class3.smethod_24(stream2);
			}
		}
		return Class3.smethod_30(byte_);
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00010880 File Offset: 0x0000EA80
	public static Assembly smethod_7(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object object_2 = Class3.object_0;
		bool flag = false;
		try
		{
			Class3.smethod_31(object_2, ref flag);
			if (Class3.dictionary_0.ContainsKey(Class3.smethod_32(resolveEventArgs_0)))
			{
				return null;
			}
		}
		finally
		{
			if (flag)
			{
				Class3.smethod_33(object_2);
			}
		}
		AssemblyName assemblyName_ = Class3.smethod_34(Class3.smethod_32(resolveEventArgs_0));
		Assembly assembly = Class3.smethod_1(assemblyName_);
		if (Class3.smethod_35(assembly, null))
		{
			return assembly;
		}
		assembly = Class3.smethod_6(Class3.dictionary_1, Class3.dictionary_2, assemblyName_);
		if (Class3.smethod_36(assembly, null))
		{
			object_2 = Class3.object_0;
			flag = false;
			try
			{
				Class3.smethod_31(object_2, ref flag);
				Class3.dictionary_0[Class3.smethod_32(resolveEventArgs_0)] = true;
			}
			finally
			{
				if (flag)
				{
					Class3.smethod_33(object_2);
				}
			}
			if ((Class3.smethod_37(assemblyName_) & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Class3.smethod_38(assemblyName_);
			}
		}
		return assembly;
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00003C4A File Offset: 0x00001E4A
	// Note: this type is marked as 'beforefieldinit'.
	static Class3()
	{
		Class3.dictionary_1.Add("costura", "costura.costura.dll.compressed");
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00003C88 File Offset: 0x00001E88
	public static void smethod_8()
	{
		if (Class3.smethod_40(ref Class3.int_0, 1) == 1)
		{
			return;
		}
		Class3.smethod_41(Class3.smethod_10(), new ResolveEventHandler(Class3.smethod_7));
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00003CAF File Offset: 0x00001EAF
	static string smethod_9(CultureInfo cultureInfo_0)
	{
		return cultureInfo_0.Name;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00003CB7 File Offset: 0x00001EB7
	static AppDomain smethod_10()
	{
		return AppDomain.CurrentDomain;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00003CBE File Offset: 0x00001EBE
	static Assembly[] smethod_11(AppDomain appDomain_0)
	{
		return appDomain_0.GetAssemblies();
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00003CC6 File Offset: 0x00001EC6
	static AssemblyName smethod_12(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00003CCE File Offset: 0x00001ECE
	static string smethod_13(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Name;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00003CD6 File Offset: 0x00001ED6
	static bool smethod_14(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string.Equals(string_0, string_1, stringComparison_0);
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00003CE0 File Offset: 0x00001EE0
	static CultureInfo smethod_15(AssemblyName assemblyName_0)
	{
		return assemblyName_0.CultureInfo;
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x0000397B File Offset: 0x00001B7B
	static void smethod_16(Stream stream_0, byte[] byte_0, int int_1, int int_2)
	{
		stream_0.Write(byte_0, int_1, int_2);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00003CE8 File Offset: 0x00001EE8
	static int smethod_17(Stream stream_0, byte[] byte_0, int int_1, int int_2)
	{
		return stream_0.Read(byte_0, int_1, int_2);
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00003CF3 File Offset: 0x00001EF3
	static Assembly smethod_18()
	{
		return Assembly.GetExecutingAssembly();
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00003CFA File Offset: 0x00001EFA
	static bool smethod_19(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00003D03 File Offset: 0x00001F03
	static Stream smethod_20(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00003D0C File Offset: 0x00001F0C
	static DeflateStream smethod_21(Stream stream_0, CompressionMode compressionMode_0)
	{
		return new DeflateStream(stream_0, compressionMode_0);
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00003D15 File Offset: 0x00001F15
	static MemoryStream smethod_22()
	{
		return new MemoryStream();
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00003D1C File Offset: 0x00001F1C
	static void smethod_23(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00002FDF File Offset: 0x000011DF
	static void smethod_24(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00003D25 File Offset: 0x00001F25
	static long smethod_25(Stream stream_0)
	{
		return stream_0.Length;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00003D2D File Offset: 0x00001F2D
	static string smethod_26(string string_0)
	{
		return string_0.ToLowerInvariant();
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x000037FF File Offset: 0x000019FF
	static bool smethod_27(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x000039C7 File Offset: 0x00001BC7
	static string smethod_28(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00003D35 File Offset: 0x00001F35
	static Assembly smethod_29(byte[] byte_0, byte[] byte_1)
	{
		return Assembly.Load(byte_0, byte_1);
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00003D3E File Offset: 0x00001F3E
	static Assembly smethod_30(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00003D46 File Offset: 0x00001F46
	static void smethod_31(object object_1, ref bool bool_0)
	{
		Monitor.Enter(object_1, ref bool_0);
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00003D4F File Offset: 0x00001F4F
	static string smethod_32(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00003D57 File Offset: 0x00001F57
	static void smethod_33(object object_1)
	{
		Monitor.Exit(object_1);
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00003D5F File Offset: 0x00001F5F
	static AssemblyName smethod_34(string string_0)
	{
		return new AssemblyName(string_0);
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00003D67 File Offset: 0x00001F67
	static bool smethod_35(Assembly assembly_0, Assembly assembly_1)
	{
		return assembly_0 != assembly_1;
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00003D70 File Offset: 0x00001F70
	static bool smethod_36(Assembly assembly_0, Assembly assembly_1)
	{
		return assembly_0 == assembly_1;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00003D79 File Offset: 0x00001F79
	static AssemblyNameFlags smethod_37(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Flags;
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00003D81 File Offset: 0x00001F81
	static Assembly smethod_38(AssemblyName assemblyName_0)
	{
		return Assembly.Load(assemblyName_0);
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00003D89 File Offset: 0x00001F89
	static object smethod_39()
	{
		return new object();
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00003D90 File Offset: 0x00001F90
	static int smethod_40(ref int int_1, int int_2)
	{
		return Interlocked.Exchange(ref int_1, int_2);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00003D99 File Offset: 0x00001F99
	static void smethod_41(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.AssemblyResolve += resolveEventHandler_0;
	}

	// Token: 0x0400012D RID: 301
	private static object object_0 = Class3.smethod_39();

	// Token: 0x0400012E RID: 302
	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	// Token: 0x0400012F RID: 303
	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	// Token: 0x04000130 RID: 304
	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	// Token: 0x04000131 RID: 305
	private static int int_0;
}
