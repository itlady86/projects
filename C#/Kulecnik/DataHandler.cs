
using System;
using System.Collections.Generic;
using System.Drawing;



namespace Kulecnik
{
	/// <summary>
	/// Description of DataHandler.
	/// </summary>
	public class DataHandler
	{
		public List<Kulicka> kulicky = new List<Kulicka>();
		public Kulicka k = new Kulicka();
		public Random rnd = new Random();
		public byte r = 0;
		public byte g = 0;
		public byte b = 0;
		public int count = 10;
		public int limit = 40;
		public bool isRandom;
		public bool isBlack = true;
		public bool isRed;
		public bool isGreen;
		public bool isBlue;
			
				
		public Color ReturnColor(byte r, byte g, byte b)
		{
			if(isBlack) {
				byte[] values = {0,66,89,217,230,191};
				int index = rnd.Next(0, values.Length);
				r = values[index];
				b = r;
				g = r;
			}
			
			if(isRandom) {
				r = (byte)rnd.Next(0,256);
				g = (byte)rnd.Next(0,256);
				b = (byte)rnd.Next(0,256);
			}
			
			if(isRed) {
				byte[] red = {201, 224, 210, 255, 255, 255, 255, 255};
				byte[] green = {42, 62, 107, 135, 168, 201, 227, 245};
				byte[] blue = {42, 62, 107, 135, 168, 201, 227, 245};
				int index = rnd.Next(red.Length);
				r = red[index];
				g = green[index];
				b = blue[index];
			}
			
			if(isGreen) {
				byte[] red = {43, 47, 55, 64, 81, 105, 140, 178, 202, 235};
				byte[] green = {136, 158, 178, 192, 207, 219, 233, 242, 241, 251};
				byte[] blue = {61, 68, 77, 87, 102, 124, 154, 187, 204, 238};
				int index = rnd.Next(red.Length);
				r = red[index];
				g = green[index];
				b = blue[index];
			}
			
			if(isBlue) {
				byte[] red = {24, 25, 28, 34, 51, 77, 116, 165, 208, 231};
				byte[] green = {100, 113, 126, 139, 154, 171, 192, 216, 235, 245};
				byte[] blue = {171, 194, 214, 230, 240, 247, 252, 255, 255, 255};
				int index = rnd.Next(red.Length);
				r = red[index];
				g = green[index];
				b = blue[index];
			}
				
			Color ColorTheBall = Color.FromArgb(r,g,b);
											
			return ColorTheBall;
		}
			
		
		
		public DataHandler()
		{
		}
	}
}
