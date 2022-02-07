
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kulecnik
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		DataHandler DH = new DataHandler();
		public List<Kulicka> kulicky = new List<Kulicka>();
		public Kulicka k = new Kulicka();
		public Random rnd = new Random();
		public Color barva;
			
		public MainForm()
		{
			InitializeComponent();
			GenerateBalls(DH.count);
			timer1.Start();
		}
		
		public void OProgramuToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form About = new About();
			About.Show();
		}
		
		public void ButtonExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		// Hlavní programová smyčka
		public void Timer1Tick(object sender, EventArgs e)
		{
			Counter.Text = DH.count.ToString();
			MoveBalls();
			pictureBox.Refresh();
		}
			

	public void GenerateBalls(int count) 
		{
			for (int i = 0; i < count; i++) 
			{
				AddBall(barva);
				pictureBox.Refresh(); 
			}
		}
				
		
		public void AddBall(Color barva) 
		{
			int x = rnd.Next(0, pictureBox.Width - Kulicka.Size);
			int y = rnd.Next(0, pictureBox.Height - Kulicka.Size);
			int vectorX = rnd.Next(-1,2);
			int vectorY = rnd.Next(-1,2);
									
			barva = DH.ReturnColor(DH.r,DH.g,DH.b);
			
			kulicky.Add(new Kulicka(x, y, vectorX, vectorY, barva));
		}
			

		public void MoveBalls() 
		{
			foreach(Kulicka k in kulicky) {
					
				// prenastaveni vektoru v pripade dosazeni jednoho z okraju pictureboxu
				if (k.X == 0)
					k.VectorX = 1;
				if (k.Y == 0)
					k.VectorY = 1;
				if (k.X == pictureBox.Width - Kulicka.Size)
					k.VectorX = -1;
				if (k.Y == pictureBox.Height - Kulicka.Size)
					k.VectorY = -1;
				
				// posun souradnic pro hybnuti s kulickou
				k.X += k.VectorX;
				k.Y += k.VectorY;
			}
		}
		
				
		// vykresleni vsech kulicek, tam kde zrovna jsou a s barvou, kterou zrovna maji
		public void PictureBoxPaint(object sender, PaintEventArgs e)
		{
			foreach(Kulicka k in kulicky){
				Brush brush = new SolidBrush(k.Barva);
				e.Graphics.FillEllipse(brush, k.X, k.Y, Kulicka.Size, Kulicka.Size);
			}
		}
		
			
		/// <summary>
		/// Nastavení počtu kuliček
		/// </summary>
				
		public void Item10Click(object sender, EventArgs e)
		{
			DH.count = Convert.ToInt32(Item10.Text);
			RefreshKulicky();
		}
		
		public void Item15Click(object sender, EventArgs e)
		{
			DH.count = Convert.ToInt32(Item15.Text);
			RefreshKulicky();
		}
				
		public void Item20Click(object sender, EventArgs e)
		{
			DH.count = Convert.ToInt32(Item20.Text);
			RefreshKulicky();
		}
		
		public void Item25Click(object sender, EventArgs e)
		{
			DH.count = Convert.ToInt32(Item25.Text);
			RefreshKulicky();
		}
		
		public void Item30Click(object sender, EventArgs e)
		{
			DH.count = Convert.ToInt32(Item30.Text);
			RefreshKulicky();
		}
		
		public void ItemRndClick(object sender, EventArgs e)
		{
			DH.count = DH.rnd.Next(1, DH.limit);
			RefreshKulicky();
		}
		
		
		/// <summary>
		/// Nastavení barev kuliček
		/// </summary>
				
		public void ColorRndClick(object sender, EventArgs e)
		{
			DH.isRandom = true;
			DH.isBlack = false;
			DH.isRed = false;
			DH.isGreen = false;
			DH.isBlue = false;
			RefreshKulicky();
		}
				
		
		public void ColorBWClick(object sender, EventArgs e)
		{
			DH.isBlack = true;
			DH.isRandom = false;
			DH.isRed = false;
			DH.isGreen = false;
			DH.isBlue = false;
			RefreshKulicky();
		}
		
		public void ColorRedClick(object sender, EventArgs e)
		{
			DH.isRed = true;
			DH.isRandom = false;
			DH.isBlack = false;
			DH.isGreen = false;
			DH.isBlue = false;
			RefreshKulicky();
		}
		
		public void ColorGreenClick(object sender, EventArgs e)
		{
			DH.isGreen = true;
			DH.isRandom = false;
			DH.isRed = false;
			DH.isBlack = false;
			DH.isBlue = false;
			RefreshKulicky();
		}
		
		public void ColorBlueClick(object sender, EventArgs e)
		{
			DH.isBlue = true;
			DH.isRandom = false;
			DH.isRed = false;
			DH.isGreen = false;
			DH.isBlack = false;
			RefreshKulicky();			
		}
	
		public void RefreshKulicky() {
			kulicky.Clear();	
			GenerateBalls(DH.count);
		}
			
		/// <summary>
		/// Nastavení barvy pozadí
		/// </summary>
	
		public void Bg1Click(object sender, EventArgs e)
		{
			pictureBox.BackColor = Color.White;
	
		}
		public void Bg2Click(object sender, EventArgs e)
		{
			pictureBox.BackColor = Color.FromArgb(255, 243, 191);
		}
		
		public void Bg3Click(object sender, EventArgs e)
		{
			pictureBox.BackColor = Color.FromArgb(227, 250, 252);
		}
		
		public void Bg4Click(object sender, EventArgs e)
		{
			pictureBox.BackColor = Color.FromArgb(222, 226, 230);
		}
		
		public void Bg5Click(object sender, EventArgs e)
		{
			pictureBox.BackColor = Color.FromArgb(255, 222, 235);
		}
		
		public void Bg6Click(object sender, EventArgs e)
		{
			pictureBox.BackColor = Color.FromArgb(DH.rnd.Next(230, 256), DH.rnd.Next(220,256), DH.rnd.Next(230,256));
		}
		
				

	}
}
