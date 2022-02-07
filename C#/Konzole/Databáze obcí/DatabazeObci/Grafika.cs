
using System;
using System.Linq;

namespace DatabazeObci
{
	/// <summary>
	/// Description of Grafika.
	/// </summary>
	public class Grafika
	{
		public static int sirkaOkna = 60;
		public static int vyskaOkna = 11;		
		public int x = Console.WindowWidth/2 - sirkaOkna/4;
		public int y = Console.WindowHeight/2 - vyskaOkna/4;
		public int textBox = 23;
		public static string text1 = "Výpis podle jména obce";
		public static string text2 = "Výpis podle počtu obyvatel";
		public static string text3 = "Výpis obcí podle kraje";
		public static string text4 = "Zadej řetězec (3 - 5 znaků) a stiskni ENTER:";
		public static string text5 = "1. Zadej minimální počet obyvatel a stiskni ENTER:";
		public static string text6 = "2. Zadej maximální počet obyvatel a stiskni ENTER:";
		public static string text7 = "Zadej požadovaný kraj a stiskni ENTER:";
		public static Filtr f = new Filtr();
		public static Zdroj z = new Zdroj();
		public bool minJeOK;
		public bool maxJeOK;
		
		
		// ##########################################################
		// >>>> METODY PRO GRAFICKÉ VYKRESLENÍ CELÉ KONZOLE <<<< 
		
		/// <summary>
		/// výchozí nastavení konzole
		/// </summary>
		public void KonzoleVychozi()
		{
			Console.WindowHeight = 49;
			Console.WindowWidth = 150;
			Console.Title = ("Obce ČR");
			Console.CursorVisible = false;
		}
					
		/// <summary>
		/// Horní panel tabulky - grafické znázornění, oddělené čárami
		/// </summary>
		public void Hlavicka()
		{
			Console.Clear();
			Cara(0,0,Console.WindowWidth,ConsoleColor.Yellow);
			NadpisNaStred();
			Copyright();
			Navigace();
			Cara(0,11,Console.WindowWidth, ConsoleColor.Yellow);
			Console.ResetColor();
		}
		
		/// <summary>
		/// čára oddělující spodní část tabulky
		/// </summary>
		public void Paticka()
		{
			Cara(0,44,Console.WindowWidth, ConsoleColor.Yellow);
			Console.ResetColor();
		}
		
		/// <summary>
		/// metoda popisující dělící čáry
		/// </summary>
		/// <param name="x">pozice X</param>
		/// <param name="y">pozice Y</param>
		/// <param name="delka">délka čáry</param>
		/// <param name="barva">barva</param>
		public void Cara(int x, int y, int delka, ConsoleColor barva)
		{
			Console.SetCursorPosition(x,y);
			Console.ForegroundColor = barva;
			string cara = "";
			for (int i = 0; i < Console.WindowWidth; i++) {
				cara += new string ('═', Console.WindowWidth);
				break;
			}
			Console.WriteLine(cara);
		}
		
		/// <summary>
		/// grafický nadpis
		/// </summary>
		public void NadpisNaStred()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			string nadpis = @"                ██████╗  █████╗ ████████╗ █████╗ ██████╗  █████╗ ███████╗███████╗     ██████╗ ██████╗  ██████╗██╗     ██████╗██████╗ 
               ██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗╚══███╔╝██╔════╝    ██╔═══██╗██╔══██╗██╔════╝██║    ██╔════╝██╔══██╗
               ██║  ██║███████║   ██║   ███████║██████╔╝███████║  ███╔╝ █████╗      ██║   ██║██████╔╝██║     ██║    ██║     ██████╔╝
               ██║  ██║██╔══██║   ██║   ██╔══██║██╔══██╗██╔══██║ ███╔╝  ██╔══╝      ██║   ██║██╔══██╗██║     ██║    ██║     ██╔══██╗
               ██████╔╝██║  ██║   ██║   ██║  ██║██████╔╝██║  ██║███████╗███████╗    ╚██████╔╝██████╔╝╚██████╗██║    ╚██████╗██║  ██║
               ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝     ╚═════╝ ╚═════╝  ╚═════╝╚═╝     ╚═════╝╚═╝  ╚═╝";
			Console.WriteLine(String.Format("{0, " + ((Console.WindowWidth/2) + (nadpis.Length/2)) + "}", nadpis));
			Console.WriteLine();
			Console.ResetColor();
		}
	
		/// <summary>
		/// o autorovi ...
		/// </summary>
		public void Copyright()
		{
			string text = "    Lucie Názrová (c) 2021   ";
			Console.SetCursorPosition(Console.WindowWidth/2-text.Length/2, 9);
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write(text);
		}
				
		
		/// <summary>
		/// řádek s funkčními klávesami a jejich popisy
		/// </summary>
		public void Navigace()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			string[] klavesy = {" F1", "F2", "F3", "F4", "Up/Down", "PgUp/PgDown", "F10"};
			string[] popisy = {"Zobraz vše", "Filtr podle obce", "Filtr dle obyvatel", "Filtr dle kraje", "strana +/-", "strana +10/-10", "Konec  "};
			
			string navigace = "";
			for (int i = 0; i < klavesy.Length; i++) {
				for (int j = 0; j < popisy.Length; j++) {
					if (i == j) {
						navigace += string.Format("{0,-18}{1,-22}{2,-25}{3,-23}{4,-22}{5,-30}{6}", klavesy[0] + " " + popisy[0],klavesy[1]+ " " +popisy[1],klavesy[2]+ " " +popisy[2],klavesy[3]+ " " +popisy[3],klavesy[4]+ " " +popisy[4],klavesy[5]+ " " +popisy[5],klavesy[6]+ " " +popisy[6]);					}
				}
				break;
			}
			Console.WriteLine();
			Console.WriteLine(navigace);
			Console.ResetColor();
		}
	
		
		/// <summary>
		/// záhlaví tabulky
		/// </summary>
		public void Zahlavi()
		{
			Console.SetCursorPosition(0, 12);
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.White;
			string[] zahlavi = {" Obec", "PSČ", "Počet obyvatel", "Kraj", "Okres", "Pošta  "};
			string zahlaviTab = "";
			for (int i = 0; i < zahlavi.Length; i++) {
				zahlaviTab += string.Format("{0,-50}{1,-16}{2,-20}{3,-27}{4,-30}{5,-5}", zahlavi[0], zahlavi[1], zahlavi[2], zahlavi[3], zahlavi[4], zahlavi[5]);
				break;
			}
			Console.WriteLine(zahlaviTab);
			Console.WriteLine();
			Console.ResetColor();
		}
		
	

		// #################################################
		// >>> METODY PRO NAČTENÍ VSTUPŮ OD UŽIVATELE  <<<
		
		/// <summary>
		/// po stisknutí klávesy F1
		/// </summary>
		public void StisknutoF1()
		{   
			Zdroj.seznamObci.Clear();				//smaže vytvořené seznamy a naplní je znovu
			Zdroj.seznamTemp.Clear();
			Console.Clear();
			Hlavicka();
			Zahlavi();
			z.NactiData(z.filename);
			z.ZobrazTabulku();
			Paticka();
			Console.SetCursorPosition(0,45);			
			z.VypisStavovyRadek();
		}
		
		/// <summary>
		/// po stisknutí klávesy F2
		/// </summary>
		public void StisknutoF2()
		{
			StisknutoF1();
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(45,46);
			Console.WriteLine("\t" + text4 + "\t\t\t");
			Console.SetCursorPosition(93,46);
			Console.CursorVisible = true;
			f.retezecObec = Console.ReadLine().Trim();			
			Console.CursorVisible = false;
			ClearLine(45,46,Console.WindowWidth);

			// ošetření vstupu - uživatele může zadat cokoli, pokud to není v CSV, nezobrazí se nic
			
			if (f.retezecObec != "") {						
				f.FiltrPodleObce(f.retezecObec);
				Console.SetCursorPosition(50,47);
				Console.BackgroundColor = ConsoleColor.DarkBlue;
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\tZobrazuji obce začínající na: {0,5}\t", f.retezecObec);
				Console.ResetColor();
				ClearLine(45,46,0);
			}
		}
			
			
		/// <summary>
		/// po stisknutí klávesy F3
		/// </summary>			
		public void StisknutoF3()
		{
			StisknutoF1();
			if (ZadejMin()) {
				if(ZadejMax()) {
					f.FiltrPodleObyvatel(f.min, f.max);
					VystupF3();
				}
			}
		}
		
		
		/// <summary>
		/// načtení dolního intervalu pro filtrování
		/// </summary>
		public bool ZadejMin()
		{
			ClearLine(45,47,Console.WindowWidth);
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(45,46);
			Console.WriteLine("\t" + text5 + "\t\t");
			Console.SetCursorPosition(100, 46);
			Console.CursorVisible = true;
							
			try {
				f.min = Int32.Parse(Console.ReadLine());			
				Console.CursorVisible = false;
				
				//ošetření vstupu - dolní interval může být o 1 nižší než nejvyšší počet obyvatel
				int nejvicObyvatel = Zdroj.seznamTemp.Max(n => n.pocetObyvatel);
				if (f.min >= nejvicObyvatel-1) {
					minJeOK = false;
					NeplatnaHodnota();
					
				//ošetření vstupu - dolní interval by neměla být záporná čísla
				} else if (f.min < 0) {
					minJeOK = false;
					NeplatnaHodnota();
				} else
					minJeOK = true;
				
				//ošetření vstupu - musí být vloženo číslo
			} catch (Exception) {
				Console.CursorVisible = false;
				NeplatnaHodnota();
				minJeOK = false;
			}
			return minJeOK;
		}
			
		/// <summary>
		/// načtení horního intervalu pro filtrování
		/// </summary>
		public bool ZadejMax()
		{
			ClearLine(45,47,Console.WindowWidth);
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(45,46);
			Console.WriteLine("\t" + text6 + "\t\t");
			Console.SetCursorPosition(100, 46);
			Console.CursorVisible = true;
							
			try {
				f.max = Int32.Parse(Console.ReadLine());			
				Console.CursorVisible = false;
				
				//ošetření vstupu - horní interval by neměl být větší než nejvyšší počet obyvatel
				int nejvicObyvatel = Zdroj.seznamTemp.Max(n => n.pocetObyvatel);
				if (f.max > nejvicObyvatel) {
					maxJeOK = false;
					NeplatnaHodnota();
					
				//ošetření vstupu - dolní interval by neměla být záporná čísla	
				} else if (f.max < 0) {
					maxJeOK	= false;
					NeplatnaHodnota();
					
				//ošetření vstupu - maximum by mělo být větší než mininum
				} else if (f.max <= f.min) {
					maxJeOK	= false;
					NeplatnaHodnota();
				} else
					maxJeOK = true;
			
			// ošetření vstupu - horní interval musí být číslo
			} catch (Exception) {
				Console.CursorVisible = false;
				NeplatnaHodnota();
			}
			return maxJeOK;
		}
		
		/// <summary>
		/// grafický výpis neplatné hodnoty
		/// </summary>
		public void NeplatnaHodnota()
		{
			ClearLine(45,46,Console.WindowWidth);
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(45,47);
			Console.WriteLine("\t\t" + "   Neplatná hodnota !" + "\t\t");
			Console.ReadKey(true);
			ClearLine(45,47,Console.WindowWidth);
		}
	
					
		/// <summary>
		/// po stisknutí F3 a vyhodnocení vstupu
		/// </summary>
		public void VystupF3()
		{
			ClearLine(45,46,Console.WindowWidth);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.SetCursorPosition(45,47);
			Console.WriteLine("\t Zobrazuji obce, které mají {0} - {1} obyvatel. \t", f.min, f.max);
			Console.ResetColor();
			ClearLine(45,46,0);
		}

		
		/// <summary>
		/// po stisknutí klávesy F4
		/// </summary>
		public void StisknutoF4()
		{
			StisknutoF1();
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(45,46);
			Console.WriteLine("\t" + text7 + "\t\t\t\t");
			Console.SetCursorPosition(89,46);
			Console.CursorVisible = true;
			f.retezecKraj = Console.ReadLine().Trim();			
			Console.CursorVisible = false;
			ClearLine(45,46, Console.WindowWidth);
			
			// ošetření vstupu - uživatele může zadat cokoli, pokud to není v CSV, nezobrazí se nic
			
			if (f.retezecKraj != "") {
				f.FiltrPodleKraje(f.retezecKraj);
				Console.SetCursorPosition(50,47);
				Console.BackgroundColor = ConsoleColor.DarkBlue;
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\tZobrazuji obce v zadaném kraji ... \t");
				Console.CursorVisible = false;
				Console.ResetColor();
				ClearLine(45,46,0);
			} else
				ClearLine(45,46,0);
		}
		
		/// <summary>
		/// smaže řádek dle parametrů
		/// </summary>	
		public void ClearLine(int x, int y, int okraj)
		{
			Console.SetCursorPosition(x,y);
			Console.ResetColor();	
			Console.Write(new string(' ', okraj));
		}


		
	
		
		// ########################################################################
		// >>> NEPOUŽITÉ METODY <<<
 	 
		/// <summary>
		/// okno po stisknutí F1
		/// </summary>
		public void DialogoveOknoF1()
		{
			Console.SetCursorPosition(x,y);
			DolniCast(x,y+4,8);
			TextyF1();
		}
		
		/// <summary>
		/// okno po stisknutí F2
		/// </summary>
		public void DialogoveOknoF2()
		{
			Console.SetCursorPosition(x,y);
			HorniCast(x,y+2,3);
			DolniCast(x,y+5,8);
			TextBox();
			TextyF2();
			//UlozRetezec();
		}
		
		/// <summary>
		/// okno po stisknutí F3
		/// </summary>
		public void DialogoveOknoF3()
		{
			Console.SetCursorPosition(x,y);
			HorniCast(x,y+2,3);
			DolniCast(x,y+5,8);
			TextBox();
			TextyF3();
		}
		
		/// <summary>
		/// okno po stisknutí F4
		/// </summary>
		public void DialogoveOknoF4()
		{
			Console.SetCursorPosition(x,y);
			HorniCast(x,y+2,3);
			DolniCast(x,y+5,8);
			TextBox();
			TextyF4();
		}
				
		
		/// <summary>
		/// definice horního pruhu dialogového okna
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="vyskaHorniCasti"></param>
		public void HorniCast(int x, int y, int vyskaHorniCasti)
		{
			for (int i = 0; i < vyskaHorniCasti; i++) {
				Console.SetCursorPosition(x,y++);
				for (int j = 0; j < sirkaOkna; j++) {
					Console.BackgroundColor = ConsoleColor.DarkBlue;
					Console.Write(" ");
					Console.ResetColor();
				}
			}
		}
		
		
		/// <summary>
		/// definice dolního pruhu dialogového okna
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="vyskaDolniCasti"></param>
		public void DolniCast(int x, int y, int vyskaDolniCasti)
		{
			for (int i = 0; i < vyskaDolniCasti; i++) {
				Console.SetCursorPosition(x,y++);
				for (int j = 0; j < sirkaOkna; j++) {
					Console.BackgroundColor = ConsoleColor.DarkCyan;
					Console.Write(" ");
					Console.ResetColor();
				}
			}
		}
		
		
		/// <summary>
		/// definice textového pole dialogového okna
		/// </summary>
		public void TextBox()
		{
			Console.SetCursorPosition(x+20, y+10);
			Console.BackgroundColor = ConsoleColor.White;
			for (int i = 0; i < textBox; i++) {
				Console.Write(" ");
			}
		}

		/// <summary>
		/// text v okně dial. okně F1
		/// </summary>
		public void TextyF1()
		{
			Console.SetCursorPosition(x+16,y+6);
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("=============================");
			Console.SetCursorPosition(x+19,y+7);
			Console.WriteLine("Lucie Názrová (c) 2021");
			Console.SetCursorPosition(x+16,y+8);
			Console.WriteLine("=============================");
			Console.ResetColor();
		}
		
		
		/// <summary>
		/// text v okně dial. okně F2
		/// </summary>
		public void TextyF2()
		{
			Console.SetCursorPosition(x + 9,y + 3);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(String.Format("{0, " + (x/2 + (text1.Length/2)) + "}", text1));
			Console.ResetColor();
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(x+9,y + 7);
			Console.WriteLine((String.Format("{0, " + (x/2 + (text4.Length/2)) + "}", text4)));
			Console.ResetColor();
			
			Console.SetCursorPosition(x,y + 8);
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(x+23, y+10);
			Console.CursorVisible = true;
		}

		/// <summary>
		/// text v okně dial. okně F3
		/// </summary>
		public void TextyF3()
		{
			Console.SetCursorPosition(x+9,y + 3);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(String.Format("{0, " + (x/2 + (text2.Length/2)) + "}", text2));
			Console.ResetColor();
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(x+9,y + 7);
			Console.WriteLine((String.Format("{0, " + (x/2 + (text5.Length/2)) + "}", text5)));
			Console.ResetColor();
			Console.SetCursorPosition(x,y + 8);
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(x+23, y+10);
			Console.CursorVisible = true;
		}
			
		
		/// <summary>
		/// text v okně dial. okně F4
		/// </summary>
		public void TextyF4()
		{
			Console.SetCursorPosition(x + 9,y + 3);
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(String.Format("{0, " + (x/2 + (text3.Length/2)) + "}", text3));
			Console.ResetColor();
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(x+9,y + 7);
			Console.WriteLine((String.Format("{0, " + (x/2 + (text6.Length/2)) + "}", text6)));
			Console.ResetColor();
			Console.SetCursorPosition(x,y + 8);
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(x+23, y+10);
			Console.CursorVisible = true;
		}
		
		
		public void ClearDialog()
		{
			Console.Title = "TEST";
			Console.SetCursorPosition(x,y);
			Console.BackgroundColor = ConsoleColor.Magenta;
    		Console.WriteLine("test");
    		Console.ResetColor();
		}


		
		// ########################################################################	
				
		/// <summary>
		/// konstruktor
		/// </summary>
		public Grafika()
		{
		}
	}
}