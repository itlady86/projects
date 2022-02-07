/*
 * Created by SharpDevelop.
 * User: Lucie
 * Date: 07.11.2020
 * Time: 9:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;


namespace pexeso
{
	class Program
	{
		public static string[] karty = {"X", "X", "Z", "Z", "A", "A", "O", "O", 
										"K", "K", "F", "F", "M", "M", "P", "P"};
		
		public static string[] kartyVypis = new string[16];
		public static int aktualniHrac = 1;
		public static bool konecHry = false;
		public static string hrac1;
		public static string hrac2;
		public static int karta1;
		public static int karta2;
		public static string parKaret1 = "";
		public static string parKaret2 = "";
		public static string trefa = "";		
		public static int kolo = 1;
		public static byte otoceno_1;			// 0 karta není otočena, 1 karta je otočena
		public static byte otoceno_2;
		public static bool uhodnuto;			// není odhalena dvojice stejných karet -> false
			
		
		/* ##### MAIN ##### */
		public static void Main(string[] args)
		{	
			
			HlavniMenu();
			Console.ReadKey(true);
			
		}

		
		
		/// <summary>
		/// úvodní okno programu - jméno programu v barvě + náhled hracího pole, označení řádků a sloupců + menu 
		/// </summary>
		public static void HlavniMenu()
		{
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("      >>> PEXESO <<<       \n");
			Console.ResetColor();
			
			// vypis tabulky - radky x sloupce
			Console.WriteLine();
			Console.WriteLine("   ————A————B————C————D——" );
			Console.WriteLine("   |");
		
			for (int i = 0; i < kartyVypis.Length; i++) {
				kartyVypis[i] = "█";
				}
			
			for (int i = 0; i < kartyVypis.Length; i++) {
				switch (i) {
					case 0:
						Console.Write("  1|");
						break;
					case 4:
						Console.Write("  2|");
						break;
					case 8:
						Console.Write("  3|");
						break;
					case 12:
						Console.Write("  4|");
						break;
					}

				// vypis zamaskovaných karet
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("   " + kartyVypis[i] + "|");
				Console.ResetColor();
				if ((i+1)%4 == 0)
					Console.WriteLine("\n" + "   |");
					}
			Console.WriteLine();
			Console.WriteLine();
			
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("      >>> MENU <<<         ");
			Console.ResetColor();
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine();
			Console.WriteLine("    1 - Nová hra");
			Console.WriteLine("    2 - Načti hru");
			Console.WriteLine("    3 - Konec programu");
			Console.WriteLine();
			Console.ResetColor();
			
			Volba();
			
		}
		
		/// <summary>
		/// obsahuje hlavní menu - Nová hra, Načti hru a Konec programu
		/// </summary>
		public static void Volba()
		{			
			Console.Write("Zadej volbu:  ");
			int volba;
			do {
				while(!int.TryParse(Console.ReadLine(), out volba)) {					// ošetření vstupu - lze zadat pouze číslo
					Console.WriteLine("Neplatná volba.");
					Console.WriteLine("Zadej volbu:   ");
				} 
				if (volba >= 1 && volba <= 3) {
					switch(volba) {
						case 1:
							VykresliHru();
							RozdejKarty();
							while (!konecHry) {
								if (aktualniHrac == 1) 
									HerniKolo();
								else
									HerniKolo();
							} break;
						case 2:
							Console.WriteLine(" ... Wait for it ...");
							Console.ReadKey();
							Console.Clear();
							HlavniMenu();
							break;
						case 3:
							string vstup = "";
							Console.WriteLine("Opravdu ukončit? Q pro ukončení, jinak pokračuj libovolnou klávesou ...");
							vstup = Console.ReadLine().ToLower();
							if (vstup != "q") {
								Console.Clear();
								HlavniMenu();
							} else
								Environment.Exit(0);
							break;
					}
				}
			}
			while (volba > 3 || volba < 1); 				// vrací se na začátek, pokud je zadáno něco jiného než 1,2,3
						
		}
			
		
		/// <summary>
		/// smaže úvodní okno, čeká se na vstupy od hráčů
		/// </summary>
		public static void VykresliHru()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("      >>> PEXESO <<<       \n");
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Zadej jméno prvního hráče: ");
			hrac1 = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("Zadej jméno druhého hráče: ");
			hrac2 = Console.ReadLine().Trim();
			Console.ResetColor();
		}
		
		
		/// <summary>
		/// vypíše aktuální stav hry - počet odkrytých dvojic karet
		/// </summary>
		public static void StavHry()
		{
			Console.ResetColor();
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine();
			Console.WriteLine("Aktuální stav hry: ");
			Console.WriteLine("{0} - získané karty: {1} ", hrac1, parKaret1);
			Console.WriteLine("{0} - získané karty: {1} ", hrac2, parKaret2);
			Console.ResetColor();
		}
					
		
		/// <summary>
		/// vrací aktuálního hráče
		/// </summary>
		/// <param name="aktualniHrac"></param>
		/// <returns>vrací true/false</returns>
		public static bool KdoHraje(int aktualniHrac)
		{
			bool poradi = false;
			if (aktualniHrac == 1) 
				poradi = true;
			else if (aktualniHrac == 2) 
				poradi = true;
			return poradi;
		}
		
		
		/// <summary>
		/// vrací aktuálního hráče
		/// </summary>
		/// <param name="aktualniHrac"></param>
		/// <param name="hrac1"></param>
		/// <returns>vrací jméno hráče</returns>
		public static string KdoHraje(int aktualniHrac, string hrac1)
		{
			if (aktualniHrac == 1) {
				return hrac1;
			}
			else
				return hrac2;
		}
		
		
		/// <summary>
		/// přepíná mezi koly 1 a více
		/// </summary>
		/// <returns>1. kolo vrací false, další kolo vrací true</returns>
		public static bool UrciKolo()
		{
			bool dalsiKolo = false;
			
			if (kolo == 1) 
				dalsiKolo = false;
			else
				dalsiKolo = true;
			return
				dalsiKolo;
		}
		
		
		public static void HerniKolo()
		{
			while (KdoHraje(aktualniHrac)) {
				//Console.WriteLine(aktualniHrac);
				while (true){
					Console.WriteLine("Kolo:  "+ kolo);
					AktualniHerniPole();
					StavHry(); 
										
				//	Console.WriteLine(aktualniHrac);
					Console.WriteLine("\nNa tahu je: {0}", KdoHraje(aktualniHrac, hrac1) + ".");
					Console.WriteLine();
					otoceno_1 = 0;			//první karta není otočená
					otoceno_2 = 0;			//druhá karta není otočená

					Console.WriteLine("Otočeno 1: " + otoceno_1);
					Console.WriteLine("Otočeno 2: " + otoceno_2);					
					try {	
						Console.Write("Zadej první kartu (1 - 16):  ");
						karta1 = Convert.ToInt32(Console.ReadLine());
						if (karta1 > karty.Length) 
							Console.WriteLine("Taková karta neexistuje.");
						else if (VyrazeneKarty())
							Console.WriteLine("Tuto kartu nelze otočit.");
						else
							break;
					} catch (Exception e) {
						Console.WriteLine(e.Message);
					}
				}
				Console.Clear();
				Console.WriteLine();
				Console.WriteLine("# Kolo: " + kolo);
	//			Console.WriteLine("# Karta číslo: " + karta1);
	//			Console.WriteLine("# Odkrytá karta: " + karty[karta1 - 1]);
				Console.WriteLine("{0} vybral kartu: {1}", KdoHraje(aktualniHrac, hrac1), karta1);
	
				otoceno_1 = 1;		//první karta otočená
				Console.WriteLine("\nOtáčím vybranou kartu .... \n");
				AktualniHerniPole();
				
				Console.WriteLine("Otočeno 1: " + otoceno_1);
				Console.WriteLine("Otočeno 2: " + otoceno_2);
				while (true) {
					try {
						Console.Write("Zadej druhou kartu (1 - 16):  ");
						karta2 = Convert.ToInt32(Console.ReadLine());
						if (karta2 > karty.Length) 
							Console.WriteLine("Taková karta neexistuje.");
						else if (karta2 == karta1)
							Console.WriteLine("Tato karta je již otočena.");
						else if (VyrazeneKarty())
							Console.WriteLine("Tuto kartu nelze otočit.");
						else
							break;
					} catch (Exception e) {
						Console.WriteLine(e.Message);
					}
			}
					
			Console.WriteLine("{0} vybral kartu: {1}", KdoHraje(aktualniHrac, hrac1), karta2);
			otoceno_2 = 1;		//druhá karta otočená
			Console.WriteLine("# Kolo: " + kolo);
//			Console.WriteLine("# Karta číslo: " + karta2);
//			Console.WriteLine("# Odkrytá karta: " + karty[karta2 - 1]);
			Console.WriteLine("Otočeno 1: " + otoceno_1);
			Console.WriteLine("Otočeno 2: " + otoceno_2);
			Console.WriteLine("\nOtáčím vybranou kartu .... \n");
			AktualniHerniPole();
			
			if (Trefa()) {
				if (aktualniHrac == 1) {
					parKaret1 += karty[karta1-1] + ", " + karty[karta2-1] + ", ";
				}
				else if (aktualniHrac == 2) {
					parKaret2 += karty[karta1-1] + ", " + karty[karta2-1] + ", ";
				}
				
				trefa += karty[karta1-1];
				Console.WriteLine("Trefa: " + trefa);
				//AktualniHerniPole();
				
				Console.WriteLine("Otočeno 1: " + otoceno_1);
				Console.WriteLine("Otočeno 2: " + otoceno_2);
				
				Console.WriteLine("Skvělé! " + KdoHraje(aktualniHrac, hrac1) + " našel dvojici karet.");
				Console.WriteLine(uhodnuto);
				UlozHru();
				Console.WriteLine("Pokračuj libovolnou klávesou ...");
				Console.ReadKey();
				Console.Clear();
				kolo++;
				Console.WriteLine("Otočeno 1: " + otoceno_1);
				Console.WriteLine("Otočeno 2: " + otoceno_2);
							
			} else {
				kolo++;
				//AktualniHerniPole();
				if (aktualniHrac == 1)
					aktualniHrac ++;
				else
					aktualniHrac--;
				
				Console.WriteLine("Tato dvojice karet není stejná. Pokračuje {0}", KdoHraje(aktualniHrac, hrac1) + ".");
				//Console.WriteLine(aktualniHrac);
				Console.WriteLine("Pokračuj libovolnou klávesou ...");
				Console.ReadKey();
				Console.Clear();
				//AktualniHerniPole();
				}
			}
		}
	
	
		
		/// <summary>
		/// porovnává, jestli se 2. karta rovná 1. odkryté kartě
		/// </summary>
		/// <returns>pokud jsou karty stejné, vrací true</returns>
		public static bool Trefa()
		{
			for (int i = 0; i < karty.Length; i++) {
				if (karty[karta2-1] == karty[karta1-1] ) 
					uhodnuto = true;
				else
					uhodnuto = false;
			}	
			return uhodnuto;
		}
				
			
		/// <summary>
		/// pokud je uhodnuta dvojice karet, v dalším kole nesmí být zadáno číslo již uhodnuté karty
		/// </summary>
		/// <returns> </returns>
		public static bool VyrazeneKarty()
		{
			bool blokovanaKarta = false;
			
			if (kolo > 1) {
				for (int i = 0; i < karty.Length; i++) {
					if (aktualniHrac == 1) {
						foreach (char znak in parKaret1) 
						if (karty[karta1-1].Contains(znak) && karty[karta2-1].Contains(znak))
								blokovanaKarta = true;
					}
					else
						foreach (char znak in parKaret2) 
						if (karty[karta1-1].Contains(znak) && karty[karta2-1].Contains(znak))
								blokovanaKarta = true;
						}
			} else
				blokovanaKarta = false;
								
			return blokovanaKarta;
		}
		
		
		/// <summary>
		/// zobrazí aktuální herní pole
		/// </summary>
		public static void AktualniHerniPole()
		{
			if (KdoHraje(aktualniHrac)) {	// střídání hráčů
				if (!UrciKolo()) {			// 1. kolo
					//if (otoceno_1 == 1 && otoceno_2 == 0) 
						PrvniKarta();
					//else if (otoceno_1 == 1 && otoceno_2 == 1)
						DvojiceKaret();
					
				} else {
					if (uhodnuto) {
						if (otoceno_1 == 0 && otoceno_2 == 0)
							UhodnutoOdstranVse();
						else if (otoceno_1 == 1 && otoceno_2 == 0) 
							PrvniKarta();
						else if (otoceno_1 == 1 && otoceno_2 == 1) 
							DvojiceKaret();
						
					} else {
						if (otoceno_1 == 0 && otoceno_2 == 0)
							Console.WriteLine("AHA");
							
					
					}
				}
			}
		}
		
		
		public static void UhodnutoOdstranVse()
		{
			for (int i = 0; i < karty.Length; i++) {
				for (int j = 0; j < trefa.Length; j++) {
					string znak = Convert.ToString(trefa[j]);
					if (znak.Contains(karty[i]))
						Console.Write("  "+ "?" + " ");
					else 				
						Console.Write("  " + '█' + " ");
					if ((i+1)%4 == 0) 
						Console.Write("\n\n");
			
				}
			}
		}
				
		
		public static void Metoda()
		{
			
		}
		
		
						
		/// <summary>
		/// metoda pro vykreslení 1. odkryté karty
		/// </summary>
		public static void PrvniKarta()
		{
			for (int i = 0; i < karty.Length; i++) {
				if (otoceno_1 == 1 && otoceno_2 == 0) {				// 1. karta otočená a 2. ne
					if (karta1 == i+1) 
						Console.Write("  "+ karty[i] + " ");
					else 
						Console.Write("  " + '█' + " ");
					if ((i+1)%4 == 0) 
						Console.Write("\n\n");
				}
			}
		}
		
		/// <summary>
		/// metoda pro vykreslení obou odkrytých karet
		/// </summary>
		public static void DvojiceKaret()
		{
			for (int i = 0; i < karty.Length; i++) {
				if (otoceno_1 == 1 && otoceno_2 == 1) {				// obě karty otočené, vykresluje se bez ohledu na rovnost karet
					if (karta1 == i+1 || karta2 == i+1)
						Console.Write("  "+ karty[i] + " ");
					else 
						Console.Write("  " + '█' + " ");
					if ((i+1)%4 == 0) 
						Console.Write("\n\n");
				}
			}
		}
			
		
		/// <summary>
		/// metoda pro vykreslení herního pole bez uhodnutých karet
		/// </summary>
		public static void DvojiceMaska()
		{
			for (int i = 0; i < karty.Length; i++) {
				if (trefa.Contains(karty[karta1-1]) && trefa.Contains(karty[karta2-1]))
					if (karta1 == i+1 || karta2 == i+1) 
						Console.Write("  "+ " " + " ");
				else 
					Console.Write("  " + '█' + " ");
				if ((i+1)%4 == 0) 
					Console.Write("\n\n");
			}
		}
		


		
		
		/// <summary>
		/// uložení hry do souboru
		/// </summary>
		public static void UlozHru()
		{
			string volba;
			Console.WriteLine("Uložit rozehranou hru?");
			Console.WriteLine("Stisknutím S ulož, jinou klávesou pokračuj ...");
			volba = Console.ReadLine().ToLower().Trim();
			
			if (volba == "s") {
				Console.WriteLine("Ukládání hry do souboru ....");
				Console.WriteLine(" ... Wait for it ...");
				Console.ReadKey();
			}
			else
				Console.WriteLine("... hra neuložena ...");
			
		}
		


		
		
		
//		
		
		/// <summary>
		/// rozdá nové herní pole karet - reversem navrch
		/// </summary>
		public static void RozdejKarty()
		{
			Console.WriteLine();
			Console.WriteLine();
//			Random rnd = new Random();
						
			//naplnění pole kartami - natvrdo
//			for (int i = 0; i < karty.Length; i++) {
//				Console.Write("  " + karty[i] + " ");
//				if ((i+1)%4 == 0) {
//					Console.Write("\n\n");
//				}
//			}
				
			//zamaskování rozdaných karet
			for (int i = 0; i < karty.Length; i++) {
				Console.Write("  " + '█' + " ");
				if ((i+1)%4 == 0) {
					Console.Write("\n\n");
					}
				}
			}
		
		
		
				
		
		
		
		
		
		
		
		
		
	}
}
	