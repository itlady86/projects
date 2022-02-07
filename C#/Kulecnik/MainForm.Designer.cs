
namespace Kulecnik
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem CountOfBallMenu;
		public System.Windows.Forms.ToolStripMenuItem Item10;
		public System.Windows.Forms.ToolStripMenuItem Item15;
		public System.Windows.Forms.ToolStripMenuItem Item20;
		public System.Windows.Forms.ToolStripMenuItem Item25;
		public System.Windows.Forms.ToolStripMenuItem Item30;
		public System.Windows.Forms.ToolStripMenuItem ItemRnd;
		private System.Windows.Forms.ToolStripMenuItem ColorOfBalls;
		private System.Windows.Forms.ToolStripMenuItem ColorBW;
		private System.Windows.Forms.ToolStripMenuItem ColorRed;
		private System.Windows.Forms.ToolStripMenuItem ColorGreen;
		private System.Windows.Forms.ToolStripMenuItem ColorBlue;
		private System.Windows.Forms.ToolStripMenuItem BgMenu;
		private System.Windows.Forms.ToolStripMenuItem Bg1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox;
		public System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.TextBox Counter;
		private System.Windows.Forms.ToolStripMenuItem Bg2;
		private System.Windows.Forms.ToolStripMenuItem Bg3;
		private System.Windows.Forms.ToolStripMenuItem Bg4;
		private System.Windows.Forms.ToolStripMenuItem Bg5;
		private System.Windows.Forms.ToolStripMenuItem Bg6;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.ToolStripMenuItem ColorRnd;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.CountOfBallMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Item10 = new System.Windows.Forms.ToolStripMenuItem();
			this.Item15 = new System.Windows.Forms.ToolStripMenuItem();
			this.Item20 = new System.Windows.Forms.ToolStripMenuItem();
			this.Item25 = new System.Windows.Forms.ToolStripMenuItem();
			this.Item30 = new System.Windows.Forms.ToolStripMenuItem();
			this.ItemRnd = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorOfBalls = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorRnd = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorBW = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorRed = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorGreen = new System.Windows.Forms.ToolStripMenuItem();
			this.ColorBlue = new System.Windows.Forms.ToolStripMenuItem();
			this.BgMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.Bg1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Bg2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Bg3 = new System.Windows.Forms.ToolStripMenuItem();
			this.Bg4 = new System.Windows.Forms.ToolStripMenuItem();
			this.Bg5 = new System.Windows.Forms.ToolStripMenuItem();
			this.Bg6 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.infoLabel = new System.Windows.Forms.Label();
			this.Counter = new System.Windows.Forms.TextBox();
			this.buttonExit = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CountOfBallMenu,
			this.ColorOfBalls,
			this.BgMenu});
			this.menuStrip1.Location = new System.Drawing.Point(9, 9);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(487, 92);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// CountOfBallMenu
			// 
			this.CountOfBallMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Item10,
			this.Item15,
			this.Item20,
			this.Item25,
			this.Item30,
			this.ItemRnd});
			this.CountOfBallMenu.Image = ((System.Drawing.Image)(resources.GetObject("CountOfBallMenu.Image")));
			this.CountOfBallMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.CountOfBallMenu.Name = "CountOfBallMenu";
			this.CountOfBallMenu.Size = new System.Drawing.Size(153, 88);
			this.CountOfBallMenu.Text = "Počet kuliček";
			// 
			// Item10
			// 
			this.Item10.Name = "Item10";
			this.Item10.Size = new System.Drawing.Size(123, 22);
			this.Item10.Text = "10";
			this.Item10.Click += new System.EventHandler(this.Item10Click);
			// 
			// Item15
			// 
			this.Item15.Name = "Item15";
			this.Item15.Size = new System.Drawing.Size(123, 22);
			this.Item15.Text = "15";
			this.Item15.Click += new System.EventHandler(this.Item15Click);
			// 
			// Item20
			// 
			this.Item20.Name = "Item20";
			this.Item20.Size = new System.Drawing.Size(123, 22);
			this.Item20.Text = "20";
			this.Item20.Click += new System.EventHandler(this.Item20Click);
			// 
			// Item25
			// 
			this.Item25.Name = "Item25";
			this.Item25.Size = new System.Drawing.Size(123, 22);
			this.Item25.Text = "25";
			this.Item25.Click += new System.EventHandler(this.Item25Click);
			// 
			// Item30
			// 
			this.Item30.Name = "Item30";
			this.Item30.Size = new System.Drawing.Size(123, 22);
			this.Item30.Text = "30";
			this.Item30.Click += new System.EventHandler(this.Item30Click);
			// 
			// ItemRnd
			// 
			this.ItemRnd.Name = "ItemRnd";
			this.ItemRnd.Size = new System.Drawing.Size(123, 22);
			this.ItemRnd.Text = "Náhodně";
			this.ItemRnd.Click += new System.EventHandler(this.ItemRndClick);
			// 
			// ColorOfBalls
			// 
			this.ColorOfBalls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ColorRnd,
			this.ColorBW,
			this.ColorRed,
			this.ColorGreen,
			this.ColorBlue});
			this.ColorOfBalls.Image = ((System.Drawing.Image)(resources.GetObject("ColorOfBalls.Image")));
			this.ColorOfBalls.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.ColorOfBalls.Name = "ColorOfBalls";
			this.ColorOfBalls.Size = new System.Drawing.Size(152, 88);
			this.ColorOfBalls.Text = "Barva kuliček";
			// 
			// ColorRnd
			// 
			this.ColorRnd.Name = "ColorRnd";
			this.ColorRnd.Size = new System.Drawing.Size(159, 22);
			this.ColorRnd.Text = "Náhodná";
			this.ColorRnd.Click += new System.EventHandler(this.ColorRndClick);
			// 
			// ColorBW
			// 
			this.ColorBW.Name = "ColorBW";
			this.ColorBW.Size = new System.Drawing.Size(159, 22);
			this.ColorBW.Text = "Černobílé";
			this.ColorBW.Click += new System.EventHandler(this.ColorBWClick);
			// 
			// ColorRed
			// 
			this.ColorRed.Name = "ColorRed";
			this.ColorRed.Size = new System.Drawing.Size(159, 22);
			this.ColorRed.Text = "Odstíny červené";
			this.ColorRed.Click += new System.EventHandler(this.ColorRedClick);
			// 
			// ColorGreen
			// 
			this.ColorGreen.Name = "ColorGreen";
			this.ColorGreen.Size = new System.Drawing.Size(159, 22);
			this.ColorGreen.Text = "Odstíny zelené";
			this.ColorGreen.Click += new System.EventHandler(this.ColorGreenClick);
			// 
			// ColorBlue
			// 
			this.ColorBlue.Name = "ColorBlue";
			this.ColorBlue.Size = new System.Drawing.Size(159, 22);
			this.ColorBlue.Text = "Odstíny modré";
			this.ColorBlue.Click += new System.EventHandler(this.ColorBlueClick);
			// 
			// BgMenu
			// 
			this.BgMenu.Checked = true;
			this.BgMenu.CheckState = System.Windows.Forms.CheckState.Checked;
			this.BgMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Bg1,
			this.Bg2,
			this.Bg3,
			this.Bg4,
			this.Bg5,
			this.Bg6});
			this.BgMenu.Image = ((System.Drawing.Image)(resources.GetObject("BgMenu.Image")));
			this.BgMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.BgMenu.Name = "BgMenu";
			this.BgMenu.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
			this.BgMenu.Size = new System.Drawing.Size(170, 88);
			this.BgMenu.Text = "Barva pozadí";
			// 
			// Bg1
			// 
			this.Bg1.Name = "Bg1";
			this.Bg1.Size = new System.Drawing.Size(123, 22);
			this.Bg1.Text = "Bílé";
			this.Bg1.Click += new System.EventHandler(this.Bg1Click);
			// 
			// Bg2
			// 
			this.Bg2.Name = "Bg2";
			this.Bg2.Size = new System.Drawing.Size(123, 22);
			this.Bg2.Text = "Žluté";
			this.Bg2.Click += new System.EventHandler(this.Bg2Click);
			// 
			// Bg3
			// 
			this.Bg3.Name = "Bg3";
			this.Bg3.Size = new System.Drawing.Size(123, 22);
			this.Bg3.Text = "Modré";
			this.Bg3.Click += new System.EventHandler(this.Bg3Click);
			// 
			// Bg4
			// 
			this.Bg4.Name = "Bg4";
			this.Bg4.Size = new System.Drawing.Size(123, 22);
			this.Bg4.Text = "Šedé";
			this.Bg4.Click += new System.EventHandler(this.Bg4Click);
			// 
			// Bg5
			// 
			this.Bg5.Name = "Bg5";
			this.Bg5.Size = new System.Drawing.Size(123, 22);
			this.Bg5.Text = "Růžové";
			this.Bg5.Click += new System.EventHandler(this.Bg5Click);
			// 
			// Bg6
			// 
			this.Bg6.Name = "Bg6";
			this.Bg6.Size = new System.Drawing.Size(123, 22);
			this.Bg6.Text = "Náhodné";
			this.Bg6.Click += new System.EventHandler(this.Bg6Click);
			// 
			// menuStrip2
			// 
			this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.oProgramuToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(726, 9);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(176, 92);
			this.menuStrip2.TabIndex = 1;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// oProgramuToolStripMenuItem
			// 
			this.oProgramuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oProgramuToolStripMenuItem.Image")));
			this.oProgramuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
			this.oProgramuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
			this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(168, 88);
			this.oProgramuToolStripMenuItem.Text = "O programu";
			this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.OProgramuToolStripMenuItemClick);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(10, 108);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(892, 400);
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 5;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// infoLabel
			// 
			this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.infoLabel.Location = new System.Drawing.Point(256, 548);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(161, 23);
			this.infoLabel.TabIndex = 4;
			this.infoLabel.Text = "Aktuální počet kuliček:";
			this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Counter
			// 
			this.Counter.BackColor = System.Drawing.SystemColors.Window;
			this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Counter.Location = new System.Drawing.Point(423, 535);
			this.Counter.Name = "Counter";
			this.Counter.Size = new System.Drawing.Size(86, 41);
			this.Counter.TabIndex = 5;
			this.Counter.TabStop = false;
			this.Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Counter.WordWrap = false;
			// 
			// buttonExit
			// 
			this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
			this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonExit.Location = new System.Drawing.Point(736, 524);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.buttonExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buttonExit.Size = new System.Drawing.Size(165, 73);
			this.buttonExit.TabIndex = 7;
			this.buttonExit.Text = "Ukončit";
			this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(913, 611);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.Counter);
			this.Controls.Add(this.infoLabel);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kulecnik";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
