namespace EsiniBulOyunu
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pnlKartlar = new Panel();
			gboYeniOyun = new GroupBox();
			rb5 = new RadioButton();
			rb4 = new RadioButton();
			rb3 = new RadioButton();
			rb2 = new RadioButton();
			rb1 = new RadioButton();
			btnOyunuBaslat = new Button();
			menuStrip1 = new MenuStrip();
			menuStrip2 = new MenuStrip();
			yeniOyunToolStripMenuItem = new ToolStripMenuItem();
			yeniOyunToolStripMenuItem1 = new ToolStripMenuItem();
			gboYeniOyun.SuspendLayout();
			menuStrip2.SuspendLayout();
			SuspendLayout();
			// 
			// pnlKartlar
			// 
			pnlKartlar.BackColor = Color.Transparent;
			pnlKartlar.Location = new Point(12, 49);
			pnlKartlar.Margin = new Padding(3, 4, 3, 4);
			pnlKartlar.Name = "pnlKartlar";
			pnlKartlar.Size = new Size(686, 800);
			pnlKartlar.TabIndex = 0;
			// 
			// gboYeniOyun
			// 
			gboYeniOyun.BackColor = Color.Transparent;
			gboYeniOyun.Controls.Add(rb5);
			gboYeniOyun.Controls.Add(rb4);
			gboYeniOyun.Controls.Add(rb3);
			gboYeniOyun.Controls.Add(rb2);
			gboYeniOyun.Controls.Add(rb1);
			gboYeniOyun.Controls.Add(btnOyunuBaslat);
			gboYeniOyun.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
			gboYeniOyun.Location = new Point(185, 197);
			gboYeniOyun.Name = "gboYeniOyun";
			gboYeniOyun.Size = new Size(329, 430);
			gboYeniOyun.TabIndex = 0;
			gboYeniOyun.TabStop = false;
			gboYeniOyun.Text = "Yeni Oyun";
			// 
			// rb5
			// 
			rb5.AutoSize = true;
			rb5.Location = new Point(44, 279);
			rb5.Name = "rb5";
			rb5.Size = new Size(135, 42);
			rb5.TabIndex = 5;
			rb5.TabStop = true;
			rb5.Text = "Çok Zor";
			rb5.UseVisualStyleBackColor = true;
			// 
			// rb4
			// 
			rb4.AutoSize = true;
			rb4.Location = new Point(44, 231);
			rb4.Name = "rb4";
			rb4.Size = new Size(80, 42);
			rb4.TabIndex = 4;
			rb4.TabStop = true;
			rb4.Text = "Zor";
			rb4.UseVisualStyleBackColor = true;
			// 
			// rb3
			// 
			rb3.AutoSize = true;
			rb3.Checked = true;
			rb3.Location = new Point(44, 183);
			rb3.Name = "rb3";
			rb3.Size = new Size(92, 42);
			rb3.TabIndex = 3;
			rb3.TabStop = true;
			rb3.Text = "Orta";
			rb3.UseVisualStyleBackColor = true;
			// 
			// rb2
			// 
			rb2.AutoSize = true;
			rb2.Location = new Point(44, 135);
			rb2.Name = "rb2";
			rb2.Size = new Size(104, 42);
			rb2.TabIndex = 2;
			rb2.TabStop = true;
			rb2.Text = "Kolay";
			rb2.UseVisualStyleBackColor = true;
			// 
			// rb1
			// 
			rb1.AutoSize = true;
			rb1.Location = new Point(44, 87);
			rb1.Name = "rb1";
			rb1.Size = new Size(159, 42);
			rb1.TabIndex = 1;
			rb1.TabStop = true;
			rb1.Text = "Çok Kolay";
			rb1.UseVisualStyleBackColor = true;
			// 
			// btnOyunuBaslat
			// 
			btnOyunuBaslat.Location = new Point(44, 345);
			btnOyunuBaslat.Name = "btnOyunuBaslat";
			btnOyunuBaslat.Size = new Size(219, 44);
			btnOyunuBaslat.TabIndex = 0;
			btnOyunuBaslat.Text = "Oyunu Başlat";
			btnOyunuBaslat.UseVisualStyleBackColor = true;
			btnOyunuBaslat.Click += btnOyunuBaslat_Click;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Location = new Point(0, 28);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(715, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			menuStrip2.ImageScalingSize = new Size(20, 20);
			menuStrip2.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem });
			menuStrip2.Location = new Point(0, 0);
			menuStrip2.Name = "menuStrip2";
			menuStrip2.Size = new Size(715, 28);
			menuStrip2.TabIndex = 2;
			menuStrip2.Text = "menuStrip2";
			// 
			// yeniOyunToolStripMenuItem
			// 
			yeniOyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem1 });
			yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
			yeniOyunToolStripMenuItem.Size = new Size(57, 24);
			yeniOyunToolStripMenuItem.Text = "Oyun";
			// 
			// yeniOyunToolStripMenuItem1
			// 
			yeniOyunToolStripMenuItem1.Name = "yeniOyunToolStripMenuItem1";
			yeniOyunToolStripMenuItem1.ShortcutKeys = Keys.F2;
			yeniOyunToolStripMenuItem1.Size = new Size(181, 26);
			yeniOyunToolStripMenuItem1.Text = "Yeni Oyun";
			yeniOyunToolStripMenuItem1.Click += yeniOyunToolStripMenuItem1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(715, 885);
			Controls.Add(gboYeniOyun);
			Controls.Add(pnlKartlar);
			Controls.Add(menuStrip1);
			Controls.Add(menuStrip2);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Eşini Bul Oyunu";
			gboYeniOyun.ResumeLayout(false);
			gboYeniOyun.PerformLayout();
			menuStrip2.ResumeLayout(false);
			menuStrip2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnlKartlar;
		private GroupBox gboYeniOyun;
		private Button btnOyunuBaslat;
		private RadioButton rb5;
		private RadioButton rb4;
		private RadioButton rb3;
		private RadioButton rb2;
		private RadioButton rb1;
		private MenuStrip menuStrip1;
		private MenuStrip menuStrip2;
		private ToolStripMenuItem yeniOyunToolStripMenuItem;
		private ToolStripMenuItem yeniOyunToolStripMenuItem1;
	}
}