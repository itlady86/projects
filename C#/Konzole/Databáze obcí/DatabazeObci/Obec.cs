
using System;

namespace DatabazeObci
{
	/// <summary>
	/// Description of Obec.
	/// </summary>
	public class Obec : IComparable<Obec>
	{
		int IComparable<Obec>.CompareTo(Obec other)
		{
			return nazev.CompareTo(other.nazev);
		}
				
		public string nazev { get; set; }
		public int PSC { get; set; }
		public int pocetObyvatel { get; set; }
		public string kraj { get; set; }
		public string okres { get; set; }
		public string posta { get; set; }
		
		
		/// <summary>
		/// konstruktor
		/// </summary>
		/// <param name="nazev"></param>
		/// <param name="PSC"></param>
		/// <param name="pocetObyvatel"></param>
		/// <param name="kraj"></param>
		/// <param name="okres"></param>
		/// <param name="posta"></param>
		public Obec(string nazev, int PSC, int pocetObyvatel, string kraj, string okres, string posta)
		{
			this.nazev=nazev;
			this.PSC=PSC;
			this.pocetObyvatel=pocetObyvatel;
			this.kraj=kraj;
			this.okres=okres;
			this.posta=posta;
		}
		
		
		/// <summary>
		/// vrací výstup z CSV uspořádaný do naformátovaných sloupců
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			
			return string.Format("{0,-50}{1,-16}{2,-20}{3,-27}{4,-30}{5,-5}",  nazev, PSC, pocetObyvatel, kraj, okres, posta);
		}
			
	}
}
