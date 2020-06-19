using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ProstoClipper.Properties;

// Token: 0x02000028 RID: 40
public partial class Form2 : Form
{
	// Token: 0x0600043E RID: 1086 RVA: 0x0000FABC File Offset: 0x0000DCBC
	public static bool smethod_0()
	{
		bool result;
		try
		{
			WebClient webClient = Form2.smethod_1();
			try
			{
				Stream stream = Form2.smethod_2(webClient, "http://www.google.com");
				try
				{
					result = true;
				}
				finally
				{
					if (stream != null)
					{
						Form2.smethod_3(stream);
					}
				}
			}
			finally
			{
				if (webClient != null)
				{
					Form2.smethod_3(webClient);
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x0000FB24 File Offset: 0x0000DD24
	public Form2()
	{
		this.InitializeComponent();
		this.flatCheckBox1.Boolean_0 = Settings.Default.Pos;
		if (this.flatCheckBox1.Boolean_0)
		{
			Form2.smethod_4(this.Login, Settings.Default.Login);
			Form2.smethod_4(this.Pass, Settings.Default.Pass);
		}
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0000FB8C File Offset: 0x0000DD8C
	private void flatButton1_Click(object sender, EventArgs e)
	{
		if (Form2.smethod_0())
		{
			string string_ = "http://45.88.76.158/clipper/i.php";
			WebClient webClient = Form2.smethod_1();
			try
			{
				NameValueCollection nameValueCollection_ = Form2.smethod_5();
				Form2.smethod_7(nameValueCollection_, "login", Form2.smethod_6(this.Login));
				Form2.smethod_7(nameValueCollection_, "password", Form2.smethod_6(this.Pass));
				Form2.smethod_7(nameValueCollection_, "count", "1");
				byte[] byte_ = Form2.smethod_8(webClient, string_, nameValueCollection_);
				Form2.string_0 = Form2.smethod_10(Form2.smethod_9(), byte_);
			}
			finally
			{
				if (webClient != null)
				{
					Form2.smethod_3(webClient);
				}
			}
			string text = Form2.string_0;
			if (text != null)
			{
				if (Form2.smethod_11(text, "1"))
				{
					if (this.flatCheckBox1.Boolean_0)
					{
						Settings.Default.Pos = this.flatCheckBox1.Boolean_0;
						Settings.Default.Login = Form2.smethod_6(this.Login);
						Settings.Default.Pass = Form2.smethod_6(this.Pass);
						Form2.smethod_12(Settings.Default);
					}
					else
					{
						Settings.Default.Pos = false;
						Settings.Default.Login = "";
						Settings.Default.Pass = "";
						Form2.smethod_12(Settings.Default);
					}
					Form2.smethod_13(new Form1());
					return;
				}
				if (Form2.smethod_11(text, "2"))
				{
					Form2.smethod_14("Неправильный логин или пароль!", " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				if (Form2.smethod_11(text, "3"))
				{
					Form2.smethod_15("0!");
					return;
				}
				if (!Form2.smethod_11(text, "6"))
				{
					return;
				}
				Form2.smethod_14("Проблема с сервером!", " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
		}
		else
		{
			Form2.smethod_14("Нет подключения к интернету!", " Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00003A75 File Offset: 0x00001C75
	private void method_0(object object_0)
	{
		if (this.flatCheckBox2.Boolean_0)
		{
			this.Pass.Boolean_1 = false;
			return;
		}
		this.Pass.Boolean_1 = true;
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00003A9D File Offset: 0x00001C9D
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			Form2.smethod_3(this.icontainer_0);
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x000039D1 File Offset: 0x00001BD1
	static WebClient smethod_1()
	{
		return new WebClient();
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00003ABC File Offset: 0x00001CBC
	static Stream smethod_2(WebClient webClient_0, string string_1)
	{
		return webClient_0.OpenRead(string_1);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002FDF File Offset: 0x000011DF
	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00002340 File Offset: 0x00000540
	static void smethod_4(Control control_0, string string_1)
	{
		control_0.Text = string_1;
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x000039FB File Offset: 0x00001BFB
	static NameValueCollection smethod_5()
	{
		return new NameValueCollection();
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00002476 File Offset: 0x00000676
	static string smethod_6(Control control_0)
	{
		return control_0.Text;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00003A02 File Offset: 0x00001C02
	static void smethod_7(NameValueCollection nameValueCollection_0, string string_1, string string_2)
	{
		nameValueCollection_0.Add(string_1, string_2);
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00003A0C File Offset: 0x00001C0C
	static byte[] smethod_8(WebClient webClient_0, string string_1, NameValueCollection nameValueCollection_0)
	{
		return webClient_0.UploadValues(string_1, nameValueCollection_0);
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x000038CF File Offset: 0x00001ACF
	static Encoding smethod_9()
	{
		return Encoding.UTF8;
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00003A16 File Offset: 0x00001C16
	static string smethod_10(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00003935 File Offset: 0x00001B35
	static bool smethod_11(string string_1, string string_2)
	{
		return string_1 == string_2;
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00003AC5 File Offset: 0x00001CC5
	static void smethod_12(SettingsBase settingsBase_0)
	{
		settingsBase_0.Save();
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x00003ACD File Offset: 0x00001CCD
	static void smethod_13(Control control_0)
	{
		control_0.Show();
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00003869 File Offset: 0x00001A69
	static DialogResult smethod_14(string string_1, string string_2, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_1, string_2, messageBoxButtons_0, messageBoxIcon_0);
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00003AD5 File Offset: 0x00001CD5
	static DialogResult smethod_15(string string_1)
	{
		return MessageBox.Show(string_1);
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00002068 File Offset: 0x00000268
	static Type smethod_16(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00003A3F File Offset: 0x00001C3F
	static ComponentResourceManager smethod_17(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00003A5D File Offset: 0x00001C5D
	static void smethod_18(Control control_0)
	{
		control_0.SuspendLayout();
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00003A6D File Offset: 0x00001C6D
	static void smethod_19(Control control_0)
	{
		control_0.SuspendLayout();
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00002372 File Offset: 0x00000572
	static void smethod_20(Control control_0, Color color_0)
	{
		control_0.BackColor = color_0;
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00002FBF File Offset: 0x000011BF
	static Control.ControlCollection smethod_21(Control control_0)
	{
		return control_0.Controls;
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00002B79 File Offset: 0x00000D79
	static void smethod_22(Control.ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x0000305D File Offset: 0x0000125D
	static void smethod_23(Control control_0, DockStyle dockStyle_0)
	{
		control_0.Dock = dockStyle_0;
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x000025D1 File Offset: 0x000007D1
	static Font smethod_24(string string_1, float float_0)
	{
		return new Font(string_1, float_0);
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x000025DA File Offset: 0x000007DA
	static void smethod_25(Control control_0, Font font_0)
	{
		control_0.Font = font_0;
	}

	// Token: 0x0400011F RID: 287
	private static string string_0;

	// Token: 0x04000120 RID: 288
	private IContainer icontainer_0;
}
