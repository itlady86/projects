
using System;
using System.Drawing;


namespace Kulecnik
{
	/// <summary>
	/// Description of Kulicka.
	/// </summary>
	public class Kulicka
	{
		public int X {get; set;}
		public int Y {get; set;}
		public int VectorX {get; set;}
		public int VectorY {get; set;}
		public Color Barva;
		public static int Size = 40;
					
		
		public Kulicka() 
		{
		}
		
		public Kulicka(int x, int y, int vectorX, int vectorY, Color barva)
		{
			this.X = x;
			this.Y = y;
			this.VectorX = vectorX;
			this.VectorY = vectorY;
			this.Barva = barva;
		}
		
	}
}