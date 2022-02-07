using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
	
namespace DatabazeObci
{
	/// <summary>
	/// Description of Zdroj.
	/// </summary>
	public class Zdroj
	{
		public string filename = "obce.csv";	
		public static List<Obec> seznamObci = new List<Obec>();
		public static List<Obec> seznamTemp = new List<Obec>();
		public static int jednaStrana = 30;
		public static int aktualniStrana = 0; 
		public static string nic = "";
		public static Grafika g = new Grafika();
		public static Filtr f = new Filtr();
	
		
		/// <summary>
		/// načte testovací csv
		/// </summary>
		/// <param name="filename">zdrojový csv soubor (bin/debug)</param>
		public void NactiData(string filename)
		{
			string radka;
			using (StreamReader sr = new StreamReader(filename, Encoding.UTF8)) {
				while ((radka = sr.ReadLine()) !=null)		//načte jeden řádek
				{
					string[] sloupce = radka.Split(';');		//rozdělení řádku na sloupce podle separátoru
				
					seznamObci.Add(new Obec(sloupce[0], Int32.Parse(sloupce[1]), Int32.Parse(sloupce[2]), sloupce[3], sloupce[4], sloupce[5]));
				}
			}
		}
		
		/// <summary>
		/// Načtená data z dočasného listu vypíše do tabulky v konzoli
		/// </summary>
		public void ZobrazTabulku()
		{
			Console.SetCursorPosition(0,14);
			UlozDoTempListu();
			VypisData(aktualniStrana);
		}
			
		/// <summary>
		/// zkopírování seznamu obcí do dočasného listu  
		/// </summary>
		public void UlozDoTempListu()
		{	
			foreach (Obec o in seznamObci) {
				seznamTemp.Add(o);
			}
		}
			
		/// <summary>
		/// Data z dočasného listu - stránkování
		/// </summary>
		public void VypisData(int aktualniStrana)
		{
			SeradPodleObyvatel();			//defaultní řazení podle názvu obcí
			int start = AktualniStrana(Program.klavesa) * jednaStrana;
			for (int i = start; i < start + jednaStrana; i++) {
				if (i < seznamTemp.Count) {				
					Console.WriteLine(seznamTemp[i].ToString());
					}
				if (seznamTemp.Count <= i) {
					PrazdneRadky();
				} 
			}
		}
		
		/// <summary>
		/// Data z dočasného listu - řazení podle počtu obyvatel
		/// </summary>
		public void VypisData()
		{
			f.BubbleSort(f.seznamObjektu).OrderBy(o => o.pocetObyvatel).ToList();
			
			int start = AktualniStrana(Program.klavesa) * jednaStrana;
			for (int i = start; i < start + jednaStrana; i++) {
				if (i < seznamTemp.Count) {				
					Console.WriteLine(seznamTemp[i].ToString());
					}
				if (seznamTemp.Count <= i) {
					PrazdneRadky();
				} 
			}
		}

		/// <summary>
		/// po stisknutí F3 nastaví řazení podle počtu obyvatel, defaultně podle abecedy
		/// </summary>
		/// <param name="klavesa"></param>
		/// <returns></returns>
		public static bool PodleCehoRadit(ConsoleKey klavesa)
		{
			bool podleABC = true;			// defaultně podle abecedy
			if (Program.klavesa == ConsoleKey.F3) {
				podleABC = false;		//řadí podle pořadí	
			} 
			return podleABC;
		}
	
		
		/// <summary>
		/// seřadí obce podle počtu obyvatel
		/// </summary>
		public static void SeradPodleObyvatel()
		{
			if (PodleCehoRadit(Program.klavesa)) {
				seznamTemp.Sort();
			} else {
				f.BubbleSort(f.seznamObjektu).OrderBy(o => o.pocetObyvatel).ToList();
			}
		}
		
		/// <summary>
		/// DIVNÁ METODA, KTERÁ VYMAŽE DUPLICITNÍ ŘÁDKY NA KONCI VÝPISU ??? :-(((
		/// </summary>
		public void PrazdneRadky()
		{
			int limit = 150;			// ???
			for (int i = 0; i < limit; i++) {
				Console.Write(" ");
			}				
		}
		
		/// <summary>
		/// vypíše stavový řádek ve spodní části tabulky
		/// </summary>
		public void VypisStavovyRadek()
		{	
			Console.SetCursorPosition(0,45);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Načteno {0} záznamů   ", seznamTemp.Count);
			Console.WriteLine("Strana {0} z {1, -5}", AktualniStrana(Program.klavesa) + 1, CelkemStran());
			Console.ResetColor();
		}
		
		
		/// <summary>
		/// vypíše stavový řádek podle výsledků vyhledávání
		/// </summary>
		public void VypisStavovyRadekDleFiltru()
		{	
			Console.SetCursorPosition(0,45);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Načteno {0} záznamů   ", seznamTemp.Count);
			g.ClearLine(0,46,15);
			Console.ResetColor();
		}
	
		
		/// <summary>
		/// vrátí počet stran
		/// </summary>
		/// <returns></returns>
		public int CelkemStran()
		{
			int celkemStran = 0;
			int zbytekPoDeleni = seznamTemp.Count%jednaStrana;
			int podil = seznamTemp.Count/jednaStrana;
			if (zbytekPoDeleni == 0) {
				celkemStran += podil;
			} else
				celkemStran += podil + 1;
			return celkemStran;
		}
		
		/// <summary>
		/// vrátí aktuální stranu
		/// </summary>
		/// <param name="klavesa"></param>
		/// <returns></returns>
		public static int AktualniStrana(ConsoleKey klavesa)
		{
			return aktualniStrana;
		}
			
		/// <summary>
		/// konstruktor
		/// </summary>
		public Zdroj()
		{
		}
		
	}
}