using System;
using System.Windows.Forms;

// Token: 0x02000029 RID: 41
internal static class Class1
{
	// Token: 0x0600045D RID: 1117 RVA: 0x00003ADD File Offset: 0x00001CDD
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Form1());
	}
}
