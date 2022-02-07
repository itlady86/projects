/*
 * Created by SharpDevelop.
 * User: znalec
 * Date: 02.11.2020
 * Time: 16:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;


namespace statistika
{
	class Program
	{		
		public static string[] rceni = {
			"Jak se modlí počítačoví maniaci? Ve jménu otce, syna, i ducha svatého ENTER.",
			"Tatranky.zip – energie sbalená na cesty.",
			"Když dva dělají totéž, nemusí to být totéž. Co je u člověka schizofrenie, to je na počítači multitasking.",
			"Kdo se směje naposledy, má největší ping.",	
			"Zálohování je operace, kterou nikdy nestihnete včas.",
			"I skladník ve šroubárně si může psát vlastní SQL příkazy.",
			"Kolik programátorů je potřeba k výměně žárovky? Žádný. To je problém hardwaru.",
			"Není hloupých lidí, jen lidí co málo používají Google.",
			"Informatik je člověk, který se v potravinách diví, že kilo masa neváží 1024 gramů."
		};
		
		public static string samohlasky = "aáeéěiíoóuúůyý";
		public static string souhlasky = "bflmpsvzhkrdtnžščřcjďťňgqwx";
		public static string aktualniVeta;
		public static string mezera = " ";
		
		public static void Main(string[] args)
		{
			Console.WriteLine(">>> STATISTIKA VĚTY <<<\n");
			
			string pokracuj = "a";
		
			while (pokracuj == "a")
			{
				Console.WriteLine("Vylosovaný text: ");
				
				// vyber aktualni vety
				Random rnd = new Random();
						
				int los = rnd.Next(rceni.Length);
				aktualniVeta = rceni[los];
				
				Console.WriteLine(aktualniVeta);
				
				Statistika();
							
				Console.WriteLine("");
				Console.WriteLine("Další text? (A/N)");
				Console.WriteLine(" ");
								
									// ošetření vstupu
				pokracuj = Console.ReadLine().ToLower().Trim();
				
				switch (pokracuj) {
					case "a":
						Console.Clear();
						Console.WriteLine();
						break;
					case "n":
						Console.WriteLine("\nStisknutím klávesy ukonči program ...");
						Console.ReadKey();
						break;
					default:
						Console.WriteLine("Zadej A nebo N.");
						pokracuj = Console.ReadLine().ToLower().Trim();
						continue;
					}
			}
																
			Console.ReadKey(true);
		}
			
		
		static void Statistika()
		{	
			int pocetSamohlasek = 0;	
			int pocetSouhlasek = 0;	
			int pocetMezer = 0;
			int pocetOstatniZnaky = 0;
			
			
			foreach(char c in aktualniVeta.ToLower())
			{
				if(samohlasky.Contains(c))
					pocetSamohlasek++;
				else if(souhlasky.Contains(c))
					pocetSouhlasek++;
				else if (mezera.Contains(c))
					pocetMezer++;
				else 
					pocetOstatniZnaky++;
			}
			
			Console.WriteLine("");
			Console.WriteLine("Počet samohlásek je: {0}", pocetSamohlasek);
			Console.WriteLine("Počet souhlásek je: {0}", pocetSouhlasek );
			Console.WriteLine("Počet ostatních znaků je: {0}", aktualniVeta.Length - (pocetSamohlasek + pocetSouhlasek + pocetMezer));
			Console.WriteLine("Počet slov je: {0}", pocetMezer + 1);
			Console.WriteLine("Počet znaků celkem je: {0}", aktualniVeta.Length);
		}
			

		}
}