﻿// Token: 0x02000028 RID: 40
public partial class Form2 : global::System.Windows.Forms.Form
{
	// Token: 0x06000443 RID: 1091 RVA: 0x0000FD50 File Offset: 0x0000DF50
	private void InitializeComponent()
	{
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = global::Form2.smethod_17(global::Form2.smethod_16(typeof(global::Form2).TypeHandle));
		this.formSkin1 = new global::GControl18();
		this.flatCheckBox2 = new global::GControl2();
		this.flatLabel2 = new global::GClass4();
		this.flatLabel1 = new global::GClass4();
		this.flatCheckBox1 = new global::GControl2();
		this.Pass = new global::GControl15();
		this.Login = new global::GControl15();
		this.flatButton1 = new global::GControl1();
		this.flatClose1 = new global::GControl3();
		global::Form2.smethod_18(this.formSkin1);
		global::Form2.smethod_19(this);
		global::Form2.smethod_20(this.formSkin1, global::System.Drawing.Color.White);
		this.formSkin1.Color_1 = global::System.Drawing.Color.FromArgb(60, 70, 73);
		this.formSkin1.Color_2 = global::System.Drawing.Color.FromArgb(53, 58, 60);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.flatCheckBox2);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.flatLabel2);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.flatLabel1);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.flatCheckBox1);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.Pass);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.Login);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.flatButton1);
		global::Form2.smethod_22(global::Form2.smethod_21(this.formSkin1), this.flatClose1);
		global::Form2.smethod_23(this.formSkin1, global::System.Windows.Forms.DockStyle.Fill);
		this.formSkin1.Color_3 = global::System.Drawing.Color.IndianRed;
		global::Form2.smethod_25(this.formSkin1, global::Form2.smethod_24("Segoe UI", 12f));
		this.formSkin1.Color_0 = global::System.Drawing.Color.FromArgb(45, 47, 49);
		this.formSkin1.Boolean_0 = false;
		this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
		this.formSkin1.Name = "formSkin1";
		this.formSkin1.Size = new global::System.Drawing.Size(348, 230);
		this.formSkin1.TabIndex = 0;
		this.formSkin1.Text = "ProstoClipper - Авторизация";
		this.flatCheckBox2.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
		this.flatCheckBox2.Color_0 = global::System.Drawing.Color.FromArgb(45, 47, 49);
		this.flatCheckBox2.Color_1 = global::System.Drawing.Color.IndianRed;
		this.flatCheckBox2.Boolean_0 = false;
		this.flatCheckBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.flatCheckBox2.Font = new global::System.Drawing.Font("Segoe UI", 10f);
		this.flatCheckBox2.Location = new global::System.Drawing.Point(82, 145);
		this.flatCheckBox2.Name = "flatCheckBox2";
		this.flatCheckBox2.GEnum1_0 = global::GControl2.GEnum1.Style1;
		this.flatCheckBox2.Size = new global::System.Drawing.Size(131, 22);
		this.flatCheckBox2.TabIndex = 7;
		this.flatCheckBox2.Text = "Показать пароль";
		this.flatCheckBox2.Event_0 += new global::GControl2.GDelegate0(this.method_0);
		this.flatLabel2.AutoSize = true;
		this.flatLabel2.BackColor = global::System.Drawing.Color.Transparent;
		this.flatLabel2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11f, global::System.Drawing.FontStyle.Bold);
		this.flatLabel2.ForeColor = global::System.Drawing.Color.White;
		this.flatLabel2.Location = new global::System.Drawing.Point(14, 114);
		this.flatLabel2.Name = "flatLabel2";
		this.flatLabel2.Size = new global::System.Drawing.Size(62, 20);
		this.flatLabel2.TabIndex = 6;
		this.flatLabel2.Text = "Пароль";
		this.flatLabel1.AutoSize = true;
		this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
		this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11f, global::System.Drawing.FontStyle.Bold);
		this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
		this.flatLabel1.Location = new global::System.Drawing.Point(23, 79);
		this.flatLabel1.Name = "flatLabel1";
		this.flatLabel1.Size = new global::System.Drawing.Size(52, 20);
		this.flatLabel1.TabIndex = 5;
		this.flatLabel1.Text = "Логин";
		this.flatCheckBox1.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
		this.flatCheckBox1.Color_0 = global::System.Drawing.Color.FromArgb(45, 47, 49);
		this.flatCheckBox1.Color_1 = global::System.Drawing.Color.IndianRed;
		this.flatCheckBox1.Boolean_0 = false;
		this.flatCheckBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.flatCheckBox1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
		this.flatCheckBox1.Location = new global::System.Drawing.Point(219, 145);
		this.flatCheckBox1.Name = "flatCheckBox1";
		this.flatCheckBox1.GEnum1_0 = global::GControl2.GEnum1.Style1;
		this.flatCheckBox1.Size = new global::System.Drawing.Size(101, 22);
		this.flatCheckBox1.TabIndex = 4;
		this.flatCheckBox1.Text = "Запомнить";
		this.Pass.BackColor = global::System.Drawing.Color.Transparent;
		this.Pass.Boolean_3 = false;
		this.Pass.Location = new global::System.Drawing.Point(82, 110);
		this.Pass.Int32_0 = 32767;
		this.Pass.Boolean_2 = false;
		this.Pass.Name = "Pass";
		this.Pass.Boolean_0 = false;
		this.Pass.Size = new global::System.Drawing.Size(238, 29);
		this.Pass.TabIndex = 3;
		this.Pass.HorizontalAlignment_0 = global::System.Windows.Forms.HorizontalAlignment.Left;
		this.Pass.Color_0 = global::System.Drawing.Color.FromArgb(192, 192, 192);
		this.Pass.Boolean_1 = true;
		this.Login.BackColor = global::System.Drawing.Color.Transparent;
		this.Login.Boolean_3 = false;
		this.Login.Location = new global::System.Drawing.Point(82, 75);
		this.Login.Int32_0 = 32767;
		this.Login.Boolean_2 = false;
		this.Login.Name = "Login";
		this.Login.Boolean_0 = false;
		this.Login.Size = new global::System.Drawing.Size(238, 29);
		this.Login.TabIndex = 2;
		this.Login.HorizontalAlignment_0 = global::System.Windows.Forms.HorizontalAlignment.Left;
		this.Login.Color_0 = global::System.Drawing.Color.FromArgb(192, 192, 192);
		this.Login.Boolean_1 = false;
		this.flatButton1.BackColor = global::System.Drawing.Color.Transparent;
		this.flatButton1.Color_0 = global::System.Drawing.Color.IndianRed;
		this.flatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
		this.flatButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
		this.flatButton1.Location = new global::System.Drawing.Point(82, 173);
		this.flatButton1.Name = "flatButton1";
		this.flatButton1.Boolean_0 = false;
		this.flatButton1.Size = new global::System.Drawing.Size(238, 32);
		this.flatButton1.TabIndex = 1;
		this.flatButton1.Text = "Авторизоваться";
		this.flatButton1.Color_1 = global::System.Drawing.Color.FromArgb(243, 243, 243);
		this.flatButton1.Click += new global::System.EventHandler(this.flatButton1_Click);
		this.flatClose1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.flatClose1.BackColor = global::System.Drawing.Color.White;
		this.flatClose1.Color_0 = global::System.Drawing.Color.FromArgb(168, 35, 35);
		this.flatClose1.Font = new global::System.Drawing.Font("Marlett", 10f);
		this.flatClose1.Location = new global::System.Drawing.Point(318, 13);
		this.flatClose1.Name = "flatClose1";
		this.flatClose1.Size = new global::System.Drawing.Size(18, 18);
		this.flatClose1.TabIndex = 0;
		this.flatClose1.Text = "flatClose1";
		this.flatClose1.Color_1 = global::System.Drawing.Color.FromArgb(243, 243, 243);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(348, 230);
		base.Controls.Add(this.formSkin1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "Form2";
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "ProstoClipper";
		base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
		this.formSkin1.ResumeLayout(false);
		this.formSkin1.PerformLayout();
		base.ResumeLayout(false);
	}

	// Token: 0x04000121 RID: 289
	private global::GControl18 formSkin1;

	// Token: 0x04000122 RID: 290
	private global::GControl3 flatClose1;

	// Token: 0x04000123 RID: 291
	private global::GControl15 Pass;

	// Token: 0x04000124 RID: 292
	private global::GControl15 Login;

	// Token: 0x04000125 RID: 293
	private global::GControl1 flatButton1;

	// Token: 0x04000126 RID: 294
	private global::GClass4 flatLabel2;

	// Token: 0x04000127 RID: 295
	private global::GClass4 flatLabel1;

	// Token: 0x04000128 RID: 296
	private global::GControl2 flatCheckBox1;

	// Token: 0x04000129 RID: 297
	private global::GControl2 flatCheckBox2;
}
