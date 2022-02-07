/*
 * Created by SharpDevelop.
 * User: znalec
 * Date: 11.11.2020
 * Time: 16:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace Sibenice_no2
{
	class Program
	{
		public static string[] los = {
			
			"KDO SE SMEJE NAPOSLEDY, MA NEJVETSI PING.",
			"I SKLADNIK VE SROUBARNE SI MUZE PSAT VLASTNI SQL PRIKAZY.",
			"UDELAT COKOLI BLBUVZDORNYM JE NEMOZNE, PROTOZE BLBCI JSOU OHROMNE VYNALEZAVI.",
			"ZALOHOVANI JE OPERACE, KTEROU NIKDY NESTIHNETE VCAS.",
			"POCITAC JE ZARIZENI SLOUZICI K RESENI PROBLEMU, KTERE BY BEZ NEJ VUBEC NEVZNIKLY.",
			"U POCITACU SE NEDA NA NIC SPOLEHNOUT, ANI NA TO, ZE SE NEDA NA NIC SPOLEHNOUT.",
			"LIDE SE BUDOU CHOVAT ROZUMNE TEHDY A POUZE TEHDY, JESTLIZE VSECHNY OSTATNI MOZNOSTI JIZ BYLY VYCERPANY.",
			"ODSTRANENI JEDNE CHYBY VYVOLA ALESPON DVE NOVE."};

		public static int pocetZivotu = 6;
		public static string symboly = " .,ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		public static string ostatniZnaky = ".,:!?'";
		//public static string tajnaVeta = "";
		//public static string maskovanaVeta = "";
		public static string hadanaVeta = "";
		//public static string hadej = "";
		public static List<string> hadaneZnaky = new List<string>();	// list pro hádané znaky

		
		// ### MAIN ###
		public static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(">>> ŠIBENICE <<<\n");
							
			// hlavní smyčka programu
			Console.ResetColor();
					
			bool volba = true;
			int cislo = 0123456789;
						
			while (volba) {
				try {
					Console.Write(">> Vyber větu: [0-7]:  ");
					cislo = Convert.ToInt32(Console.ReadLine());				// ošetření výjimky
					if (cislo >= 0 && cislo <= 7) {
						Console.WriteLine(">> Zvolil jsi větu: {0}", cislo);
						break;
					} else
						Console.WriteLine(">> Zadej správné číslo.");
															
				} catch (Exception ex) {
					Console.WriteLine(">> " + ex.Message + " Zadej pouze číslo z uvedeného rozsahu.");
				}
			}
			
			string tajnaVeta = los[cislo];	
			string maskovanaVeta = "";
						
			foreach (char c in tajnaVeta) {
						for (int i = 1; i < symboly.Length; i++) {
					if (c == symboly[i]) {
						maskovanaVeta += "-";
						break;
					}
					else if (c == symboly[0]) {
						maskovanaVeta += symboly[0];
						break;
					}
				}
				for (int y = 0; y < ostatniZnaky.Length; y++) {
					if (c == ostatniZnaky[y]) {
						maskovanaVeta += ostatniZnaky[y];
						break;						
					}
				}
			}
							
			
			//test
			//Console.WriteLine("  ###  " + tajnaVeta);
						
			Console.WriteLine("\n" + "   " + maskovanaVeta + "\n");
			Console.WriteLine("\n>> Počet životů: {0}", pocetZivotu);
			while (pocetZivotu > 0) {
				Console.Write("\n>> Hádej písmeno:   ");
				string znak = Console.ReadLine().ToUpper().Trim();		// vložení znaku od uživatele + převod na velká písmena + odstraněnění bílých znaků
				// Console.WriteLine("Zadal jsi: {0}, " , znak);
				hadaneZnaky.Add(znak);							// uložení znaku do Listu
			
				if (Uhodnuto(hadanaVeta, tajnaVeta)) {
					Console.WriteLine("\n" + "   " + tajnaVeta);				// věta uhodnuta
					Console.WriteLine("\n>> Gratuluju! Tajná věta je odhalena!");
					break;
					
				} else if (tajnaVeta.Contains(znak)) {			// vložen správný znak
					Console.WriteLine("\n>> Dobrý tip.\n");
					hadanaVeta = HadejPismeno(tajnaVeta);
					Console.WriteLine("   " + hadanaVeta);
					Console.WriteLine("\n>> Počet životů: {0} ", pocetZivotu);
										
				} else {
					Console.WriteLine();
					Console.WriteLine(">> Smůla! Tento znak v hádané větě není.");
					pocetZivotu -= 1;
					Console.WriteLine("\n>> Počet životů: {0} ", pocetZivotu);
					Obesenec();
								
				}			
			}
			Console.WriteLine();
			if (pocetZivotu == 0) {
				Console.WriteLine(">> Konec hry.");
				Console.WriteLine("\n>> Hledaná věta byla:     {0}", tajnaVeta);
			}
							
			Console.ReadKey(true);
		}
		

		/// <summary>
		/// vyhodnocení, zda je sestavovaná věta stejná jako tajná věta
		/// </summary>
		/// <param name="hadanaVeta"></param>
		/// <param name="tajnaVeta"></param>
		/// <returns></returns>
		public static bool Uhodnuto(string hadanaVeta, string tajnaVeta)
		{
			bool uhodnuto = false;
			
			if (hadanaVeta == tajnaVeta) 
				uhodnuto = true;
			else
				uhodnuto = false;
			
			return uhodnuto;
		}
		
		
		
		 /// <summary>
		 /// po uhodnutí písmene se toto odkryje, zbytek by měl být pod --- 
		 /// </summary>
		 /// <param name="tajnaVeta"></param>
		 /// <returns></returns>
		public static string HadejPismeno(string tajnaVeta)			
		{
			string hadej = "";
			
			foreach (char c in tajnaVeta) {
				for (int i = 1; i < symboly.Length; i++) {
					for (int x = 0; x < hadaneZnaky.Count; x++) {
						string h = Convert.ToString(hadaneZnaky[x]);
						if (h.Contains(c)) {
							hadej += c;
							break;
						}
						else if (c == symboly[0]) {
							hadej += symboly[0];
							break;
						}
					}
					break;
				}
				for (int y = 0; y < ostatniZnaky.Length; y++) {
					if (c == ostatniZnaky[y]) {
						hadej += ostatniZnaky[y];
						break;						
					}
				}
			}
					
			return hadej;
		}	
					
			
				
		/// <summary>
		/// vykreslení oběšence
		/// </summary>
		public static void Obesenec()
		{	
			
			switch (pocetZivotu) {
				case 5:
					Console.WriteLine(@"
		┌─────┐
		|     ┘
		|     Q
		|	 
		|	 
		|	  
		|
		═══════════	"); break;
					
				case 4:
					Console.WriteLine(@"
		┌─────┐
		|     ┘
		|     Q
		|    \ 
		|	  
		|	  
		|
		═══════════	"); break;
					
				case 3:
					Console.WriteLine(@"
		┌─────┐
		|     ┘
		|     Q
		|    \ / 
		|	  
		|	  
		|
		═══════════	"); break;
										
				case 2:
					Console.WriteLine(@"
		┌─────┐
		|     ┘
		|     Q
		|    \ / 
		|     ▒
		|	  
		|
		═══════════	"); break;
					
				case 1:
					Console.WriteLine(@"
		┌─────┐
		|     ┘
		|     Q
		|    \ / 
		|     ▒
		|    /	  
		|
		═══════════	"); break;
					
				case 0:
					Console.WriteLine(@"
		┌─────┐
		|     ┘
		|     Q
		|    \ / 
		|     ▒
		|    / \  
		|
		═══════════	"); break;
					
			}
		}
	}
}


















