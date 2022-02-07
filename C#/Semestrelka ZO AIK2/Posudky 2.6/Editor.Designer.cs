
namespace Posudky
{
	partial class Editor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("počítače", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("pevné disky", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("flash disky", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("paměťové karty", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Digitální fotoaparáty", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Bitové kopie", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("herní konzole", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("mobilní telefony", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("tablety", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("GPS navigace", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("DVR zařízení", System.Windows.Forms.HorizontalAlignment.Left);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pCNBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paměťováKartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoaparátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitováKopieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herníKonzoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPSNavigaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVRZařízeníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Posudek č.:";
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 10, 1, 10);
            this.toolStrip1.Size = new System.Drawing.Size(793, 77);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCNBToolStripMenuItem,
            this.hDDToolStripMenuItem,
            this.flashDiskToolStripMenuItem,
            this.paměťováKartaToolStripMenuItem,
            this.fotoaparátToolStripMenuItem,
            this.bitováKopieToolStripMenuItem,
            this.herníKonzoleToolStripMenuItem,
            this.mTToolStripMenuItem,
            this.tabletToolStripMenuItem,
            this.gPSNavigaceToolStripMenuItem,
            this.dVRZařízeníToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(141, 57);
            this.toolStripDropDownButton1.Text = "   Přidat stopu";
            // 
            // pCNBToolStripMenuItem
            // 
            this.pCNBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pCNBToolStripMenuItem.Image")));
            this.pCNBToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pCNBToolStripMenuItem.Name = "pCNBToolStripMenuItem";
            this.pCNBToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.pCNBToolStripMenuItem.Text = "počítač";
            this.pCNBToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemPC_Click);
            // 
            // hDDToolStripMenuItem
            // 
            this.hDDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hDDToolStripMenuItem.Image")));
            this.hDDToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hDDToolStripMenuItem.Name = "hDDToolStripMenuItem";
            this.hDDToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.hDDToolStripMenuItem.Text = "pevný disk";
            this.hDDToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemHD_Click);
            // 
            // flashDiskToolStripMenuItem
            // 
            this.flashDiskToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flashDiskToolStripMenuItem.Image")));
            this.flashDiskToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.flashDiskToolStripMenuItem.Name = "flashDiskToolStripMenuItem";
            this.flashDiskToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.flashDiskToolStripMenuItem.Text = "flash disk";
            this.flashDiskToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemFlash_Click);
            // 
            // paměťováKartaToolStripMenuItem
            // 
            this.paměťováKartaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paměťováKartaToolStripMenuItem.Image")));
            this.paměťováKartaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paměťováKartaToolStripMenuItem.Name = "paměťováKartaToolStripMenuItem";
            this.paměťováKartaToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.paměťováKartaToolStripMenuItem.Text = "paměťová karta";
            this.paměťováKartaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemMC_Click);
            // 
            // fotoaparátToolStripMenuItem
            // 
            this.fotoaparátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fotoaparátToolStripMenuItem.Image")));
            this.fotoaparátToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fotoaparátToolStripMenuItem.Name = "fotoaparátToolStripMenuItem";
            this.fotoaparátToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.fotoaparátToolStripMenuItem.Text = "fotoaparát";
            this.fotoaparátToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemCam_Click);
            // 
            // bitováKopieToolStripMenuItem
            // 
            this.bitováKopieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bitováKopieToolStripMenuItem.Image")));
            this.bitováKopieToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bitováKopieToolStripMenuItem.Name = "bitováKopieToolStripMenuItem";
            this.bitováKopieToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.bitováKopieToolStripMenuItem.Text = "bitová kopie";
            this.bitováKopieToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemDD_Click);
            // 
            // herníKonzoleToolStripMenuItem
            // 
            this.herníKonzoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("herníKonzoleToolStripMenuItem.Image")));
            this.herníKonzoleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.herníKonzoleToolStripMenuItem.Name = "herníKonzoleToolStripMenuItem";
            this.herníKonzoleToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.herníKonzoleToolStripMenuItem.Text = "herní konzole";
            this.herníKonzoleToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemPS_Click);
            // 
            // mTToolStripMenuItem
            // 
            this.mTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mTToolStripMenuItem.Image")));
            this.mTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mTToolStripMenuItem.Name = "mTToolStripMenuItem";
            this.mTToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.mTToolStripMenuItem.Text = "mobilní telefon";
            this.mTToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemMT_Click);
            // 
            // tabletToolStripMenuItem
            // 
            this.tabletToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabletToolStripMenuItem.Image")));
            this.tabletToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabletToolStripMenuItem.Name = "tabletToolStripMenuItem";
            this.tabletToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.tabletToolStripMenuItem.Text = "tablet";
            this.tabletToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemTab_Click);
            // 
            // gPSNavigaceToolStripMenuItem
            // 
            this.gPSNavigaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gPSNavigaceToolStripMenuItem.Image")));
            this.gPSNavigaceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gPSNavigaceToolStripMenuItem.Name = "gPSNavigaceToolStripMenuItem";
            this.gPSNavigaceToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.gPSNavigaceToolStripMenuItem.Text = "GPS navigace";
            this.gPSNavigaceToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemGPS_Click);
            // 
            // dVRZařízeníToolStripMenuItem
            // 
            this.dVRZařízeníToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dVRZařízeníToolStripMenuItem.Image")));
            this.dVRZařízeníToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dVRZařízeníToolStripMenuItem.Name = "dVRZařízeníToolStripMenuItem";
            this.dVRZařízeníToolStripMenuItem.Size = new System.Drawing.Size(191, 56);
            this.dVRZařízeníToolStripMenuItem.Text = "DVR zařízení";
            this.dVRZařízeníToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemDVR_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(139, 57);
            this.toolStripButton1.Text = "   Smazat stopu";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(139, 54);
            this.toolStripButton2.Text = "   Refresh";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(138, 54);
            this.toolStripButton3.Text = "Exportovat";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 57);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(139, 54);
            this.toolStripButton4.Text = "Návrat zpět";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv);
            this.groupBox1.Location = new System.Drawing.Point(4, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 611);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stopy";
            // 
            // lv
            // 
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "počítače";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "pevné disky";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "flash disky";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "paměťové karty";
            listViewGroup4.Name = "listViewGroup4";
            listViewGroup5.Header = "Digitální fotoaparáty";
            listViewGroup5.Name = "listViewGroup5";
            listViewGroup6.Header = "Bitové kopie";
            listViewGroup6.Name = "listViewGroup6";
            listViewGroup7.Header = "herní konzole";
            listViewGroup7.Name = "listViewGroup7";
            listViewGroup8.Header = "mobilní telefony";
            listViewGroup8.Name = "listViewGroup8";
            listViewGroup9.Header = "tablety";
            listViewGroup9.Name = "listViewGroup9";
            listViewGroup10.Header = "GPS navigace";
            listViewGroup10.Name = "listViewGroup10";
            listViewGroup11.Header = "DVR zařízení";
            listViewGroup11.Name = "listViewGroup11";
            this.lv.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(3, 16);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(777, 592);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_MouseDoubleClick);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generátor posudků";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem pCNBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashDiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paměťováKartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoaparátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitováKopieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herníKonzoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPSNavigaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVRZařízeníToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv;
    }
}
